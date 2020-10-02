using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class RegistroCD
    {
        SqlConnection cnx = ConexionCD.ConectarToBD();
        public RegistroCE BuscarByCod(string codigo)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "SELECT * FROM Registro WHERE codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            SqlDataReader drRegistro = cmd.ExecuteReader();
            RegistroCE registro = new RegistroCE();
            if (drRegistro.Read())
            {
                registro.Codigo = drRegistro["codigo"].ToString();
                registro.DniTrabajador = drRegistro["dniTrabajador"].ToString();
                registro.FechaRegistro = Convert.ToDateTime(drRegistro["fechaRegistro"].ToString());
                registro.HrEntradaReg = Convert.ToDateTime(drRegistro["hrEntradaReg"].ToString());
                registro.HrSalidaReg = Convert.ToDateTime(drRegistro["hrSalidaReg"].ToString());
                registro.RefrigObtenido = Convert.ToBoolean(drRegistro["refrigObtenido"].ToString());
                registro.MinutosTardanzas = Convert.ToInt32(drRegistro["minutosTardanzas"].ToString());
                registro.MinutosAnticipadas = Convert.ToInt32(drRegistro["minutosAnticipadas"].ToString());
            }
            cnx.Close();
            return registro;
        }
        
        public string Registrar(string dni, string tipoControl, DateTime horaRegistro)
        {
            if (dni == null || dni.Length != 8)
            {
                return "DNIincorrecto";
            }
            else
            {
                string codigo = string.Concat("RG", horaRegistro.ToString("ddMMyy"), "-", dni);
                HorarioCE horario = new HorarioCD().BuscarByDniAnnoMes(dni, horaRegistro);
                TimeSpan hrSalida = TimeSpan.FromMinutes(0);
                bool refrigObtenido = true;
                double minutosAnticipadas = 0;
                int filasAfectadas;
                RegistroCE registro = BuscarByCod(codigo);
                SqlCommand cmd = ConexionCD.CrearCmd(cnx);
                //using (SqlTransaction sqlTrans = cnx.BeginTransaction(IsolationLevel.ReadUncommitted))
                //{
                //try
                //{
                if (registro.Codigo == null)
                {
                    if (tipoControl == "Entrada")
                    {
                        double minutosTardanzas = (horaRegistro.TimeOfDay - horario.HrEntrada.TimeOfDay).TotalMinutes;
                        if (minutosTardanzas > 0)
                        {
                            refrigObtenido = false;
                        }
                        else
                        {
                            minutosTardanzas = 0;
                        }
                        cmd.CommandText = "INSERT INTO Registro VALUES (@codigo,@dni,@fecha,@hrEntrada,@hrSalida,@refrig,@minTard,@minAnt)";
                        cmd.Parameters.AddWithValue("@dni", dni);
                        cmd.Parameters.AddWithValue("@fecha", horaRegistro.Date);
                        cmd.Parameters.AddWithValue("@hrEntrada", horaRegistro.TimeOfDay);
                        cmd.Parameters.AddWithValue("@minTard", minutosTardanzas);
                    }
                    else
                    {
                        cnx.Close();
                        return "EntradaNoRegistrada";
                    }
                }
                else
                {
                    if (tipoControl == "Salida")
                    {
                        if (registro.HrSalidaReg.ToString("HH:mm") == "00:00")
                        {
                            minutosAnticipadas = (horaRegistro.TimeOfDay - horario.HrSalida.TimeOfDay).Negate().TotalMinutes;
                            if (minutosAnticipadas > 0)
                            {
                                refrigObtenido = false;
                            }
                            else
                            {
                                minutosAnticipadas = 0;
                                refrigObtenido &= registro.RefrigObtenido;
                            }
                            hrSalida = horaRegistro.TimeOfDay;
                            cmd.CommandText = "UPDATE Registro SET hrSalidaReg = @hrSalida, minutosAnticipadas = @minAnt, refrigObtenido = @refrig where codigo = @codigo";
                        }
                        else
                        {
                            cnx.Close();
                            return "SalidaRegistrada";
                        }

                    }
                    else
                    {
                        cnx.Close();
                        return "EntradaRegistrada";
                    }
                }
                cmd.Parameters.AddWithValue("@hrSalida", hrSalida);
                cmd.Parameters.AddWithValue("@refrig", refrigObtenido);
                cmd.Parameters.AddWithValue("@minAnt", minutosAnticipadas);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                //cmd.Transaction = sqlTrans;
                filasAfectadas = cmd.ExecuteNonQuery();
                //sqlTrans.Commit();
                //}
                //catch
                //{
                //sqlTrans.Rollback();
                //return "Problema";
                //}
                //}
                cnx.Close();
                return filasAfectadas.ToString();
            }
        }
        public DataTable ProcesarPlanilla(string annoMes)
        {
            /*SqlCommand cmd = ConexionCD.CrearCmd(cnx);
           
            cmd.CommandText = "Select sueldoBasico from trabajador inner join nivel on Trabajador.numNivel = nivel.numNivel where dni = @dni ";
            SqlDataReader drProcesar = cmd.ExecuteReader();
            double sueldo=0;
            if (drProcesar.Read())
            {
                sueldo = drProcesar.GetDouble(0);
            }
            drProcesar.Close();
            cmd.CommandText = "Select minutosTardanzas, minutosAnticipadas, refrigObtenido from Registro where dniTrabajador=@dni AND MONTH(fechaRegistro)=@mes";
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@mes", mes);
            drProcesar = cmd.ExecuteReader();
            int Tardanzas = 0;
            int Anticipadas = 0;
            double Refri= 0;
            while (drProcesar.Read())
            {
                if(Convert.ToInt32(drProcesar["minutosTardanzas"].ToString()) != 0)
                {
                    Tardanzas++;
                }
                if (Convert.ToInt32(drProcesar["minutosAnticipadas"].ToString()) != 0)
                {
                    Anticipadas++;
                }
                if(Convert.ToBoolean(drProcesar["refrigObtenido"].ToString()))
                {
                    Refri += sueldo / 100;
                }

            }*/
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "PlanillaMes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@annoMes", annoMes));
            SqlDataAdapter drPlanilla = new SqlDataAdapter(cmd);
            DataTable dtPlanilla = new DataTable();
            drPlanilla.Fill(dtPlanilla);
            cnx.Close();
            return dtPlanilla;


        }
        public DataTable CargarMes()
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "MostrarMes";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter drCargarMes = new SqlDataAdapter(cmd);
            DataTable dtCargarMes = new DataTable();
            drCargarMes.Fill(dtCargarMes);
            cnx.Close();
            return dtCargarMes;
        }
        public DataTable RegistrosByDia(DateTime fecha)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "RegistrosByDia";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            SqlDataAdapter daRegistro = new SqlDataAdapter(cmd);
            DataTable dtRegistro = new DataTable();
            daRegistro.Fill(dtRegistro);
            cnx.Close();
            return dtRegistro;
        }
        public DateTime PrimerRegistro()
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "SELECT MIN(fechaRegistro) FROM Registro";
            SqlDataReader drRegistro = cmd.ExecuteReader();
            DateTime fecha = DateTime.MinValue;
            if (drRegistro.Read())
            {
                fecha = drRegistro.GetDateTime(0);
            }
            cnx.Close();
            return fecha;
        }
        public DataTable Ausentes(DateTime fecha)
        {
            DataTable trabajadores = new TrabajadorCD().Listado();
            for (int i = 0; i < trabajadores.Rows.Count; i++)
            {
                string dni = trabajadores.Rows[i].ItemArray[0].ToString();
                DataTable registros = new RegistroCD().RegistrosByDia(fecha);
                for (int k = 0; k < registros.Rows.Count; k++)
                {
                    if (dni == registros.Rows[k].ItemArray[0].ToString())
                    {
                        trabajadores.Rows[i].Delete();
                    }
                }
            }
            trabajadores.Columns.Remove("NIVEL");
            trabajadores.Columns.Remove("SUELDO");
            return trabajadores;
        }
        public int RegistrosPrueba()
        {
            int mes = 4;
            DataTable trabajadores= new TrabajadorCD().Listado();
            DateTime annoMes;
            while (mes > 0)
            {
                //FECHA DE INICIO - 01 DE CADA MES
                annoMes = DateTime.Today.AddMonths(-mes).AddDays(-DateTime.Today.Day + 1);
                //RECORRER LISTA TRABAJADORES
                for (int i = 0; i < trabajadores.Rows.Count; i++)
                {
                    string dni = trabajadores.Rows[i].ItemArray[0].ToString();
                    //VERIFICAR SI YA EXISTEN HORARIOS EN MES DE INICIO
                    HorarioCE buscar = new HorarioCD().BuscarByDniAnnoMes(dni, annoMes);
                    if (buscar.Codigo != null)
                    {
                        //SI YA SE CREARON TERMINA EL MÉTODO
                        return 0;
                    }
                    //ESTABLECER HORARIO
                    SqlCommand cmd = ConexionCD.CrearCmd(cnx);
                    cmd.CommandText = "EstablecerHorario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    //fechaContador ES LA FECHA QUE RECORRE TODO EL MES
                    DateTime fechaContador = annoMes.Date;
                    TimeSpan hrE, hrS;
                    if (i < 10)
                    {
                        //TURNO MAÑANA
                        hrE = TimeSpan.FromHours(7);
                        hrS = TimeSpan.FromHours(15);
                    }
                    else
                    {
                        //TURNO TARDE
                        hrE = TimeSpan.FromHours(15);
                        hrS = TimeSpan.FromHours(23);
                    }
                    cmd.Parameters.Add(new SqlParameter("@HorE", hrE));
                    cmd.Parameters.Add(new SqlParameter("@HorS", hrS));
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    cmd.Parameters.Add(new SqlParameter("@AnnoMes", annoMes.ToString("yyyy-MM")));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    //HORAS REGISTRADAS DE ENTRADA Y SALIDA
                    TimeSpan hrEReg, hrSReg;
                    //WHILE PARA RECORRER TODO LOS DÍAS DEL MES
                    while (fechaContador < annoMes.AddMonths(1))
                    {
                        //PARA CREAR REGISTROS DIFERENTES
                        //HASTA EL TRABAJADOR N°5
                        if (i<5)
                        {
                            hrEReg = hrE.Add(TimeSpan.FromMinutes(new Random().Next(0, 5)));
                            hrSReg = hrS.Add(TimeSpan.FromMinutes(new Random().Next(0, 10)));
                        }
                        //HASTA EL TRABAJADOR N°10
                        else if (i<10)
                        {
                            hrEReg = hrE.Add(TimeSpan.FromMinutes(-new Random().Next(0, 10)));
                            hrSReg = hrS.Add(TimeSpan.FromMinutes(-new Random().Next(0, 5)));
                        }
                        //ETC...
                        else if (i<15)
                        {
                            hrEReg = hrE.Add(TimeSpan.FromMinutes(-new Random().Next(0, 6)));
                            hrSReg = hrS.Add(TimeSpan.FromMinutes(new Random().Next(0, 11)));
                        }
                        //ELSE PARA LOS QUE NO ASISTIERON
                        else
                        {
                            hrEReg = TimeSpan.FromMinutes(0);
                            hrSReg = TimeSpan.FromMinutes(0);
                        }
                        //IF SOLO PARA LOS QUE SÍ ASISTIERON
                        if (hrEReg.TotalMinutes > 0)
                        {
                            DateTime fechaEntrada, fechaSalida;
                            fechaEntrada = fechaContador.Date + hrEReg;
                            fechaSalida = fechaContador.Date + hrSReg;
                            if (fechaContador.ToString("dddd") != "domingo")
                            {
                                //REGISTRAR ENTRADA FICTICIA
                                Registrar(dni, "Entrada", fechaEntrada);
                                //REGISTRAR SALIDA FICTICIA
                                Registrar(dni, "Salida", fechaSalida);
                            }
                        }
                        //SIGUIENTE DÍA
                        fechaContador = fechaContador.AddDays(1);
                    }
                }
                //SIGUIENTE MES
                mes--;
            }
            return 1;
        }
        public DataTable RangoMeses(string annoMesInicio, string annoMesFin)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "RangoMeses";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@annoMesInicio", annoMesInicio));
            cmd.Parameters.Add(new SqlParameter("@annoMesFin", annoMesFin));
            SqlDataAdapter drPlanilla = new SqlDataAdapter(cmd);
            DataTable dtPlanilla = new DataTable();
            drPlanilla.Fill(dtPlanilla);
            cnx.Close();
            return dtPlanilla;
        }
        public DataTable CargarAnno()
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "MostrarAnno";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter drCargarAnno = new SqlDataAdapter(cmd);
            DataTable dtCargaAnno = new DataTable();
            drCargarAnno.Fill(dtCargaAnno);
            cnx.Close();
            return dtCargaAnno;
        }
        public DataTable PlanillaAnual(int anno)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "PlanillaAnual";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@anno", anno));
            SqlDataAdapter drPlanilla = new SqlDataAdapter(cmd);
            DataTable dtPlanilla = new DataTable();
            drPlanilla.Fill(dtPlanilla);
            cnx.Close();
            return dtPlanilla;
        }
    }
}

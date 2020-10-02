using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        
        public string Registrar(TrabajadorCE trabajador, string tipoControl, DateTime horaRegistro)
        {
            string dni = trabajador.Dni;
            if (dni == null || dni.Length != 8)
            {
                return "DNIincorrecto";
            }
            else
            {
                string codigo = string.Concat("RG", dni, "-", horaRegistro.ToString("ddMMyy"));
                HorarioCE horario = new HorarioCD().BuscarByDniAnnoMes(dni, horaRegistro);
                DateTime hrSalida = Convert.ToDateTime("00:00:00");
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
                        double minutosTardanzas = (horaRegistro - horario.HrEntrada).TotalMinutes;
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
                        cmd.Parameters.AddWithValue("@hrEntrada", horaRegistro);
                        cmd.Parameters.AddWithValue("@minTard", minutosTardanzas);
                    }
                    else
                    {
                        return "EntradaNoRegistrada";
                    }
                }
                else
                {
                    if (tipoControl == "Salida")
                    {
                        if (registro.HrSalidaReg == Convert.ToDateTime("00:00:00"))
                        {
                            minutosAnticipadas = (horaRegistro - horario.HrSalida).Negate().TotalMinutes;
                            if (minutosAnticipadas > 0)
                            {
                                refrigObtenido = false;
                            }
                            else
                            {
                                minutosAnticipadas = 0;
                                refrigObtenido &= registro.RefrigObtenido;
                            }
                            hrSalida = horaRegistro;
                            cmd.CommandText = "UPDATE Registro SET hrSalidaReg = @hrSalida, minutosAnticipadas = @minAnt, refrigObtenido = @refrig where codigo = @codigo";
                        }
                        else
                        {
                            return "SalidaRegistrada";
                        }

                    }
                    else
                    {
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
    }
}

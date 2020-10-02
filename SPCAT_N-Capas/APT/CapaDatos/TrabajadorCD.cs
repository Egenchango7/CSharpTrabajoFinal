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
    public class TrabajadorCD
    {
        SqlConnection cnx = ConexionCD.ConectarToBD();
        public DataTable BuscarByDni(string dni)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "TrabajadorByDni";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@dni", dni));
            cmd.Parameters.Add(new SqlParameter("@annoMes", DateTime.Now.ToString("yyyy-MM")));
            SqlDataAdapter daTrabajador = new SqlDataAdapter(cmd);
            DataTable dtTrabajador = new DataTable();
            daTrabajador.Fill(dtTrabajador);
            cnx.Close();
            return dtTrabajador;
        }
        
        public DataTable BuscarPorNombre(string nombre)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "TrabajadorByNombre";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
            cmd.Parameters.Add(new SqlParameter("@annoMes", DateTime.Now.ToString("yyyy-MM")));
            SqlDataAdapter drTrabajador = new SqlDataAdapter(cmd);
            DataTable dtTrabajador = new DataTable();
            drTrabajador.Fill(dtTrabajador);
            cnx.Close();
            return dtTrabajador;
        }
        public List<string> Filtros()
        {
            DataTable dtFiltros = Listado();

            List<string> filtros = new List<string>();
            for (int i = 0; i < dtFiltros.Columns.Count-1; i++)
            {
                filtros.Add(dtFiltros.Columns[i].ColumnName);
            }
            cnx.Close();
            return filtros;
        }
        public DataTable Busqueda(string filtro, string valor)
        {
            DataTable dtResultado = new DataTable();
            if (valor.Length > 0)
            {
                if (filtro == "NOMBRE")
                {
                    dtResultado = BuscarPorNombre(valor);
                }
                else if (filtro == "DNI")
                {
                    dtResultado = BuscarByDni(valor);
                }
                else if (filtro == "ENTRADA")
                {
                    dtResultado = BuscarPorHrEntrada(Convert.ToDateTime(valor));
                }
                else if (filtro == "SALIDA")
                {
                    dtResultado = BuscarPorHrSalida(Convert.ToDateTime(valor));
                }
                else if (filtro == "NIVEL")
                {
                    dtResultado = BuscarPorNivel(Convert.ToInt32(valor));
                }
            }
            else
            {
                dtResultado = Listado();
            }
            return dtResultado;
        }
        public DataTable BuscarPorNivel(int nivel)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "TrabajadorByNivel";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@nivel", nivel));
            cmd.Parameters.Add(new SqlParameter("@annoMes", DateTime.Now.ToString("yyyy-MM")));
            SqlDataAdapter drTrabajador = new SqlDataAdapter(cmd);
            DataTable dtTrabajador = new DataTable();
            drTrabajador.Fill(dtTrabajador);
            cnx.Close();
            return dtTrabajador;
        }
        public DataTable BuscarPorHrEntrada(DateTime hrEntrada)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "TrabajadorByEntrada";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@hr", hrEntrada));
            cmd.Parameters.Add(new SqlParameter("@annoMes", DateTime.Now.ToString("yyyy-MM")));
            SqlDataAdapter drTrabajador = new SqlDataAdapter(cmd);
            DataTable dtTrabajador = new DataTable();
            drTrabajador.Fill(dtTrabajador);
            cnx.Close();
            return dtTrabajador;
        }
        public DataTable BuscarPorHrSalida(DateTime hrSalida)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "TrabajadorBySalida";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@hr", hrSalida));
            cmd.Parameters.Add(new SqlParameter("@annoMes", DateTime.Now.ToString("yyyy-MM")));
            SqlDataAdapter drTrabajador = new SqlDataAdapter(cmd);
            DataTable dtTrabajador = new DataTable();
            drTrabajador.Fill(dtTrabajador);
            cnx.Close();
            return dtTrabajador;
        }
        public DataTable Listado()
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "ListaTrabajador";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@annoMes", DateTime.Now.ToString("yyyy-MM")));
            SqlDataAdapter drTrabajador = new SqlDataAdapter(cmd);
            DataTable dtTrabajador = new DataTable();
            drTrabajador.Fill(dtTrabajador);
            cnx.Close();
            return dtTrabajador;
        }
        public TrabajadorCE Login(string usuario, string contra)
        {
            //Crear el comando vinculado a la conexion
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            //Agregar la instruccion SQL 
            cmd.CommandText = "select * from Trabajador where nomUsuario = @usuario and contrasena = @contra";
            //Asignar el valor al parametro
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contra", contra);
            //Ejecutar el comando
            SqlDataReader reader = cmd.ExecuteReader();
            TrabajadorCE trabajador = new TrabajadorCE();
            if (reader.Read())
            {
                trabajador.Dni = reader.GetString(0);
                trabajador.Nombre = reader.GetString(1);
                trabajador.Cargo = reader.GetString(2);
                trabajador.NumNivel = reader.GetInt32(3);
                trabajador.NomUsuario = reader.GetString(4);
                trabajador.Contrasena = reader.GetString(5);
            }            
            //Cerrar la conexion
            cnx.Close();
            return trabajador;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria para Sql
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ConexionCD
    {
        public static SqlConnection ConectarToBD()
        {
            //Instanciar un Generador de Cadena de Conexion
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            //Asignar valores a las propiedades del StringBuilder
            stringBuilder.DataSource = "127.0.0.1"; //SERVIDOR
            stringBuilder.InitialCatalog = "BDTRABAJOFINAL"; //BASE DE DATOS
            stringBuilder.UserID = "sa"; //USUARIO
            stringBuilder.Password = "Egenchango7347"; //CONTRASEÑA
            //Recibir la cadena de conexion
            string cadena = stringBuilder.ConnectionString;

            //Crear un Objeto de Conexion a SQL SERVER
            SqlConnection sqlConnection = new SqlConnection(cadena);

            return sqlConnection;

        }
        public static SqlCommand CrearCmd(SqlConnection cnx)
        {
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            return cmd;
        }
    }
}

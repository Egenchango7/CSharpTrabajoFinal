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
        public TrabajadorCE BuscarByDni(string dni)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "SELECT * FROM Trabajador WHERE dni = @dni";
            cmd.Parameters.AddWithValue("@dni", dni);
            SqlDataReader drTrabajador = cmd.ExecuteReader();
            TrabajadorCE trabajador = new TrabajadorCE();
            if (drTrabajador.Read())
            {
                trabajador.Dni = drTrabajador["dni"].ToString();
                trabajador.Nombre = drTrabajador["nombre"].ToString();
                trabajador.Cargo = drTrabajador["cargo"].ToString();
                trabajador.NumNivel = Convert.ToInt32(drTrabajador["numNivel"].ToString());
                trabajador.NomUsuario = drTrabajador["nomUsuario"].ToString();
                trabajador.Contrasena = drTrabajador["contrasena"].ToString();
            }
            cnx.Close();
            return trabajador;
        }
    }
}

using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class NivelCD
    {
        SqlConnection cnx = ConexionCD.ConectarToBD();
        public DataTable Llenaritems()
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "Select * from Nivel WHERE numNivel > 0";
            SqlDataAdapter drNivel = new SqlDataAdapter(cmd);
            DataTable dtNivel = new DataTable();
            drNivel.Fill(dtNivel);
            cnx.Close();
            return dtNivel;
        }
        public int CambiarnivelTrabajador(int nivel, string dni)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "UPDATE Trabajador set numNivel=@nivel where dni=@dni ";
            cmd.Parameters.AddWithValue("@nivel", nivel);
            cmd.Parameters.AddWithValue("@dni", dni);
            int FilasAfectadas = cmd.ExecuteNonQuery();
            cnx.Close();
            return FilasAfectadas;
        }
        public void CambiarSueldo(double sueldo, int nivel)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "UPDATE Nivel set sueldoBasico=@sueldo WHERE numNivel = @nivel";
            cmd.Parameters.AddWithValue("@sueldo", sueldo);
            cmd.Parameters.AddWithValue("@nivel", nivel);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}

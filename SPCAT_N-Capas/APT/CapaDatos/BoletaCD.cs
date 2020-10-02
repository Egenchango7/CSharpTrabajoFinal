using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class BoletaCD
    {
        SqlConnection cnx = ConexionCD.ConectarToBD();
        public DataTable RegistroBoleta(string dni, string annoMes)
        {
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "RegistroBoleta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@dni", dni));
            cmd.Parameters.Add(new SqlParameter("@annoMes", annoMes));
            SqlDataAdapter drPlanilla = new SqlDataAdapter(cmd);
            DataTable dtPlanilla = new DataTable();
            drPlanilla.Fill(dtPlanilla);
            cnx.Close();
            return dtPlanilla;
        }
    }
}

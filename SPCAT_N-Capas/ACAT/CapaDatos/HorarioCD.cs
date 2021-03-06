﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class HorarioCD
    {
        SqlConnection cnx = ConexionCD.ConectarToBD();
        public HorarioCE BuscarByDniAnnoMes(string dni, DateTime annoMes)
        {
            string AnnoMes = annoMes.ToString("yyyy-MM");
            SqlCommand cmd = ConexionCD.CrearCmd(cnx);
            cmd.CommandText = "HorarioByDniAnnoMes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@dni", dni));
            cmd.Parameters.Add(new SqlParameter("@AnnoMes", AnnoMes));
            SqlDataReader drHorario = cmd.ExecuteReader();
            HorarioCE horario = new HorarioCE();
            if (drHorario.Read())
            {
                horario.Codigo = drHorario.GetString(0);
                horario.AnnoMes = drHorario.GetString(1);
                horario.HrEntrada = Convert.ToDateTime(drHorario["hrEntrada"].ToString());
                horario.HrSalida = Convert.ToDateTime(drHorario["hrSalida"].ToString());
            }
            cnx.Close();
            return horario;
        }
    }
}

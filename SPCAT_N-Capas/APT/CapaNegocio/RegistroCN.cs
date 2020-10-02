using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class RegistroCN
    {
        public DataTable ProcesarPlanilla(string annoMes)
        {
            return new RegistroCD().ProcesarPlanilla(annoMes);
        }
        public DataTable CargarMes()
        {
            return new RegistroCD().CargarMes();
        }
        public DataTable RegistrosByDia(DateTime fecha)
        {
            return new RegistroCD().RegistrosByDia(fecha);
        }
        public DateTime PrimerRegistro()
        {
            return new RegistroCD().PrimerRegistro();
        }
        public DataTable Ausentes(DateTime fecha)
        {
            return new RegistroCD().Ausentes(fecha);
        }
        public int RegistrosPrueba()
        {
            return new RegistroCD().RegistrosPrueba();
        }
        public DataTable RangoMeses(string annoMesInicio, string annoMesFin)
        {
            return new RegistroCD().RangoMeses(annoMesInicio, annoMesFin);
        }
        public DataTable CargarAnno()
        {
            return new RegistroCD().CargarAnno();
        }
        public DataTable PlanillaAnual(int anno)
        {
            return new RegistroCD().PlanillaAnual(anno);
        }
    }
}

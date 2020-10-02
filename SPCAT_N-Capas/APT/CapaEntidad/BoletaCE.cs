using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class BoletaCE
    {
        private string codigo;
        private string codMes;
        private DateTime fechaEmision;
        private double sueldoNeto;
        

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string CodMes
        {
            get { return codMes; }
            set { codMes = value; }
        }
        public DateTime FechaEmision
        {
            get { return fechaEmision; }
            set { fechaEmision = value; }
        }
        public double SueldoNeto
        {
            get { return sueldoNeto; }
            set { sueldoNeto = value; }
        }

        public BoletaCE() { }
        public BoletaCE(string codigo, string codMes, DateTime fechaEmision, double sueldoNeto)
        {
            this.codigo = codigo;
            this.codMes = codMes;
            this.fechaEmision = fechaEmision;
            this.sueldoNeto = sueldoNeto;
        }
    }
}

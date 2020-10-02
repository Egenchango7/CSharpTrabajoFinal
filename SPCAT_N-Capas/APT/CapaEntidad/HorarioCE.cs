using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class HorarioCE
    {
        private string codigo;
        private string dniTrabajador;
        private string annoMes;
        private DateTime hrEntrada;
        private DateTime hrSalida;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string DniTrabajador
        {
            get { return dniTrabajador; }
            set { dniTrabajador = value; }
        }
        public string AnnoMes
        {
            get { return annoMes; }
            set { annoMes = value; }
        }
        public DateTime HrEntrada
        {
            get { return hrEntrada; }
            set { hrEntrada = value; }
        }
        public DateTime HrSalida
        {
            get { return hrSalida; }
            set { hrSalida = value; }
        }
        public HorarioCE()
        {

        }

        public HorarioCE(string codigo, string dniTrabajador, string annoMes, DateTime hrEntrada, DateTime hrSalida)
        {
            this.codigo = codigo;
            this.dniTrabajador = dniTrabajador;
            this.annoMes = annoMes;
            this.hrEntrada = hrEntrada;
            this.hrSalida = hrSalida;
        }
    }
}

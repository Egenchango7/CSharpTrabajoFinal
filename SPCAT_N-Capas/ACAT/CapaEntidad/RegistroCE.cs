using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class RegistroCE
    {
        private string codigo;
        private string dniTrabajador;
        private DateTime fechaRegistro;
        private DateTime hrEntradaReg;
        private DateTime hrSalidaReg;
        private bool refrigObtenido;
        private int minutosTardanzas;
        private int minutosAnticipadas;

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
        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }
        public DateTime HrEntradaReg
        {
            get { return hrEntradaReg; }
            set { hrEntradaReg = value; }
        }
        public DateTime HrSalidaReg
        {
            get { return hrSalidaReg; }
            set { hrSalidaReg = value; }
        }
        public bool RefrigObtenido
        {
            get { return refrigObtenido; }
            set { refrigObtenido = value; }
        }
        public int MinutosTardanzas
        {
            get { return minutosTardanzas; }
            set { minutosTardanzas = value; }
        }
        public int MinutosAnticipadas
        {
            get { return minutosAnticipadas; }
            set { minutosAnticipadas = value; }
        }

        public RegistroCE()
        {

        }
        public RegistroCE(string codigo, string dniTrabajador, DateTime fechaRegistro, DateTime hrEntradaReg, DateTime hrSalidaReg, bool refrigObtenido, int minutosTardanzas, int minutosAnticipadas)
        {
            this.codigo = codigo;
            this.dniTrabajador = dniTrabajador;
            this.fechaRegistro = fechaRegistro;
            this.hrEntradaReg = hrEntradaReg;
            this.hrSalidaReg = hrSalidaReg;
            this.refrigObtenido = refrigObtenido;
            this.minutosTardanzas = minutosTardanzas;
            this.minutosAnticipadas = minutosAnticipadas;
        }
    }
}

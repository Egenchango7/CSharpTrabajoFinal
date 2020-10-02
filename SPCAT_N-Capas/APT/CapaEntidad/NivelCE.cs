using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class NivelCE
    {
        private int numNivel;
        private double sueldoBasico;

        public int NumNivel
        {
            get { return numNivel; }
            set { numNivel = value; }
        }
        public double SueldoBasico
        {
            get { return sueldoBasico; }
            set { sueldoBasico = value; }
        }
        public NivelCE()
        {

        }
        public NivelCE(int numNivel, double sueldoBasico)
        {
            this.numNivel = numNivel;
            this.sueldoBasico = sueldoBasico;
        }

    }
}

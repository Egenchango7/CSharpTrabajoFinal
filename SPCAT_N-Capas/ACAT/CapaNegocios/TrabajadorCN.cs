using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class TrabajadorCN
    {
        public TrabajadorCE BuscarByDni(string dni)
        {
            return new TrabajadorCD().BuscarByDni(dni);
        }
    }
}

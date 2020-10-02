using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NivelCN
    {
        public DataTable Llenaritems()
        {
            return new NivelCD().Llenaritems();
        }
        public int CambiarnivelTrabajador(int nivel, string dni)
        {
            return new NivelCD().CambiarnivelTrabajador(nivel, dni);
        }
        public void CambiarSueldo(double sueldo, int nivel)
        {
            new NivelCD().CambiarSueldo(sueldo, nivel);
        }
    }
}

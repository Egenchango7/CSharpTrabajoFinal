using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class RegistroCN
    {
        public string Registrar(TrabajadorCE trabajador, string tipoControl, DateTime horaRegistro)
        {
            return new RegistroCD().Registrar(trabajador, tipoControl, horaRegistro);
        }
    }
}

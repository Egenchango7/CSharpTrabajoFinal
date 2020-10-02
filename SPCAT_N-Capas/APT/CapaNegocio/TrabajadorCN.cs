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
    public class TrabajadorCN
    {
        /*public DataTable BuscarByDni(string dni)
        {
            return new TrabajadorCD().BuscarByDni(dni);
        }*/
        public DataTable Listado()
        {
            return new TrabajadorCD().Listado();
        }

        public DataTable Busqueda(string filtro, string nombre)
        {
            return new TrabajadorCD().Busqueda(filtro, nombre);
        }
        public List<string> Filtros()
        {
            return new TrabajadorCD().Filtros();
        }
        public TrabajadorCE LoginUser(string user, string contra)
        {
            return new TrabajadorCD().Login(user, contra);
        }
    }
}

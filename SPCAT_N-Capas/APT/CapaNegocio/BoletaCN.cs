using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BoletaCN
    {
        public DataTable RegistroBoleta(string dni, string annoMes)
        {
            return new BoletaCD().RegistroBoleta(dni, annoMes);
        }
    }
}

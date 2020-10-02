using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class HorarioCN
    {
        public int CambiarHorario(string dni, DateTime annoMes, string HoraE, string HoraS)
        {
            return new HorarioCD().CambiarHorario(dni, annoMes, HoraE, HoraS);
        }
    }
}

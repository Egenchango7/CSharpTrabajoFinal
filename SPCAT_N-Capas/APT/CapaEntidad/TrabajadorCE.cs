using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class TrabajadorCE
    {
        private string dni;
        private string nombre;
        private string cargo;
        private int numNivel;
        private string nomUsuario;
        private string contrasena;
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public int NumNivel
        {
            get { return numNivel; }
            set { numNivel = value; }
        }
        public string NomUsuario
        {
            get { return nomUsuario; }
            set { nomUsuario = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public TrabajadorCE()
        {

        }
        public TrabajadorCE(string dni, string nombre, string cargo, int numNivel, string nomUsuario, string contrasena)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.cargo = cargo;
            this.numNivel = numNivel;
            this.nomUsuario = nomUsuario;
            this.contrasena = contrasena;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class LoginCP : Form
    {
        public LoginCP()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    TrabajadorCE trabajador = new TrabajadorCN().LoginUser(txtUsuario.Text, txtContraseña.Text);
                    if (trabajador.Dni != null)
                    {
                        AdministrarCP administrarCP = new AdministrarCP();
                        MessageBox.Show("Bienvenido  " + trabajador.Nombre);
                        administrarCP.Show();
                        administrarCP.FormClosed += CerrarSesion;
                        administrarCP.trabajador = trabajador;
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Focus();
                        txtContraseña.Clear();
                    }
                }
                else MessageBox.Show("Ingrese Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Ingrese Usuario y Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Mensaje()
        {
            MessageCP.mensaje.Show();
        }
        private void CerrarSesion(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            this.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsuario.Text != "")
                {
                    if (txtContraseña.Text != "")
                    {
                        TrabajadorCE trabajador = new TrabajadorCN().LoginUser(txtUsuario.Text, txtContraseña.Text);
                        if (trabajador.Dni != null)
                        {
                            AdministrarCP administrarCP = new AdministrarCP();
                            MessageBox.Show("Bienvenido  " + trabajador.Nombre);
                            administrarCP.Show();
                            administrarCP.FormClosed += CerrarSesion;
                            administrarCP.trabajador = trabajador;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsuario.Focus();
                            txtContraseña.Clear();
                        }

                    }
                    else MessageBox.Show("Ingrese Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else MessageBox.Show("Ingrese Usuario y Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

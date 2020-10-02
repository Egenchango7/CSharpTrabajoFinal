using CapaEntidad;
using CapaNegocios;
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

namespace CapaPresentacion
{
    public partial class ControldeAsistenciaCP : Form
    {
        public ControldeAsistenciaCP()
        {
            InitializeComponent();
        }

        private void pickerHora_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
            if (btnEntrada.BackColor == Color.Green)
            {
                Thread.Sleep(300);
                btnEntrada.BackColor = Color.FromArgb(0, 35, 102);
            }
            if (btnSalida.BackColor == Color.Green)
            {
                Thread.Sleep(300);
                btnSalida.BackColor = Color.FromArgb(0, 35, 102);
            }
        }

        private void ControldeAsistenciaCP_Load(object sender, EventArgs e)
        {
            Botones();
            FechaHora();
        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            TrabajadorCE trabajador = new TrabajadorCN().BuscarByDni(txtDni.Text);
            string resultado = new RegistroCN().Registrar(trabajador, "Entrada", Convert.ToDateTime(txtHora.Text));
            MostrarResultado(resultado, "Entrada");
            txtDni.Clear();
        }
        private void MostrarResultado(string resultado, string tipocontrol)
        {
            if (resultado == "DNIincorrecto")
            {
                MessageBox.Show("DNI incorrecto. Intente de nuevo, por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resultado == 0.ToString())
            {
                MessageBox.Show("Hubo un problema en registrar su entrada. Diríjase a la oficina del jefe de Recursos Humanos para registrar su entrada de forma presencial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resultado == "EntradaNoRegistrada")
            {
                MessageBox.Show("Todavía no ha registrado su entrada a la planta. No se puede registrar su salida.", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (resultado == "EntradaRegistrada")
            {
                MessageBox.Show("Ya registró su entrada a la planta. No se puede registrar nuevamente.", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (resultado == 1.ToString())
            {
               
                if (tipocontrol == "Entrada")
                {
                    btnEntrada.BackColor = Color.Green;
                } else if(tipocontrol == "Salida")
                {
                    btnSalida.BackColor = Color.Green;
                }
            }
            else if (resultado== "SalidaRegistrada")
            {
                MessageBox.Show("Ya se registró su salida a la planta. No se puede registrar nuevamente.", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSalida_Click(object sender, EventArgs e)
        {
            TrabajadorCE trabajador = new TrabajadorCN().BuscarByDni(txtDni.Text);
            string resultado = new RegistroCN().Registrar(trabajador, "Salida", Convert.ToDateTime(txtHora.Text));
            MostrarResultado(resultado, "Salida");
            txtDni.Clear();
        }
        public void FechaHora()
        {
            lbFecha.Text = DateTime.Now.ToString("dd / MM / yyyy");
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
            txtHora.ForeColor = Color.FromArgb(0, 35, 102);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void Botones()
        {
            if (DateTime.Now.ToString("dddd") == "domingo")
            {
                btnEntrada.Enabled = false;
                btnSalida.Enabled = false;
            }
            btnEntrada.BackColor = Color.FromArgb(0, 35, 102);
            btnSalida.BackColor = Color.FromArgb(0, 35, 102);
        }
    }
}

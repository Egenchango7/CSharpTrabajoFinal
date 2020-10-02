using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class NivelCP : Form
    {
        public int nivel;
        public NivelCP()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nivel = cmbNivel.SelectedIndex + 1;
            string dni = txtDni.Text;
            if (dni != "")
            {
                new NivelCN().CambiarnivelTrabajador(nivel, dni);
            }
            this.Close();
        }
        private void MostrarItems()
        {
            cmbNivel.DataSource = new NivelCN().Llenaritems();
            cmbNivel.DisplayMember = "numNivel";
            cmbNivel.ValueMember = "sueldoBasico";
            cmbNivel.SelectedIndex = nivel - 1;
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NivelCP_Load(object sender, EventArgs e)
        {
            MostrarItems();
        }

        private void cmbNivel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSueldo.Text = cmbNivel.SelectedValue.ToString();
        }
    }
}

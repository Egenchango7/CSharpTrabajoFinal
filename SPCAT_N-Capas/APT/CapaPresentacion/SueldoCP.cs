using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class SueldoCP : Form
    {
        DataTable dt = new NivelCN().Llenaritems();
        public SueldoCP()
        {
            InitializeComponent();
        }

        private void SueldoCP_Load(object sender, EventArgs e)
        {
            cmbNivel.DataSource = new NivelCN().Llenaritems();
            cmbNivel.DisplayMember = "numNivel";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nivel = cmbNivel.GetItemText(cmbNivel.SelectedItem);
            new NivelCN().CambiarSueldo(Convert.ToDouble(txtSueldo.Text),Convert.ToInt32(nivel));
            txtSueldo.Clear();
            cmbNivel.SelectedIndex = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].ItemArray[0].ToString() == nivel)
                {
                    dt.Rows.RemoveAt(i);
  
                }
                
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Terminó de asignar los sueldos respectivos a cada nivel.");
                this.Close();
            }
            else
            {
                cmbNivel.DataSource = dt;
            }
        }
    }
}

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
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class BoletaCP : Form
    {
        public int indiceMes;
        public string annoMes;
        public string dni;
        public DataTable dt;
        public BoletaCP()
        {
            InitializeComponent();
        }

        private void BoletaCP_Load(object sender, EventArgs e)
        {
            LlenarCmbs();
            lblFecha.Text = DateTime.Today.ToString("yyyy/MM/dd");
            LlenarTxt();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ColoresCE.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ColoresCE.SecondaryColor;
                }
            }
            label1.ForeColor = ColoresCE.PrimaryColor;
            label2.ForeColor = ColoresCE.SecondaryColor;
            label3.ForeColor = ColoresCE.SecondaryColor;
            label4.ForeColor = ColoresCE.SecondaryColor;
            lblFecha.ForeColor = ColoresCE.PrimaryColor;

            label8.ForeColor = ColoresCE.SecondaryColor;
            label9.ForeColor = ColoresCE.SecondaryColor;

            label11.ForeColor = ColoresCE.PrimaryColor;
            label12.ForeColor = ColoresCE.SecondaryColor;
            label13.ForeColor = ColoresCE.PrimaryColor;
            label14.ForeColor = ColoresCE.SecondaryColor;
            label15.ForeColor = ColoresCE.SecondaryColor;
            label16.ForeColor = ColoresCE.SecondaryColor;
            label17.ForeColor = ColoresCE.SecondaryColor;



        }
        private void LlenarCmbs()
        {
            cmbMes.DataSource = new RegistroCN().CargarMes();
            cmbMes.DisplayMember = "Nombre";
            cmbMes.ValueMember = "Numero";
            cmbMes.SelectedIndex = indiceMes;
            int indiceDni = -1;
            DataTable dtDni = dt;
            for (int i = 0; i < dtDni.Rows.Count; i++)
            {
                if (dni == dtDni.Rows[i].ItemArray[0].ToString())
                {
                    indiceDni = i;
                }
            }
            cmbDni.DataSource = dtDni;
            cmbDni.DisplayMember = "DNI";
            cmbDni.ValueMember = "NOMBRE";
            cmbDni.SelectedIndex = indiceDni;
        }

        private void cmbDni_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarTxt();
        }
        private void LlenarTxt()
        {
            txtNom.Text = cmbDni.SelectedValue.ToString();
            dni = cmbDni.GetItemText(cmbDni.SelectedItem);
            DataTable dtBoleta = new BoletaCN().RegistroBoleta(dni, annoMes);
            txtEntrada.Text = Convert.ToDateTime(dtBoleta.Rows[0].ItemArray[2].ToString()).ToString("HH:mm");
            txtSalida.Text = Convert.ToDateTime(dtBoleta.Rows[0].ItemArray[3].ToString()).ToString("HH:mm");
            txtTard.Text = dtBoleta.Rows[0].ItemArray[4].ToString();
            txtAntic.Text = dtBoleta.Rows[0].ItemArray[5].ToString();
            double sueldoB = Convert.ToDouble(dtBoleta.Rows[0].ItemArray[6].ToString());
            txtSueldoB.Text = sueldoB.ToString();
            double refrig = Convert.ToDouble(dtBoleta.Rows[0].ItemArray[7].ToString());
            txtRefrig.Text = refrig.ToString();
            double desc = Convert.ToDouble(dtBoleta.Rows[0].ItemArray[8].ToString());
            txtDesc.Text = desc.ToString();
            txtPagoHora.Text = Math.Round((sueldoB / 30 / 8), 2).ToString();
            txtSueldoN.Text = (sueldoB + refrig - desc).ToString();
        }

        private void cmbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            annoMes = cmbMes.SelectedValue.ToString();
            cmbDni.DataSource = new RegistroCN().ProcesarPlanilla(cmbMes.SelectedValue.ToString());
            ResetControl();
        }
        private void ResetControl()
        {
            cmbDni.SelectedIndex = -1;
            txtNom.Clear();
            txtEntrada.Clear();
            txtSalida.Clear();
            txtTard.Clear();
            txtAntic.Clear();
            txtSueldoB.Clear();
            txtRefrig.Clear();
            txtPagoHora.Clear();
            txtSueldoN.Clear();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

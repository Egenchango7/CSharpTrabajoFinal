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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class PlanillaCP : Form
    {
        public PlanillaCP()
        {
            InitializeComponent();
        }

        private void PlanillaCP_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LlenarCmbs();
            dgvMes.DataSource = new RegistroCN().ProcesarPlanilla(cmbMes.SelectedValue.ToString());
            dgvMes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            lblPlanilla.ForeColor = ColoresCE.PrimaryColor;
            lblHasta.ForeColor = ColoresCE.PrimaryColor;
            chkRango.ForeColor = ColoresCE.SecondaryColor;


        }

        private void LlenarCmbs()
        {
            cmbMes.DataSource = new RegistroCN().CargarMes();
            cmbMes.DisplayMember = "Nombre";
            cmbMes.ValueMember = "Numero";
            cmbMes.SelectedIndex = cmbMes.Items.Count - 1;
            cmbHasta.DisplayMember = "Nombre";
            cmbHasta.ValueMember = "Numero";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string annoMesInicio = cmbMes.SelectedValue.ToString();
            string annoMesFin = cmbHasta.SelectedValue.ToString();
            dgvMes.DataSource = new RegistroCN().RangoMeses(annoMesInicio, annoMesFin);
        }

        private void cmbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!chkRango.Checked)
            {
                dgvMes.DataSource = new RegistroCN().ProcesarPlanilla(cmbMes.SelectedValue.ToString());
            }
            DataTable dtMes = new RegistroCN().CargarMes();
            cmbHasta.DataSource = dtMes;
            int indice = cmbMes.SelectedIndex;
            for (int i = 0; i <= indice; i++)
            {
                dtMes.Rows.RemoveAt(0);
            }
            cmbHasta.DataSource = dtMes;
            cmbHasta.SelectedIndex = cmbHasta.Items.Count - 1;
        }

        private void chkRango_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRango.Checked)
            {
                lblPlanilla.Text = "Planilla de los Meses de";
                lblHasta.Visible = true;
                cmbHasta.Visible = true;
                DataTable dtMes1 = new RegistroCN().CargarMes();
                dtMes1.Rows.RemoveAt(dtMes1.Rows.Count - 1);
                cmbMes.DataSource = dtMes1;
                cmbMes.SelectedIndex = 0;
                DataTable dtMes2 = new RegistroCN().CargarMes();
                dtMes2.Rows.RemoveAt(0);
                cmbHasta.DataSource = dtMes2;
                btnBuscar.Visible = true;
                dgvMes.DataSource = null;
            }
            else
            {
                lblPlanilla.Text = "Planilla del Mes de";
                lblHasta.Visible = false;
                cmbHasta.Visible = false;
                LlenarCmbs();
                btnBuscar.Visible = false;
                dgvMes.DataSource = null;
                dgvMes.DataSource = new RegistroCN().ProcesarPlanilla(cmbMes.SelectedValue.ToString());
            }
        }

        private void btnBoleta_Click(object sender, EventArgs e)
        {
            if (dgvMes.SelectedRows.Count > 0)
            {
                BoletaCP frmBoleta = new BoletaCP();
                frmBoleta.annoMes = cmbMes.SelectedValue.ToString();
                frmBoleta.indiceMes = cmbMes.SelectedIndex;
                frmBoleta.dni = dgvMes.SelectedRows[0].Cells["DNI"].Value.ToString();
                frmBoleta.dt = new RegistroCN().ProcesarPlanilla(cmbMes.SelectedValue.ToString());
                frmBoleta.TopLevel = false;
                frmBoleta.FormBorderStyle = FormBorderStyle.None;
                frmBoleta.Dock = DockStyle.Fill;
                AdministrarCP.activeForm.Close();
                AdministrarCP.activeForm = frmBoleta;
                AdministrarCP.ActiveForm.Activate();
                AdministrarCP.ActiveForm.Controls["pnlFormulario"].Controls.Add(frmBoleta);
                AdministrarCP.ActiveForm.Controls["pnlFormulario"].Tag = frmBoleta;
                frmBoleta.BringToFront();
                frmBoleta.Show();
                //AdministrarCP.ActiveForm.Controls["lblTitulo"].Text = "Boletas de Pago";
            }
            else
            {
                MessageBox.Show("Para visualizar la boleta de un trabajador, antes seleccione la fila correspondiente en la tabla");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvMes);
        }
        //Exporta Datagridview a Archivo de Excel
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Planilla Mensual";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    hoja_trabajo.Name = "Planilla Mensual";

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < grd.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            if ((grd.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Registros exportados a Excel", "APT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
    }
}

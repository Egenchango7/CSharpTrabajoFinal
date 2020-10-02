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
    public partial class RegistroCP : Form
    {
        public RegistroCP()
        {
            InitializeComponent();
        }

        private void RegistroCP_Load(object sender, EventArgs e)
        {
            dgvRegistro.DataSource = new RegistroCN().RegistrosByDia(DateTime.Now);
            dgvRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtpFecha.MaxDate = DateTime.Now;
            dtpFecha.MinDate = new RegistroCN().PrimerRegistro();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
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
            
            label2.ForeColor = ColoresCE.PrimaryColor;
            label3.ForeColor = ColoresCE.SecondaryColor;
            label4.ForeColor = ColoresCE.PrimaryColor;
            label5.ForeColor = ColoresCE.SecondaryColor;

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dgvRegistro.DataSource = new RegistroCN().RegistrosByDia(dtpFecha.Value);
            ResetTxt();
        }

        private void dgvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            if (btnAusentes.BackColor != Color.Red)
            {
                lblTardanza.Visible = false;
                lblAnticipada.Visible = false;
                var row = dgvRegistro.SelectedRows;
                if (row.Count > 0)
                {
                    txtDni.Text = row[0].Cells["DNI"].Value.ToString();
                    txtNom.Text = row[0].Cells["NOMBRE"].Value.ToString();
                    txtEntrada.Text = row[0].Cells["ENTRADA"].Value.ToString();
                    if (row[0].Cells["TARDANZA"].Value.ToString() == "SÍ")
                    {
                        lblTardanza.Visible = true;
                    }
                    txtSalida.Text = row[0].Cells["SALIDA"].Value.ToString();
                    if (row[0].Cells["SALIDA ANTICIPADA"].Value.ToString() == "SÍ")
                    {
                        lblAnticipada.Visible = true;
                    }
                }
            }
        }

        private void btnAusentes_Click(object sender, EventArgs e)
        {
            ResetTxt();
            if (btnAusentes.BackColor != Color.Red)
            {
                btnAusentes.BackColor = Color.Red;
                dgvRegistro.DataSource = new RegistroCN().Ausentes(dtpFecha.Value);
                
            }
            else
            {
                dgvRegistro.DataSource = new RegistroCN().RegistrosByDia(dtpFecha.Value);
                LoadTheme();
            }
        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            if (dtpFecha.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                lblHora.Text = "";
            }
            if (dgvRegistro.SelectedRows.Count == 0 && dtpFecha.Value.ToString("yyyy-mm-dd") == DateTime.Now.ToString("yyyy-mm-dd"))
            {
                if (btnAusentes.BackColor == Color.Red)
                {
                    dgvRegistro.DataSource = new RegistroCN().Ausentes(dtpFecha.Value);
                }
                else
                {
                    dgvRegistro.DataSource = new RegistroCN().RegistrosByDia(dtpFecha.Value);
                }
            }
        }

        private void ResetTxt()
        {
            txtDni.Clear();
            txtNom.Clear();
            txtEntrada.Clear();
            txtSalida.Clear();
            lblAnticipada.Visible = false;
            lblTardanza.Visible = false;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvRegistro);
        }
        //Exporta Datagridview a Archivo de Excel
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Registros Diarios";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    hoja_trabajo.Name = "Registros Diarios";

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

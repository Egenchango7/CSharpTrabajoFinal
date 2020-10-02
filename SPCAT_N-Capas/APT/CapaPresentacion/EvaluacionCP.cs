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
    public partial class EvaluacionCP : Form
    {
        string Dni;
        string Nombre;
        int Nivel;
        string sueldo;
        public EvaluacionCP()
        {
            InitializeComponent();
        }

        private void EvaluacionCP_Load(object sender, EventArgs e)
        {
            LlenarCmbAnno();
            dgvAño.DataSource = new RegistroCN().PlanillaAnual(Convert.ToInt32(cmbAnno.GetItemText(cmbAnno.SelectedItem)));
            dgvAño.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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



        }

        public void LlenarCmbAnno()
        {
            cmbAnno.DataSource = new RegistroCN().CargarAnno();
            cmbAnno.DisplayMember = "Anno";
            cmbAnno.SelectedIndex = cmbAnno.Items.Count - 1;
        }

        private void btnAsignarNivel_Click(object sender, EventArgs e)
        {
            if (dgvAño.SelectedRows.Count > 0)
            {
                NivelCP Trabajador = new NivelCP();
                Trabajador.txtDni.Text = Dni;
                Trabajador.txtNom.Text = Nombre;
                Trabajador.nivel = Nivel;
                Trabajador.txtSueldo.Text = sueldo;
                Trabajador.ShowDialog();
                dgvAño.DataSource = new RegistroCN().PlanillaAnual(Convert.ToInt32(cmbAnno.GetItemText(cmbAnno.SelectedItem)));
            }
            else
            {
                MessageBox.Show("Para asignarle el nivel a un trabajador, primero seleccione la fila correspondiente en la tabla.");
            }
        }

        private void dgvAño_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAño.SelectedRows.Count >= 1)
            {
                DataGridViewRow fila = dgvAño.SelectedRows[0];
                Dni = fila.Cells["DNI"].Value.ToString();
                Nombre = fila.Cells["NOMBRE"].Value.ToString();
                Nivel = Convert.ToInt32(fila.Cells["NIVEL"].Value.ToString());
                sueldo = fila.Cells["SUELDO"].Value.ToString();
            }
        }

        private void btnAsignarSueldo_Click(object sender, EventArgs e)
        {
            new SueldoCP().ShowDialog();
            dgvAño.DataSource = new RegistroCN().PlanillaAnual(Convert.ToInt32(cmbAnno.GetItemText(cmbAnno.SelectedItem)));
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvAño);
        }
        //Exporta Datagridview a Archivo de Excel
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Planilla Anual";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    hoja_trabajo.Name = "Planilla Anual";

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

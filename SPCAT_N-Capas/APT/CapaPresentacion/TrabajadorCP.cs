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
    public partial class TrabajadorCP : Form
    {
        public TrabajadorCP()
        {
            InitializeComponent();
        }

        private void TrabajadorCP_Load(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = new TrabajadorCN().Listado();
            cmbFiltro.DataSource = new TrabajadorCN().Filtros();
            cmbFiltro.SelectedIndex = -1;
            btnBuscar.Visible = false;
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
            label1.ForeColor = ColoresCE.SecondaryColor;
            label2.ForeColor = ColoresCE.PrimaryColor;
            label3.ForeColor = ColoresCE.SecondaryColor;
            label4.ForeColor = ColoresCE.PrimaryColor;
            label5.ForeColor = ColoresCE.SecondaryColor;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string HoraE = dtpEntrada.Value.ToString("HH:mm");
            string HoraS = dtpSalida.Value.ToString("HH:mm");
            if (dni != "")
            {
                int resultado = new HorarioCN().CambiarHorario(dni, DateTime.Now, HoraE, HoraS);
                if (resultado == 1)
                {
                    string nombre = txtNom.Text;
                    MessageBox.Show("Se cambió el horario de " + nombre + " para el próximo mes");
                }
                else if (resultado == 0)
                {
                    string nombre = txtNom.Text;
                    MessageBox.Show("El horario de " + nombre + " para el próximo mes ya está establecido");
                }
                ResetControl();
            }
            else
            {
                MessageBox.Show("Para cambiar el horario de un trabajador, antes seleccione la fila correspondiente en la tabla");
            }
            dgvMostrar.DataSource = new TrabajadorCN().Listado();
        }

        private void ResetControl()
        {
            txtDni.Clear();
            txtNom.Clear();
            txtNivel.Clear();
            txtBuscar.Clear();
            txtSueldo.Clear();
            btnActualizar.Visible = false;
            txtDni.Focus();
        }

        private void dgvMostrar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMostrar.SelectedRows.Count >= 1)
            {
                DataGridViewRow fila = dgvMostrar.SelectedRows[0];
                txtDni.Text = fila.Cells["DNI"].Value.ToString();
                txtNom.Text = fila.Cells["NOMBRE"].Value.ToString();
                dtpEntrada.Value = Convert.ToDateTime(fila.Cells["ENTRADA"].Value.ToString());
                dtpSalida.Value = Convert.ToDateTime(fila.Cells["SALIDA"].Value.ToString());
                txtNivel.Text= (fila.Cells["NIVEL"].Value.ToString()).ToString();
                txtSueldo.Text = fila.Cells["SUELDO"].Value.ToString();
                btnActualizar.Visible = true;
            }
        }


        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == -1)
            {
                txtBuscar.Enabled = false;
            }
            else
            {
                if (cmbFiltro.SelectedIndex == 2)
                {
                    dtpHoraBuscar.Visible = true;
                    txtBuscar.Visible = false;
                    dtpHoraBuscar.Value = Convert.ToDateTime("08:00");
                    btnBuscar.Visible = true;
                }
                else if (cmbFiltro.SelectedIndex == 3)
                {
                    dtpHoraBuscar.Visible = true;
                    txtBuscar.Visible = false;
                    dtpHoraBuscar.Value = Convert.ToDateTime("16:00");
                    btnBuscar.Visible = true;
                }
                else
                {
                    txtBuscar.Visible = true;
                    txtBuscar.Text = "";
                    dtpHoraBuscar.Visible = false;
                    btnBuscar.Visible = false;
                    txtBuscar.Enabled = true;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = new TrabajadorCN().Busqueda(cmbFiltro.SelectedItem.ToString(), txtBuscar.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = new TrabajadorCN().Busqueda(cmbFiltro.SelectedItem.ToString(), dtpHoraBuscar.Value.ToString("HH:mm"));
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvMostrar);
        }
        
        //Exporta Datagridview a Archivo de Excel
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Trabajador";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    hoja_trabajo.Name = "Trabajadores";

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
                    MessageBox.Show("Registros exportado a Excel", "APT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
    }
}


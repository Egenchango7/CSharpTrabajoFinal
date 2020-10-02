using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//Importar Capas
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class AdministrarCP : Form
    {
        public TrabajadorCE trabajador;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public static Form activeForm;
        public AdministrarCP()
        {
            InitializeComponent();
            random = new Random();
            btnCerrarForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void AdministrarCP_Load(object sender, EventArgs e)
        {
            new RegistroCN().RegistrosPrueba();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de salir?", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        //*****************************************DISEÑO************************************************************

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private Color SelectThemeColor()
        {
            int index = random.Next(ColoresCE.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ColoresCE.ColorList.Count);
            }
            tempIndex = index;
            string color = ColoresCE.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitulo.BackColor = color;
                    pnlLogo.BackColor = ColoresCE.ChangeColorBrightness(color, -0.3);
                    ColoresCE.PrimaryColor = color;
                    ColoresCE.SecondaryColor = ColoresCE.ChangeColorBrightness(color, -0.3);
                    btnCerrarForm.Visible = true;
                    pctCasa.Visible = false;
                }
            }
        }



        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlFormulario.Controls.Add(childForm);
            this.pnlFormulario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitulo.Text = "HOME";
            pctCasa.Visible=true;
            pnlTitulo.BackColor = Color.FromArgb(0, 150, 136);
            pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCerrarForm.Visible = false;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TrabajadorCP(), sender);
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PlanillaCP(), sender);
        }

        private void btnHoraio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegistroCP(), sender);
        }

        private void pnlFormulario_Paint(object sender, PaintEventArgs e)
        {
            CargarUsuario();
        }

        private void CargarUsuario()
        {
            lblCargo.Text = trabajador.Cargo;
            lblUsuario.Text = trabajador.Nombre;


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

        private void pctCasa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEvaluaciones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EvaluacionCP(), sender);
        }
    }
}

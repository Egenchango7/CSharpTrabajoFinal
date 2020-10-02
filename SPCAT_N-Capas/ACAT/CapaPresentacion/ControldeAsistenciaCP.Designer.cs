namespace CapaPresentacion
{
    partial class ControldeAsistenciaCP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnSalida = new System.Windows.Forms.Button();
            this.pickerHora = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.White;
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDni.Location = new System.Drawing.Point(230, 371);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(240, 37);
            this.txtDni.TabIndex = 0;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.White;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(30, 437);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(312, 66);
            this.btnEntrada.TabIndex = 1;
            this.btnEntrada.Text = "Registrar Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.White;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHora.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.Color.White;
            this.txtHora.Location = new System.Drawing.Point(150, 233);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(400, 79);
            this.txtHora.TabIndex = 2;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.White;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.White;
            this.btnSalida.Location = new System.Drawing.Point(358, 437);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(312, 66);
            this.btnSalida.TabIndex = 3;
            this.btnSalida.Text = "Registrar Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // pickerHora
            // 
            this.pickerHora.Enabled = true;
            this.pickerHora.Interval = 1000;
            this.pickerHora.Tick += new System.EventHandler(this.pickerHora_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(250, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "DIGITE SU DNI";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(279, 200);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(163, 30);
            this.lbFecha.TabIndex = 8;
            this.lbFecha.Text = "dd/MM/yyyy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 40);
            this.panel2.TabIndex = 9;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(660, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 58);
            this.label2.TabIndex = 11;
            this.label2.Text = "ACAT";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CapaPresentacion.Properties.Resources.RELOJ;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(318, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 61);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // ControldeAsistenciaCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.txtDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControldeAsistenciaCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ControldeAsistenciaCP_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Timer pickerHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
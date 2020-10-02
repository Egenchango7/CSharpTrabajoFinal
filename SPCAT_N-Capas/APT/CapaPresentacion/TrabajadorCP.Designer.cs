namespace CapaPresentacion
{
    partial class TrabajadorCP
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpHoraBuscar = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtNivel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(511, 174);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 30);
            this.btnBuscar.TabIndex = 66;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpHoraBuscar
            // 
            this.dtpHoraBuscar.CustomFormat = "HH:mm";
            this.dtpHoraBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraBuscar.Location = new System.Drawing.Point(399, 178);
            this.dtpHoraBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHoraBuscar.Name = "dtpHoraBuscar";
            this.dtpHoraBuscar.ShowUpDown = true;
            this.dtpHoraBuscar.Size = new System.Drawing.Size(81, 22);
            this.dtpHoraBuscar.TabIndex = 65;
            this.dtpHoraBuscar.Value = new System.DateTime(2020, 8, 7, 8, 0, 0, 0);
            // 
            // dtpSalida
            // 
            this.dtpSalida.CustomFormat = "HH:mm";
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalida.Location = new System.Drawing.Point(557, 93);
            this.dtpSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.ShowUpDown = true;
            this.dtpSalida.Size = new System.Drawing.Size(81, 22);
            this.dtpSalida.TabIndex = 64;
            this.dtpSalida.Value = new System.DateTime(2020, 8, 7, 16, 0, 0, 0);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.CustomFormat = "hh:mm";
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrada.Location = new System.Drawing.Point(557, 61);
            this.dtpEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.ShowUpDown = true;
            this.dtpEntrada.Size = new System.Drawing.Size(81, 22);
            this.dtpEntrada.TabIndex = 63;
            this.dtpEntrada.Value = new System.DateTime(2020, 8, 7, 8, 0, 0, 0);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(133, 177);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(160, 24);
            this.cmbFiltro.TabIndex = 62;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Buscar por";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Entrada";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(399, 113);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(81, 22);
            this.txtSueldo.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 57;
            this.label5.Text = "Sueldo";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(780, 26);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(160, 54);
            this.btnActualizar.TabIndex = 56;
            this.btnActualizar.Text = "Cambiar Horario";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(52, 59);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(236, 22);
            this.txtDni.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nivel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Horario";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(52, 113);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(236, 22);
            this.txtNom.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nombre";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(399, 177);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(307, 22);
            this.txtBuscar.TabIndex = 48;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(52, 224);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.Size = new System.Drawing.Size(888, 436);
            this.dgvMostrar.TabIndex = 47;
            this.dgvMostrar.SelectionChanged += new System.EventHandler(this.dgvMostrar_SelectionChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(780, 159);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(160, 47);
            this.btnExportar.TabIndex = 67;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(399, 60);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(81, 22);
            this.txtNivel.TabIndex = 68;
            // 
            // TrabajadorCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 703);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpHoraBuscar);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvMostrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrabajadorCP";
            this.Text = "Trabajador";
            this.Load += new System.EventHandler(this.TrabajadorCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpHoraBuscar;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtNivel;
    }
}
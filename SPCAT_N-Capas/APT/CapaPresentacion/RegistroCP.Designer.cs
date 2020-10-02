namespace CapaPresentacion
{
    partial class RegistroCP
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
            this.lblHora = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAusentes = new System.Windows.Forms.Button();
            this.lblAnticipada = new System.Windows.Forms.Label();
            this.lblTardanza = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.tmHora = new System.Windows.Forms.Timer(this.components);
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(38, 105);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(78, 25);
            this.lblHora.TabIndex = 42;
            this.lblHora.Text = "HH:mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "FECHA";
            // 
            // btnAusentes
            // 
            this.btnAusentes.BackColor = System.Drawing.SystemColors.Control;
            this.btnAusentes.Location = new System.Drawing.Point(835, 112);
            this.btnAusentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAusentes.Name = "btnAusentes";
            this.btnAusentes.Size = new System.Drawing.Size(121, 68);
            this.btnAusentes.TabIndex = 40;
            this.btnAusentes.Text = "Mostrar trabajadores ausentes";
            this.btnAusentes.UseVisualStyleBackColor = false;
            this.btnAusentes.Click += new System.EventHandler(this.btnAusentes_Click);
            // 
            // lblAnticipada
            // 
            this.lblAnticipada.AutoSize = true;
            this.lblAnticipada.ForeColor = System.Drawing.Color.Red;
            this.lblAnticipada.Location = new System.Drawing.Point(638, 115);
            this.lblAnticipada.Name = "lblAnticipada";
            this.lblAnticipada.Size = new System.Drawing.Size(117, 17);
            this.lblAnticipada.TabIndex = 39;
            this.lblAnticipada.Text = "Salida Anticipada";
            this.lblAnticipada.Visible = false;
            // 
            // lblTardanza
            // 
            this.lblTardanza.AutoSize = true;
            this.lblTardanza.ForeColor = System.Drawing.Color.Red;
            this.lblTardanza.Location = new System.Drawing.Point(638, 62);
            this.lblTardanza.Name = "lblTardanza";
            this.lblTardanza.Size = new System.Drawing.Size(69, 17);
            this.lblTardanza.TabIndex = 38;
            this.lblTardanza.Text = "Tardanza";
            this.lblTardanza.Visible = false;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(553, 58);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ReadOnly = true;
            this.txtEntrada.Size = new System.Drawing.Size(79, 22);
            this.txtEntrada.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Entrada";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(551, 112);
            this.txtSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.Size = new System.Drawing.Size(79, 22);
            this.txtSalida.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(549, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Salida";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(255, 58);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(257, 22);
            this.txtDni.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "DNI";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(255, 112);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(257, 22);
            this.txtNom.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(43, 57);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(168, 30);
            this.dtpFecha.TabIndex = 29;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(43, 186);
            this.dgvRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.RowHeadersWidth = 51;
            this.dgvRegistro.RowTemplate.Height = 24;
            this.dgvRegistro.Size = new System.Drawing.Size(913, 438);
            this.dgvRegistro.TabIndex = 28;
            this.dgvRegistro.SelectionChanged += new System.EventHandler(this.dgvRegistro_SelectionChanged);
            // 
            // tmHora
            // 
            this.tmHora.Enabled = true;
            this.tmHora.Interval = 1000;
            this.tmHora.Tick += new System.EventHandler(this.tmHora_Tick);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(826, 630);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(130, 45);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.Text = "Exportar Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // RegistroCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 703);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAusentes);
            this.Controls.Add(this.lblAnticipada);
            this.Controls.Add(this.lblTardanza);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvRegistro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroCP";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RegistroCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAusentes;
        private System.Windows.Forms.Label lblAnticipada;
        private System.Windows.Forms.Label lblTardanza;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Timer tmHora;
        private System.Windows.Forms.Button btnExcel;
    }
}
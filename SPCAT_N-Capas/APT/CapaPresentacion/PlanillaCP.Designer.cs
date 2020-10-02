namespace CapaPresentacion
{
    partial class PlanillaCP
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
            this.lblHasta = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.chkRango = new System.Windows.Forms.CheckBox();
            this.btnBoleta = new System.Windows.Forms.Button();
            this.lblPlanilla = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMes = new System.Windows.Forms.DataGridView();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(432, 63);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(85, 32);
            this.lblHasta.TabIndex = 15;
            this.lblHasta.Text = "hasta";
            this.lblHasta.Visible = false;
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(371, 100);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(237, 39);
            this.cmbHasta.TabIndex = 14;
            this.cmbHasta.Visible = false;
            // 
            // chkRango
            // 
            this.chkRango.AutoSize = true;
            this.chkRango.Location = new System.Drawing.Point(627, 30);
            this.chkRango.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRango.Name = "chkRango";
            this.chkRango.Size = new System.Drawing.Size(137, 21);
            this.chkRango.TabIndex = 13;
            this.chkRango.Text = "Rango de meses";
            this.chkRango.UseVisualStyleBackColor = true;
            this.chkRango.CheckedChanged += new System.EventHandler(this.chkRango_CheckedChanged);
            // 
            // btnBoleta
            // 
            this.btnBoleta.Location = new System.Drawing.Point(838, 105);
            this.btnBoleta.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoleta.Name = "btnBoleta";
            this.btnBoleta.Size = new System.Drawing.Size(119, 62);
            this.btnBoleta.TabIndex = 12;
            this.btnBoleta.Text = "Mostrar Boleta de pago";
            this.btnBoleta.UseVisualStyleBackColor = true;
            this.btnBoleta.Click += new System.EventHandler(this.btnBoleta_Click);
            // 
            // lblPlanilla
            // 
            this.lblPlanilla.AutoSize = true;
            this.lblPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanilla.Location = new System.Drawing.Point(35, 26);
            this.lblPlanilla.Name = "lblPlanilla";
            this.lblPlanilla.Size = new System.Drawing.Size(262, 32);
            this.lblPlanilla.TabIndex = 11;
            this.lblPlanilla.Text = "Planilla del Mes de ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(838, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 39);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvMes
            // 
            this.dgvMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMes.Location = new System.Drawing.Point(41, 175);
            this.dgvMes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMes.Name = "dgvMes";
            this.dgvMes.ReadOnly = true;
            this.dgvMes.RowHeadersWidth = 51;
            this.dgvMes.Size = new System.Drawing.Size(916, 449);
            this.dgvMes.TabIndex = 9;
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(371, 20);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(237, 39);
            this.cmbMes.TabIndex = 8;
            this.cmbMes.SelectionChangeCommitted += new System.EventHandler(this.cmbMes_SelectionChangeCommitted);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(827, 632);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(130, 45);
            this.btnExcel.TabIndex = 16;
            this.btnExcel.Text = "Exportar Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // PlanillaCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 703);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.chkRango);
            this.Controls.Add(this.btnBoleta);
            this.Controls.Add(this.lblPlanilla);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvMes);
            this.Controls.Add(this.cmbMes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlanillaCP";
            this.Text = "Planilla Mensual";
            this.Load += new System.EventHandler(this.PlanillaCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.CheckBox chkRango;
        private System.Windows.Forms.Button btnBoleta;
        private System.Windows.Forms.Label lblPlanilla;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Button btnExcel;
    }
}
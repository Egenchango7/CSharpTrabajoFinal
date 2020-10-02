namespace CapaPresentacion
{
    partial class EvaluacionCP
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
            this.btnAsignarNivel = new System.Windows.Forms.Button();
            this.dgvAño = new System.Windows.Forms.DataGridView();
            this.cmbAnno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignarSueldo = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAño)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignarNivel
            // 
            this.btnAsignarNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarNivel.Location = new System.Drawing.Point(810, 90);
            this.btnAsignarNivel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignarNivel.Name = "btnAsignarNivel";
            this.btnAsignarNivel.Size = new System.Drawing.Size(143, 55);
            this.btnAsignarNivel.TabIndex = 5;
            this.btnAsignarNivel.Text = "Cambiar nivel a trabajador";
            this.btnAsignarNivel.UseVisualStyleBackColor = true;
            this.btnAsignarNivel.Click += new System.EventHandler(this.btnAsignarNivel_Click);
            // 
            // dgvAño
            // 
            this.dgvAño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAño.Location = new System.Drawing.Point(45, 153);
            this.dgvAño.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAño.Name = "dgvAño";
            this.dgvAño.ReadOnly = true;
            this.dgvAño.RowHeadersWidth = 51;
            this.dgvAño.Size = new System.Drawing.Size(908, 464);
            this.dgvAño.TabIndex = 4;
            this.dgvAño.SelectionChanged += new System.EventHandler(this.dgvAño_SelectionChanged);
            // 
            // cmbAnno
            // 
            this.cmbAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnno.FormattingEnabled = true;
            this.cmbAnno.Location = new System.Drawing.Point(122, 27);
            this.cmbAnno.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnno.Name = "cmbAnno";
            this.cmbAnno.Size = new System.Drawing.Size(137, 39);
            this.cmbAnno.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "AÑO";
            // 
            // btnAsignarSueldo
            // 
            this.btnAsignarSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarSueldo.Location = new System.Drawing.Point(659, 90);
            this.btnAsignarSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignarSueldo.Name = "btnAsignarSueldo";
            this.btnAsignarSueldo.Size = new System.Drawing.Size(143, 55);
            this.btnAsignarSueldo.TabIndex = 12;
            this.btnAsignarSueldo.Text = "Asignar sueldo a nivel";
            this.btnAsignarSueldo.UseVisualStyleBackColor = true;
            this.btnAsignarSueldo.Click += new System.EventHandler(this.btnAsignarSueldo_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(823, 625);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(130, 45);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "Exportar Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // EvaluacionCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 703);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnAsignarSueldo);
            this.Controls.Add(this.cmbAnno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsignarNivel);
            this.Controls.Add(this.dgvAño);
            this.Name = "EvaluacionCP";
            this.Text = "Evaluación Anual";
            this.Load += new System.EventHandler(this.EvaluacionCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarNivel;
        public System.Windows.Forms.DataGridView dgvAño;
        private System.Windows.Forms.ComboBox cmbAnno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignarSueldo;
        private System.Windows.Forms.Button btnExcel;
    }
}
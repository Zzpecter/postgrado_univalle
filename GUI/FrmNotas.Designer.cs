namespace GUI
{
    partial class FrmNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMaterias = new GUI.dgvBase();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblPostgrado = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.pdImpresion = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNota)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMaterias);
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AllowUserToResizeColumns = false;
            this.dgvMaterias.AllowUserToResizeRows = false;
            this.dgvMaterias.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMaterias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMaterias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(6, 22);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(350, 195);
            this.dgvMaterias.TabIndex = 0;
            this.dgvMaterias.SelectionChanged += new System.EventHandler(this.dgvMaterias_SelectionChanged);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(12, 9);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(78, 16);
            this.lblAlumno.TabIndex = 1;
            this.lblAlumno.Text = "Alumno:";
            // 
            // lblPostgrado
            // 
            this.lblPostgrado.AutoSize = true;
            this.lblPostgrado.Location = new System.Drawing.Point(12, 38);
            this.lblPostgrado.Name = "lblPostgrado";
            this.lblPostgrado.Size = new System.Drawing.Size(108, 16);
            this.lblPostgrado.TabIndex = 2;
            this.lblPostgrado.Text = "Postgrado:";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(101, 29);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(72, 23);
            this.tbNota.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bVolver);
            this.groupBox2.Controls.Add(this.bGuardar);
            this.groupBox2.Controls.Add(this.tbNota);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(380, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 233);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(51, 167);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 48;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(51, 101);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 47;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // pdImpresion
            // 
            this.pdImpresion.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdImpresion_PrintPage);
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 294);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPostgrado);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNotas_FormClosing);
            this.Load += new System.EventHandler(this.FrmNotas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNota)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvMaterias;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblPostgrado;
        private System.Windows.Forms.NumericUpDown tbNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bVolver;
        private System.Drawing.Printing.PrintDocument pdImpresion;

    }
}
namespace GUI
{
    partial class FrmInscribirAntiguos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscribirAntiguos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAlumnos = new GUI.dgvBase();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPostgrados = new GUI.dgvBase();
            this.bAgregar = new System.Windows.Forms.Button();
            this.lblPostgrados = new System.Windows.Forms.Label();
            this.cmbPostgrados = new System.Windows.Forms.ComboBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostgrados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAlumnos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 353);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(17, 22);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(350, 316);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.SelectionChanged += new System.EventHandler(this.dgvAlumnos_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPostgrados);
            this.groupBox2.Location = new System.Drawing.Point(417, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 153);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postgrados Activos";
            // 
            // dgvPostgrados
            // 
            this.dgvPostgrados.AllowUserToAddRows = false;
            this.dgvPostgrados.AllowUserToDeleteRows = false;
            this.dgvPostgrados.AllowUserToResizeColumns = false;
            this.dgvPostgrados.AllowUserToResizeRows = false;
            this.dgvPostgrados.BackgroundColor = System.Drawing.Color.White;
            this.dgvPostgrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPostgrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPostgrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPostgrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostgrados.Location = new System.Drawing.Point(17, 22);
            this.dgvPostgrados.MultiSelect = false;
            this.dgvPostgrados.Name = "dgvPostgrados";
            this.dgvPostgrados.ReadOnly = true;
            this.dgvPostgrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostgrados.Size = new System.Drawing.Size(350, 113);
            this.dgvPostgrados.TabIndex = 0;
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar;
            this.bAgregar.Location = new System.Drawing.Point(562, 176);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 50);
            this.bAgregar.TabIndex = 4;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // lblPostgrados
            // 
            this.lblPostgrados.AutoSize = true;
            this.lblPostgrados.Location = new System.Drawing.Point(414, 236);
            this.lblPostgrados.Name = "lblPostgrados";
            this.lblPostgrados.Size = new System.Drawing.Size(118, 16);
            this.lblPostgrados.TabIndex = 5;
            this.lblPostgrados.Text = "Postgrados:";
            this.lblPostgrados.Visible = false;
            // 
            // cmbPostgrados
            // 
            this.cmbPostgrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPostgrados.FormattingEnabled = true;
            this.cmbPostgrados.Location = new System.Drawing.Point(417, 255);
            this.cmbPostgrados.Name = "cmbPostgrados";
            this.cmbPostgrados.Size = new System.Drawing.Size(393, 24);
            this.cmbPostgrados.TabIndex = 6;
            this.cmbPostgrados.Visible = false;
            this.cmbPostgrados.SelectedIndexChanged += new System.EventHandler(this.cmbPostgrados_SelectedIndexChanged);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(684, 300);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 18;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(562, 300);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 42;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(441, 300);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 43;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // FrmInscribirAntiguos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 382);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.cmbPostgrados);
            this.Controls.Add(this.lblPostgrados);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmInscribirAntiguos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscribir Alumnos Registrados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInscribirAntiguos_FormClosing);
            this.Load += new System.EventHandler(this.FrmInscribirAntiguos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostgrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvAlumnos;
        private System.Windows.Forms.GroupBox groupBox2;
        private dgvBase dgvPostgrados;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label lblPostgrados;
        private System.Windows.Forms.ComboBox cmbPostgrados;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bCancelar;
    }
}
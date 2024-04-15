namespace GUI
{
    partial class FrmABMMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMMateria));
            this.bVolver = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.tbMateria = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHoras = new System.Windows.Forms.NumericUpDown();
            this.dgvMaterias = new GUI.dgvBase();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(12, 248);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 39;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(487, 248);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 38;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(381, 248);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 37;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(487, 124);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 32;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // tbMateria
            // 
            this.tbMateria.Location = new System.Drawing.Point(12, 215);
            this.tbMateria.MaxLength = 49;
            this.tbMateria.Name = "tbMateria";
            this.tbMateria.ReadOnly = true;
            this.tbMateria.Size = new System.Drawing.Size(319, 23);
            this.tbMateria.TabIndex = 36;
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar;
            this.bAgregar.Location = new System.Drawing.Point(487, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 50);
            this.bAgregar.TabIndex = 30;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Horas Totales:";
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEditar;
            this.bEditar.Location = new System.Drawing.Point(487, 68);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(100, 50);
            this.bEditar.TabIndex = 31;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Materia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(368, 216);
            this.tbHoras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(55, 23);
            this.tbHoras.TabIndex = 40;
            this.tbHoras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.dgvMaterias.Location = new System.Drawing.Point(12, 12);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(470, 162);
            this.dgvMaterias.TabIndex = 29;
            this.dgvMaterias.SelectionChanged += new System.EventHandler(this.dgvMaterias_SelectionChanged);
            // 
            // FrmABMMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 304);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.tbMateria);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmABMMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Materias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmABMMateria_FormClosing);
            this.Load += new System.EventHandler(this.FrmABMMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private dgvBase dgvMaterias;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.TextBox tbMateria;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tbHoras;
    }
}
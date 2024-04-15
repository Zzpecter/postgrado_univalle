namespace GUI
{
    partial class FrmABMTipoAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMTipoAula));
            this.dgvAula = new GUI.dgvBase();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbAula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAula
            // 
            this.dgvAula.AllowUserToAddRows = false;
            this.dgvAula.AllowUserToDeleteRows = false;
            this.dgvAula.AllowUserToResizeColumns = false;
            this.dgvAula.AllowUserToResizeRows = false;
            this.dgvAula.BackgroundColor = System.Drawing.Color.White;
            this.dgvAula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAula.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAula.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAula.Location = new System.Drawing.Point(18, 17);
            this.dgvAula.MultiSelect = false;
            this.dgvAula.Name = "dgvAula";
            this.dgvAula.ReadOnly = true;
            this.dgvAula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAula.Size = new System.Drawing.Size(284, 162);
            this.dgvAula.TabIndex = 87;
            this.dgvAula.SelectionChanged += new System.EventHandler(this.dgvAreas_SelectionChanged);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(322, 277);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 86;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(18, 277);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 85;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(322, 224);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 84;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbAula
            // 
            this.tbAula.Location = new System.Drawing.Point(18, 224);
            this.tbAula.MaxLength = 49;
            this.tbAula.Name = "tbAula";
            this.tbAula.ReadOnly = true;
            this.tbAula.Size = new System.Drawing.Size(284, 23);
            this.tbAula.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Tipo de Aula:";
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(322, 129);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 81;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEditar;
            this.bEditar.Location = new System.Drawing.Point(322, 73);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(100, 50);
            this.bEditar.TabIndex = 80;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar;
            this.bAgregar.Location = new System.Drawing.Point(322, 17);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 50);
            this.bAgregar.TabIndex = 79;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // FrmABMTipoAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 345);
            this.Controls.Add(this.dgvAula);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbAula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmABMTipoAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Aula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmABMTipoAula_FormClosing);
            this.Load += new System.EventHandler(this.FrmABMTipoAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dgvBase dgvAula;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tbAula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bAgregar;
    }
}
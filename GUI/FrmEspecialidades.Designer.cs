namespace GUI
{
    partial class FrmEspecialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspecialidades));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEspecialidadesD = new GUI.dgvBase();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEspecialidadesU = new GUI.dgvBase();
            this.bQuitar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesU)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEspecialidadesD);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Especialidades";
            // 
            // dgvEspecialidadesD
            // 
            this.dgvEspecialidadesD.AllowUserToAddRows = false;
            this.dgvEspecialidadesD.AllowUserToDeleteRows = false;
            this.dgvEspecialidadesD.AllowUserToResizeColumns = false;
            this.dgvEspecialidadesD.AllowUserToResizeRows = false;
            this.dgvEspecialidadesD.BackgroundColor = System.Drawing.Color.White;
            this.dgvEspecialidadesD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEspecialidadesD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvEspecialidadesD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvEspecialidadesD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidadesD.Location = new System.Drawing.Point(18, 22);
            this.dgvEspecialidadesD.MultiSelect = false;
            this.dgvEspecialidadesD.Name = "dgvEspecialidadesD";
            this.dgvEspecialidadesD.ReadOnly = true;
            this.dgvEspecialidadesD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidadesD.Size = new System.Drawing.Size(350, 158);
            this.dgvEspecialidadesD.TabIndex = 1;
            this.dgvEspecialidadesD.SelectionChanged += new System.EventHandler(this.dgvEspecialidadesD_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEspecialidadesU);
            this.groupBox1.Location = new System.Drawing.Point(531, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 207);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especialidades Seleccionadas";
            // 
            // dgvEspecialidadesU
            // 
            this.dgvEspecialidadesU.AllowUserToAddRows = false;
            this.dgvEspecialidadesU.AllowUserToDeleteRows = false;
            this.dgvEspecialidadesU.AllowUserToResizeColumns = false;
            this.dgvEspecialidadesU.AllowUserToResizeRows = false;
            this.dgvEspecialidadesU.BackgroundColor = System.Drawing.Color.White;
            this.dgvEspecialidadesU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEspecialidadesU.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvEspecialidadesU.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvEspecialidadesU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidadesU.Location = new System.Drawing.Point(18, 22);
            this.dgvEspecialidadesU.MultiSelect = false;
            this.dgvEspecialidadesU.Name = "dgvEspecialidadesU";
            this.dgvEspecialidadesU.ReadOnly = true;
            this.dgvEspecialidadesU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidadesU.Size = new System.Drawing.Size(350, 158);
            this.dgvEspecialidadesU.TabIndex = 1;
            this.dgvEspecialidadesU.SelectionChanged += new System.EventHandler(this.dgvEspecialidadesU_SelectionChanged);
            // 
            // bQuitar
            // 
            this.bQuitar.BackgroundImage = global::GUI.Properties.Resources.imgFlechaI;
            this.bQuitar.Location = new System.Drawing.Point(410, 143);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(118, 49);
            this.bQuitar.TabIndex = 30;
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgFlechaD;
            this.bAgregar.Location = new System.Drawing.Point(410, 34);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(118, 49);
            this.bAgregar.TabIndex = 29;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(12, 225);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 19;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // FrmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 285);
            this.Controls.Add(this.bQuitar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEspecialidades_FormClosing);
            this.Load += new System.EventHandler(this.FrmEspecialidades_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidadesU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private dgvBase dgvEspecialidadesD;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvEspecialidadesU;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bQuitar;
    }
}
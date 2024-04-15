namespace GUI
{
    partial class FrmSeleccionPostgrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionPostgrado));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPostgrados = new GUI.dgvBase();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAlumnos = new GUI.dgvBase();
            this.bVolver = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostgrados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPostgrados);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 375);
            this.groupBox2.TabIndex = 5;
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
            this.dgvPostgrados.Size = new System.Drawing.Size(350, 337);
            this.dgvPostgrados.TabIndex = 0;
            this.dgvPostgrados.SelectionChanged += new System.EventHandler(this.dgvPostgrados_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAlumnos);
            this.groupBox1.Location = new System.Drawing.Point(425, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 375);
            this.groupBox1.TabIndex = 4;
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
            this.dgvAlumnos.Size = new System.Drawing.Size(350, 337);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.SelectionChanged += new System.EventHandler(this.dgvAlumnos_SelectionChanged);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(279, 407);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 42;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEditar;
            this.bEditar.Location = new System.Drawing.Point(442, 407);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(100, 50);
            this.bEditar.TabIndex = 41;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // FrmSeleccionPostgrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 469);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmSeleccionPostgrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione el Alumno para Ingresar sus Notas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeleccionPostgrado_FormClosing);
            this.Load += new System.EventHandler(this.FrmSeleccionPostgrado_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostgrados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private dgvBase dgvPostgrados;
        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvAlumnos;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bEditar;
    }
}
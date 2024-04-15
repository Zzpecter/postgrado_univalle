namespace GUI
{
    partial class FrmPostgrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPostgrados));
            this.dgvPostgrados = new GUI.dgvBase();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bHorarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostgrados)).BeginInit();
            this.SuspendLayout();
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
            this.dgvPostgrados.Location = new System.Drawing.Point(12, 92);
            this.dgvPostgrados.MultiSelect = false;
            this.dgvPostgrados.Name = "dgvPostgrados";
            this.dgvPostgrados.ReadOnly = true;
            this.dgvPostgrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostgrados.Size = new System.Drawing.Size(550, 218);
            this.dgvPostgrados.TabIndex = 0;
            this.dgvPostgrados.SelectionChanged += new System.EventHandler(this.dgvPostgrados_SelectionChanged);
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(581, 238);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEditar;
            this.bEditar.Location = new System.Drawing.Point(581, 165);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(100, 50);
            this.bEditar.TabIndex = 6;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar;
            this.bAgregar.Location = new System.Drawing.Point(581, 92);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 50);
            this.bAgregar.TabIndex = 5;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(12, 25);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 19;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bHorarios
            // 
            this.bHorarios.Location = new System.Drawing.Point(12, 320);
            this.bHorarios.Name = "bHorarios";
            this.bHorarios.Size = new System.Drawing.Size(112, 50);
            this.bHorarios.TabIndex = 20;
            this.bHorarios.Text = "Programar Horarios";
            this.bHorarios.UseVisualStyleBackColor = true;
            this.bHorarios.Click += new System.EventHandler(this.bHorarios_Click);
            // 
            // FrmPostgrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 378);
            this.Controls.Add(this.bHorarios);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dgvPostgrados);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPostgrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Postgrados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPostgrados_FormClosing);
            this.Load += new System.EventHandler(this.FrmPostgrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostgrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dgvBase dgvPostgrados;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bHorarios;
    }
}
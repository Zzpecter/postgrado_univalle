namespace GUI
{
    partial class FrmInteresados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInteresados));
            this.bCancelar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.gbTelefonos = new System.Windows.Forms.GroupBox();
            this.bEditarTelf = new System.Windows.Forms.Button();
            this.dgvTelefonos = new GUI.dgvBase();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAreas = new GUI.dgvBase();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvInteresados = new GUI.dgvBase();
            this.gbTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteresados)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(500, 600);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 45;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(18, 600);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 39;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(369, 600);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 38;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(288, 91);
            this.tbDireccion.MaxLength = 49;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ReadOnly = true;
            this.tbDireccion.Size = new System.Drawing.Size(284, 23);
            this.tbDireccion.TabIndex = 37;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(288, 42);
            this.tbCorreo.MaxLength = 49;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.ReadOnly = true;
            this.tbCorreo.Size = new System.Drawing.Size(284, 23);
            this.tbCorreo.TabIndex = 36;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(16, 92);
            this.tbApellidos.MaxLength = 49;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.Size = new System.Drawing.Size(237, 23);
            this.tbApellidos.TabIndex = 35;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(16, 42);
            this.tbNombres.MaxLength = 49;
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.ReadOnly = true;
            this.tbNombres.Size = new System.Drawing.Size(237, 23);
            this.tbNombres.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombres:";
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(500, 199);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 28;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEditar;
            this.bEditar.Location = new System.Drawing.Point(500, 108);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(100, 50);
            this.bEditar.TabIndex = 27;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar;
            this.bAgregar.Location = new System.Drawing.Point(500, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 50);
            this.bAgregar.TabIndex = 26;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // gbTelefonos
            // 
            this.gbTelefonos.Controls.Add(this.bEditarTelf);
            this.gbTelefonos.Controls.Add(this.dgvTelefonos);
            this.gbTelefonos.Location = new System.Drawing.Point(363, 389);
            this.gbTelefonos.Name = "gbTelefonos";
            this.gbTelefonos.Size = new System.Drawing.Size(237, 186);
            this.gbTelefonos.TabIndex = 46;
            this.gbTelefonos.TabStop = false;
            this.gbTelefonos.Text = "Teléfonos";
            // 
            // bEditarTelf
            // 
            this.bEditarTelf.BackgroundImage = global::GUI.Properties.Resources.imgEditarMini;
            this.bEditarTelf.Location = new System.Drawing.Point(206, 155);
            this.bEditarTelf.Name = "bEditarTelf";
            this.bEditarTelf.Size = new System.Drawing.Size(25, 25);
            this.bEditarTelf.TabIndex = 19;
            this.bEditarTelf.UseVisualStyleBackColor = true;
            this.bEditarTelf.Click += new System.EventHandler(this.bEditarTelf_Click);
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.AllowUserToAddRows = false;
            this.dgvTelefonos.AllowUserToDeleteRows = false;
            this.dgvTelefonos.AllowUserToResizeColumns = false;
            this.dgvTelefonos.AllowUserToResizeRows = false;
            this.dgvTelefonos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTelefonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvTelefonos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Enabled = false;
            this.dgvTelefonos.Location = new System.Drawing.Point(6, 22);
            this.dgvTelefonos.MultiSelect = false;
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.ReadOnly = true;
            this.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonos.Size = new System.Drawing.Size(225, 127);
            this.dgvTelefonos.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCorreo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.tbNombres);
            this.groupBox1.Controls.Add(this.tbApellidos);
            this.groupBox1.Location = new System.Drawing.Point(22, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 128);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Personal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAreas);
            this.groupBox2.Location = new System.Drawing.Point(22, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 186);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Áreas de Interés";
            // 
            // dgvAreas
            // 
            this.dgvAreas.AllowUserToAddRows = false;
            this.dgvAreas.AllowUserToDeleteRows = false;
            this.dgvAreas.AllowUserToResizeColumns = false;
            this.dgvAreas.AllowUserToResizeRows = false;
            this.dgvAreas.BackgroundColor = System.Drawing.Color.White;
            this.dgvAreas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAreas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAreas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            this.dgvAreas.Enabled = false;
            this.dgvAreas.Location = new System.Drawing.Point(16, 22);
            this.dgvAreas.MultiSelect = false;
            this.dgvAreas.Name = "dgvAreas";
            this.dgvAreas.ReadOnly = true;
            this.dgvAreas.RowHeadersVisible = false;
            this.dgvAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAreas.Size = new System.Drawing.Size(300, 155);
            this.dgvAreas.TabIndex = 48;
            // 
            // check
            // 
            this.check.HeaderText = "Check";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            // 
            // dgvInteresados
            // 
            this.dgvInteresados.AllowUserToAddRows = false;
            this.dgvInteresados.AllowUserToDeleteRows = false;
            this.dgvInteresados.AllowUserToResizeColumns = false;
            this.dgvInteresados.AllowUserToResizeRows = false;
            this.dgvInteresados.BackgroundColor = System.Drawing.Color.White;
            this.dgvInteresados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInteresados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvInteresados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvInteresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteresados.Location = new System.Drawing.Point(22, 12);
            this.dgvInteresados.MultiSelect = false;
            this.dgvInteresados.Name = "dgvInteresados";
            this.dgvInteresados.ReadOnly = true;
            this.dgvInteresados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInteresados.Size = new System.Drawing.Size(472, 237);
            this.dgvInteresados.TabIndex = 50;
            this.dgvInteresados.SelectionChanged += new System.EventHandler(this.dgvInteresados_SelectionChanged);
            // 
            // FrmInteresados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 657);
            this.Controls.Add(this.dgvInteresados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTelefonos);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmInteresados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interesados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInteresados_FormClosing);
            this.Load += new System.EventHandler(this.FrmInteresados_Load);
            this.gbTelefonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteresados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.GroupBox gbTelefonos;
        private dgvBase dgvTelefonos;
        private System.Windows.Forms.Button bEditarTelf;
        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvAreas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.GroupBox groupBox2;
        private dgvBase dgvInteresados;
    }
}
namespace GUI
{
    partial class FrmABMEgresados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMEgresados));
            this.gbTelefonos = new System.Windows.Forms.GroupBox();
            this.dgvTelefonos = new GUI.dgvBase();
            this.bEditarTelf = new System.Windows.Forms.Button();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tbNacionalidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAlumnos = new GUI.dgvBase();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.gbTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTelefonos
            // 
            this.gbTelefonos.Controls.Add(this.dgvTelefonos);
            this.gbTelefonos.Controls.Add(this.bEditarTelf);
            this.gbTelefonos.Location = new System.Drawing.Point(14, 67);
            this.gbTelefonos.Name = "gbTelefonos";
            this.gbTelefonos.Size = new System.Drawing.Size(237, 222);
            this.gbTelefonos.TabIndex = 79;
            this.gbTelefonos.TabStop = false;
            this.gbTelefonos.Text = "Teléfonos";
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
            this.dgvTelefonos.RowHeadersVisible = false;
            this.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonos.Size = new System.Drawing.Size(225, 163);
            this.dgvTelefonos.TabIndex = 17;
            // 
            // bEditarTelf
            // 
            this.bEditarTelf.BackgroundImage = global::GUI.Properties.Resources.imgEditarMini;
            this.bEditarTelf.Location = new System.Drawing.Point(206, 191);
            this.bEditarTelf.Name = "bEditarTelf";
            this.bEditarTelf.Size = new System.Drawing.Size(25, 25);
            this.bEditarTelf.TabIndex = 16;
            this.bEditarTelf.UseVisualStyleBackColor = true;
            this.bEditarTelf.Click += new System.EventHandler(this.bEditarTelf_Click);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Enabled = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(14, 426);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(284, 24);
            this.cmbTipoDocumento.TabIndex = 78;
            // 
            // tbNacionalidad
            // 
            this.tbNacionalidad.Location = new System.Drawing.Point(614, 327);
            this.tbNacionalidad.MaxLength = 49;
            this.tbNacionalidad.Name = "tbNacionalidad";
            this.tbNacionalidad.ReadOnly = true;
            this.tbNacionalidad.Size = new System.Drawing.Size(243, 23);
            this.tbNacionalidad.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "Nacionalidad:";
            // 
            // tbNumDocumento
            // 
            this.tbNumDocumento.Location = new System.Drawing.Point(313, 427);
            this.tbNumDocumento.MaxLength = 49;
            this.tbNumDocumento.Name = "tbNumDocumento";
            this.tbNumDocumento.ReadOnly = true;
            this.tbNumDocumento.Size = new System.Drawing.Size(284, 23);
            this.tbNumDocumento.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Numero Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = "Tipo Documento:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(313, 376);
            this.tbDireccion.MaxLength = 49;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ReadOnly = true;
            this.tbDireccion.Size = new System.Drawing.Size(284, 23);
            this.tbDireccion.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Direccion:";
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
            this.dgvAlumnos.Location = new System.Drawing.Point(257, 89);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(600, 180);
            this.dgvAlumnos.TabIndex = 70;
            this.dgvAlumnos.SelectionChanged += new System.EventHandler(this.dgvAlumnos_SelectionChanged);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(762, 400);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 69;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(14, 11);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 68;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(639, 400);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 67;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(14, 376);
            this.tbCorreo.MaxLength = 49;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.ReadOnly = true;
            this.tbCorreo.Size = new System.Drawing.Size(284, 23);
            this.tbCorreo.TabIndex = 66;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(313, 327);
            this.tbApellidos.MaxLength = 49;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.Size = new System.Drawing.Size(284, 23);
            this.tbApellidos.TabIndex = 65;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(14, 327);
            this.tbNombres.MaxLength = 49;
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.ReadOnly = true;
            this.tbNombres.Size = new System.Drawing.Size(284, 23);
            this.tbNombres.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nombres:";
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(757, 33);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 60;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEditar;
            this.bEditar.Location = new System.Drawing.Point(631, 33);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(100, 50);
            this.bEditar.TabIndex = 59;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar;
            this.bAgregar.Location = new System.Drawing.Point(506, 33);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 50);
            this.bAgregar.TabIndex = 58;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Visible = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // FrmABMEgresados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 461);
            this.Controls.Add(this.gbTelefonos);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.tbNacionalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNumDocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmABMEgresados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Egresados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmABMEgresados_FormClosing);
            this.Load += new System.EventHandler(this.FrmABMEgresados_Load);
            this.gbTelefonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTelefonos;
        private dgvBase dgvTelefonos;
        private System.Windows.Forms.Button bEditarTelf;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox tbNacionalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNumDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label4;
        private dgvBase dgvAlumnos;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bAgregar;
    }
}
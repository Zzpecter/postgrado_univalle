namespace GUI
{
    partial class FrmDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocentes));
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTelefonos = new System.Windows.Forms.GroupBox();
            this.dgvTelefonos = new GUI.dgvBase();
            this.bEditarTelf = new System.Windows.Forms.Button();
            this.tbNacionalidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.dgvDocentes = new GUI.dgvBase();
            this.gbTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(739, 12);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEditar;
            this.bEditar.Location = new System.Drawing.Point(586, 12);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(100, 50);
            this.bEditar.TabIndex = 6;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar;
            this.bAgregar.Location = new System.Drawing.Point(416, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 50);
            this.bAgregar.TabIndex = 5;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(739, 399);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 26;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(739, 323);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 25;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(439, 323);
            this.tbApellidos.MaxLength = 49;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.Size = new System.Drawing.Size(277, 23);
            this.tbApellidos.TabIndex = 31;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(33, 323);
            this.tbNombres.MaxLength = 49;
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.ReadOnly = true;
            this.tbNombres.Size = new System.Drawing.Size(297, 23);
            this.tbNombres.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombres:";
            // 
            // tbNumDocumento
            // 
            this.tbNumDocumento.Location = new System.Drawing.Point(33, 423);
            this.tbNumDocumento.MaxLength = 49;
            this.tbNumDocumento.Name = "tbNumDocumento";
            this.tbNumDocumento.ReadOnly = true;
            this.tbNumDocumento.Size = new System.Drawing.Size(206, 23);
            this.tbNumDocumento.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tipo de Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Número de Documento:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(259, 423);
            this.tbDireccion.MaxLength = 49;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ReadOnly = true;
            this.tbDireccion.Size = new System.Drawing.Size(176, 23);
            this.tbDireccion.TabIndex = 39;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(441, 373);
            this.tbCorreo.MaxLength = 49;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.ReadOnly = true;
            this.tbCorreo.Size = new System.Drawing.Size(275, 23);
            this.tbCorreo.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Correo:";
            // 
            // gbTelefonos
            // 
            this.gbTelefonos.Controls.Add(this.dgvTelefonos);
            this.gbTelefonos.Controls.Add(this.bEditarTelf);
            this.gbTelefonos.Location = new System.Drawing.Point(33, 68);
            this.gbTelefonos.Name = "gbTelefonos";
            this.gbTelefonos.Size = new System.Drawing.Size(237, 222);
            this.gbTelefonos.TabIndex = 40;
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
            this.bEditarTelf.Click += new System.EventHandler(this.bAgregarTelf_Click);
            // 
            // tbNacionalidad
            // 
            this.tbNacionalidad.Location = new System.Drawing.Point(259, 373);
            this.tbNacionalidad.MaxLength = 49;
            this.tbNacionalidad.Name = "tbNacionalidad";
            this.tbNacionalidad.ReadOnly = true;
            this.tbNacionalidad.Size = new System.Drawing.Size(176, 23);
            this.tbNacionalidad.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nacionalidad:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Enabled = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(33, 374);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(176, 24);
            this.cmbTipoDocumento.TabIndex = 43;
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(33, 12);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 44;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AllowUserToResizeColumns = false;
            this.dgvDocentes.AllowUserToResizeRows = false;
            this.dgvDocentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDocentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDocentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(289, 68);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(550, 222);
            this.dgvDocentes.TabIndex = 27;
            this.dgvDocentes.SelectionChanged += new System.EventHandler(this.dgvDocentes_SelectionChanged);
            // 
            // FrmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 458);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.tbNacionalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbTelefonos);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNumDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDocentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Docentes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDocentes_FormClosing);
            this.Load += new System.EventHandler(this.FrmDocentes_Load);
            this.gbTelefonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private dgvBase dgvDocentes;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbTelefonos;
        private dgvBase dgvTelefonos;
        private System.Windows.Forms.TextBox tbNacionalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bEditarTelf;
    }
}
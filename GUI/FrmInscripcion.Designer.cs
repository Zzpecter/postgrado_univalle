namespace GUI
{
    partial class FrmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscripcion));
            this.gbInfoBasica = new System.Windows.Forms.GroupBox();
            this.tbNacionalidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.tbNumDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInfoContacto = new System.Windows.Forms.GroupBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bQuitar = new System.Windows.Forms.Button();
            this.dgvTelefonos = new GUI.dgvBase();
            this.bAgregar = new System.Windows.Forms.Button();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPostgrado = new System.Windows.Forms.ComboBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bInscribir = new System.Windows.Forms.Button();
            this.gbInfoBasica.SuspendLayout();
            this.gbInfoContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfoBasica
            // 
            this.gbInfoBasica.Controls.Add(this.tbNacionalidad);
            this.gbInfoBasica.Controls.Add(this.label9);
            this.gbInfoBasica.Controls.Add(this.cmbDocumento);
            this.gbInfoBasica.Controls.Add(this.tbNumDocumento);
            this.gbInfoBasica.Controls.Add(this.label4);
            this.gbInfoBasica.Controls.Add(this.label3);
            this.gbInfoBasica.Controls.Add(this.tbApellidos);
            this.gbInfoBasica.Controls.Add(this.label2);
            this.gbInfoBasica.Controls.Add(this.tbNombres);
            this.gbInfoBasica.Controls.Add(this.label1);
            this.gbInfoBasica.Location = new System.Drawing.Point(12, 12);
            this.gbInfoBasica.Name = "gbInfoBasica";
            this.gbInfoBasica.Size = new System.Drawing.Size(544, 227);
            this.gbInfoBasica.TabIndex = 0;
            this.gbInfoBasica.TabStop = false;
            this.gbInfoBasica.Text = "Información Básica";
            // 
            // tbNacionalidad
            // 
            this.tbNacionalidad.Location = new System.Drawing.Point(220, 198);
            this.tbNacionalidad.MaxLength = 49;
            this.tbNacionalidad.Name = "tbNacionalidad";
            this.tbNacionalidad.Size = new System.Drawing.Size(167, 23);
            this.tbNacionalidad.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nacionalidad:";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Items.AddRange(new object[] {
            "CI",
            "Pasaporte"});
            this.cmbDocumento.Location = new System.Drawing.Point(220, 118);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(220, 24);
            this.cmbDocumento.TabIndex = 8;
            // 
            // tbNumDocumento
            // 
            this.tbNumDocumento.Location = new System.Drawing.Point(220, 157);
            this.tbNumDocumento.MaxLength = 49;
            this.tbNumDocumento.Name = "tbNumDocumento";
            this.tbNumDocumento.Size = new System.Drawing.Size(167, 23);
            this.tbNumDocumento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número de Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Documento:";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(220, 77);
            this.tbApellidos.MaxLength = 49;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(220, 23);
            this.tbApellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(220, 37);
            this.tbNombres.MaxLength = 49;
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(220, 23);
            this.tbNombres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // gbInfoContacto
            // 
            this.gbInfoContacto.Controls.Add(this.tbNumero);
            this.gbInfoContacto.Controls.Add(this.cmbTipo);
            this.gbInfoContacto.Controls.Add(this.label10);
            this.gbInfoContacto.Controls.Add(this.label6);
            this.gbInfoContacto.Controls.Add(this.label5);
            this.gbInfoContacto.Controls.Add(this.bQuitar);
            this.gbInfoContacto.Controls.Add(this.dgvTelefonos);
            this.gbInfoContacto.Controls.Add(this.bAgregar);
            this.gbInfoContacto.Controls.Add(this.tbCorreo);
            this.gbInfoContacto.Controls.Add(this.label7);
            this.gbInfoContacto.Controls.Add(this.tbDireccion);
            this.gbInfoContacto.Controls.Add(this.label8);
            this.gbInfoContacto.Location = new System.Drawing.Point(12, 260);
            this.gbInfoContacto.Name = "gbInfoContacto";
            this.gbInfoContacto.Size = new System.Drawing.Size(544, 285);
            this.gbInfoContacto.TabIndex = 9;
            this.gbInfoContacto.TabStop = false;
            this.gbInfoContacto.Text = "Información De Contacto";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(326, 144);
            this.tbNumero.MaxLength = 49;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(139, 23);
            this.tbNumero.TabIndex = 20;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(326, 200);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(139, 24);
            this.cmbTipo.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Teléfonos:";
            // 
            // bQuitar
            // 
            this.bQuitar.BackgroundImage = global::GUI.Properties.Resources.imgQuitar;
            this.bQuitar.Location = new System.Drawing.Point(362, 248);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(25, 25);
            this.bQuitar.TabIndex = 15;
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
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
            this.dgvTelefonos.Location = new System.Drawing.Point(9, 144);
            this.dgvTelefonos.MultiSelect = false;
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.ReadOnly = true;
            this.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonos.Size = new System.Drawing.Size(300, 129);
            this.dgvTelefonos.TabIndex = 14;
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar2;
            this.bAgregar.Location = new System.Drawing.Point(326, 248);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(25, 25);
            this.bAgregar.TabIndex = 13;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(220, 77);
            this.tbCorreo.MaxLength = 49;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(220, 23);
            this.tbCorreo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Correo:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(220, 37);
            this.tbDireccion.MaxLength = 49;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(220, 23);
            this.tbDireccion.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dirección:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPostgrado);
            this.groupBox1.Location = new System.Drawing.Point(12, 551);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postgrado:";
            // 
            // cmbPostgrado
            // 
            this.cmbPostgrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPostgrado.FormattingEnabled = true;
            this.cmbPostgrado.Location = new System.Drawing.Point(51, 35);
            this.cmbPostgrado.Name = "cmbPostgrado";
            this.cmbPostgrado.Size = new System.Drawing.Size(446, 24);
            this.cmbPostgrado.TabIndex = 8;
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(12, 638);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 40;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bInscribir
            // 
            this.bInscribir.BackgroundImage = global::GUI.Properties.Resources.imgInscribir;
            this.bInscribir.Location = new System.Drawing.Point(222, 638);
            this.bInscribir.Name = "bInscribir";
            this.bInscribir.Size = new System.Drawing.Size(119, 51);
            this.bInscribir.TabIndex = 12;
            this.bInscribir.UseVisualStyleBackColor = true;
            this.bInscribir.Click += new System.EventHandler(this.bInscribir_Click);
            // 
            // FrmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 692);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bInscribir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInfoContacto);
            this.Controls.Add(this.gbInfoBasica);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripción de Alumnos Nuevos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInscripcion_FormClosing);
            this.Load += new System.EventHandler(this.FrmInscripcion_Load);
            this.gbInfoBasica.ResumeLayout(false);
            this.gbInfoBasica.PerformLayout();
            this.gbInfoContacto.ResumeLayout(false);
            this.gbInfoContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoBasica;
        private System.Windows.Forms.TextBox tbNacionalidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.TextBox tbNumDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbInfoContacto;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPostgrado;
        private System.Windows.Forms.Button bInscribir;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bQuitar;
        private dgvBase dgvTelefonos;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bVolver;
    }
}
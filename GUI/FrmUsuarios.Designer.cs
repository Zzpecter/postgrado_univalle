namespace GUI
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.msUsuarios = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.linkCambiarImagen = new System.Windows.Forms.LinkLabel();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ofdBuscarImagen = new System.Windows.Forms.OpenFileDialog();
            this.bCancelar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bResetear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(255, 109);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsuarios.Size = new System.Drawing.Size(441, 237);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // msUsuarios
            // 
            this.msUsuarios.Location = new System.Drawing.Point(0, 0);
            this.msUsuarios.Name = "msUsuarios";
            this.msUsuarios.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msUsuarios.Size = new System.Drawing.Size(817, 24);
            this.msUsuarios.TabIndex = 1;
            this.msUsuarios.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nivel de Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Login:";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(15, 367);
            this.tbNombres.MaxLength = 49;
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.ReadOnly = true;
            this.tbNombres.Size = new System.Drawing.Size(176, 22);
            this.tbNombres.TabIndex = 11;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(15, 417);
            this.tbApellidos.MaxLength = 49;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.Size = new System.Drawing.Size(176, 22);
            this.tbApellidos.TabIndex = 12;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(214, 367);
            this.tbCorreo.MaxLength = 49;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.ReadOnly = true;
            this.tbCorreo.Size = new System.Drawing.Size(284, 22);
            this.tbCorreo.TabIndex = 13;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(520, 367);
            this.tbLogin.MaxLength = 49;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.ReadOnly = true;
            this.tbLogin.Size = new System.Drawing.Size(176, 22);
            this.tbLogin.TabIndex = 15;
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.Enabled = false;
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(214, 417);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(146, 23);
            this.cmbNivel.TabIndex = 19;
            // 
            // linkCambiarImagen
            // 
            this.linkCambiarImagen.AutoSize = true;
            this.linkCambiarImagen.Enabled = false;
            this.linkCambiarImagen.Location = new System.Drawing.Point(52, 297);
            this.linkCambiarImagen.Name = "linkCambiarImagen";
            this.linkCambiarImagen.Size = new System.Drawing.Size(160, 15);
            this.linkCambiarImagen.TabIndex = 21;
            this.linkCambiarImagen.TabStop = true;
            this.linkCambiarImagen.Text = "Cambiar Imagen...";
            this.linkCambiarImagen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCambiarImagen_LinkClicked);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(413, 417);
            this.tbPass.MaxLength = 49;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.ReadOnly = true;
            this.tbPass.Size = new System.Drawing.Size(176, 22);
            this.tbPass.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Password:";
            // 
            // ofdBuscarImagen
            // 
            this.ofdBuscarImagen.FileName = "openFileDialog1";
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(710, 402);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 24;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImage = global::GUI.Properties.Resources.imgPerfil;
            this.pbFoto.Location = new System.Drawing.Point(55, 144);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 150);
            this.pbFoto.TabIndex = 20;
            this.pbFoto.TabStop = false;
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(15, 41);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 18;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(710, 339);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 17;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(596, 41);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEditar;
            this.bEditar.Location = new System.Drawing.Point(431, 41);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(100, 50);
            this.bEditar.TabIndex = 3;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar;
            this.bAgregar.Location = new System.Drawing.Point(254, 41);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 50);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bResetear
            // 
            this.bResetear.BackgroundImage = global::GUI.Properties.Resources.imgReset;
            this.bResetear.Location = new System.Drawing.Point(596, 400);
            this.bResetear.Name = "bResetear";
            this.bResetear.Size = new System.Drawing.Size(40, 40);
            this.bResetear.TabIndex = 25;
            this.bResetear.UseVisualStyleBackColor = true;
            this.bResetear.Visible = false;
            this.bResetear.Click += new System.EventHandler(this.bResetear_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 458);
            this.Controls.Add(this.bResetear);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkCambiarImagen);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.msUsuarios);
            this.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msUsuarios;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.MenuStrip msUsuarios;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.LinkLabel linkCambiarImagen;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog ofdBuscarImagen;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bResetear;
    }
}
namespace GUI
{
    partial class FrmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.msPerfil = new System.Windows.Forms.MenuStrip();
            this.linkCambiarImagen = new System.Windows.Forms.LinkLabel();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbNuevoPass2 = new System.Windows.Forms.PictureBox();
            this.pbNuevoPass1 = new System.Windows.Forms.PictureBox();
            this.pbPassActual = new System.Windows.Forms.PictureBox();
            this.pbPass = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPassNuevo2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassNuevo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassActual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bEditarCuenta = new System.Windows.Forms.Button();
            this.bEditarPersonal = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.ofdBuscarImagen = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bEditarPass = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPerfil
            // 
            this.msPerfil.Location = new System.Drawing.Point(0, 0);
            this.msPerfil.Name = "msPerfil";
            this.msPerfil.Size = new System.Drawing.Size(700, 24);
            this.msPerfil.TabIndex = 0;
            this.msPerfil.Text = "menuStrip1";
            // 
            // linkCambiarImagen
            // 
            this.linkCambiarImagen.AutoSize = true;
            this.linkCambiarImagen.Enabled = false;
            this.linkCambiarImagen.Location = new System.Drawing.Point(9, 180);
            this.linkCambiarImagen.Name = "linkCambiarImagen";
            this.linkCambiarImagen.Size = new System.Drawing.Size(160, 15);
            this.linkCambiarImagen.TabIndex = 2;
            this.linkCambiarImagen.TabStop = true;
            this.linkCambiarImagen.Text = "Cambiar Imagen...";
            this.linkCambiarImagen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCambiarImagen_LinkClicked);
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(121, 55);
            this.tbApellidos.MaxLength = 49;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.ReadOnly = true;
            this.tbApellidos.Size = new System.Drawing.Size(212, 22);
            this.tbApellidos.TabIndex = 16;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(121, 18);
            this.tbNombres.MaxLength = 49;
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.ReadOnly = true;
            this.tbNombres.Size = new System.Drawing.Size(212, 22);
            this.tbNombres.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombres:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNombres);
            this.groupBox1.Controls.Add(this.tbApellidos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(190, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Personal";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(121, 22);
            this.tbCorreo.MaxLength = 49;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.ReadOnly = true;
            this.tbCorreo.Size = new System.Drawing.Size(212, 22);
            this.tbCorreo.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Correo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbNuevoPass2);
            this.groupBox2.Controls.Add(this.pbNuevoPass1);
            this.groupBox2.Controls.Add(this.pbPassActual);
            this.groupBox2.Controls.Add(this.pbPass);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbPassNuevo2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbPassNuevo1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbPassActual);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(30, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 211);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contraseñas";
            // 
            // pbNuevoPass2
            // 
            this.pbNuevoPass2.BackgroundImage = global::GUI.Properties.Resources.imgWrong;
            this.pbNuevoPass2.Location = new System.Drawing.Point(491, 96);
            this.pbNuevoPass2.Name = "pbNuevoPass2";
            this.pbNuevoPass2.Size = new System.Drawing.Size(21, 21);
            this.pbNuevoPass2.TabIndex = 27;
            this.pbNuevoPass2.TabStop = false;
            // 
            // pbNuevoPass1
            // 
            this.pbNuevoPass1.BackgroundImage = global::GUI.Properties.Resources.imgWrong;
            this.pbNuevoPass1.Location = new System.Drawing.Point(491, 58);
            this.pbNuevoPass1.Name = "pbNuevoPass1";
            this.pbNuevoPass1.Size = new System.Drawing.Size(21, 21);
            this.pbNuevoPass1.TabIndex = 26;
            this.pbNuevoPass1.TabStop = false;
            // 
            // pbPassActual
            // 
            this.pbPassActual.BackgroundImage = global::GUI.Properties.Resources.imgWrong;
            this.pbPassActual.Location = new System.Drawing.Point(491, 23);
            this.pbPassActual.Name = "pbPassActual";
            this.pbPassActual.Size = new System.Drawing.Size(21, 21);
            this.pbPassActual.TabIndex = 25;
            this.pbPassActual.TabStop = false;
            // 
            // pbPass
            // 
            this.pbPass.Location = new System.Drawing.Point(21, 169);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(447, 23);
            this.pbPass.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Medidor de complejidad:";
            // 
            // tbPassNuevo2
            // 
            this.tbPassNuevo2.Location = new System.Drawing.Point(256, 99);
            this.tbPassNuevo2.MaxLength = 49;
            this.tbPassNuevo2.Name = "tbPassNuevo2";
            this.tbPassNuevo2.PasswordChar = '*';
            this.tbPassNuevo2.ReadOnly = true;
            this.tbPassNuevo2.Size = new System.Drawing.Size(212, 22);
            this.tbPassNuevo2.TabIndex = 21;
            this.tbPassNuevo2.TextChanged += new System.EventHandler(this.tbPassNuevo2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Repita su Nuevo Password:";
            // 
            // tbPassNuevo1
            // 
            this.tbPassNuevo1.Location = new System.Drawing.Point(256, 61);
            this.tbPassNuevo1.MaxLength = 49;
            this.tbPassNuevo1.Name = "tbPassNuevo1";
            this.tbPassNuevo1.PasswordChar = '*';
            this.tbPassNuevo1.ReadOnly = true;
            this.tbPassNuevo1.Size = new System.Drawing.Size(212, 22);
            this.tbPassNuevo1.TabIndex = 19;
            this.tbPassNuevo1.TextChanged += new System.EventHandler(this.tbPassNuevo1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nuevo Password:";
            // 
            // tbPassActual
            // 
            this.tbPassActual.Location = new System.Drawing.Point(256, 26);
            this.tbPassActual.MaxLength = 49;
            this.tbPassActual.Name = "tbPassActual";
            this.tbPassActual.PasswordChar = '*';
            this.tbPassActual.ReadOnly = true;
            this.tbPassActual.Size = new System.Drawing.Size(212, 22);
            this.tbPassActual.TabIndex = 16;
            this.tbPassActual.TextChanged += new System.EventHandler(this.tbPassActual_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password Actual:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(121, 51);
            this.tbLogin.MaxLength = 49;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.ReadOnly = true;
            this.tbLogin.Size = new System.Drawing.Size(212, 22);
            this.tbLogin.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Login:";
            // 
            // bEditarCuenta
            // 
            this.bEditarCuenta.BackgroundImage = global::GUI.Properties.Resources.imgEditarMini;
            this.bEditarCuenta.Location = new System.Drawing.Point(582, 148);
            this.bEditarCuenta.Name = "bEditarCuenta";
            this.bEditarCuenta.Size = new System.Drawing.Size(25, 25);
            this.bEditarCuenta.TabIndex = 23;
            this.bEditarCuenta.UseVisualStyleBackColor = true;
            this.bEditarCuenta.Click += new System.EventHandler(this.bEditarCuenta_Click);
            // 
            // bEditarPersonal
            // 
            this.bEditarPersonal.BackgroundImage = global::GUI.Properties.Resources.imgEditarMini;
            this.bEditarPersonal.Location = new System.Drawing.Point(582, 38);
            this.bEditarPersonal.Name = "bEditarPersonal";
            this.bEditarPersonal.Size = new System.Drawing.Size(25, 25);
            this.bEditarPersonal.TabIndex = 20;
            this.bEditarPersonal.UseVisualStyleBackColor = true;
            this.bEditarPersonal.Click += new System.EventHandler(this.bEditarPersonal_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(588, 394);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 22;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(588, 338);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 21;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(12, 27);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 150);
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // ofdBuscarImagen
            // 
            this.ofdBuscarImagen.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCorreo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbLogin);
            this.groupBox3.Location = new System.Drawing.Point(190, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 79);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Cuenta";
            // 
            // bEditarPass
            // 
            this.bEditarPass.BackgroundImage = global::GUI.Properties.Resources.imgEditarMini;
            this.bEditarPass.Location = new System.Drawing.Point(582, 242);
            this.bEditarPass.Name = "bEditarPass";
            this.bEditarPass.Size = new System.Drawing.Size(25, 25);
            this.bEditarPass.TabIndex = 25;
            this.bEditarPass.UseVisualStyleBackColor = true;
            this.bEditarPass.Click += new System.EventHandler(this.bEditarPass_Click);
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.bEditarPass);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bEditarCuenta);
            this.Controls.Add(this.bEditarPersonal);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkCambiarImagen);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.msPerfil);
            this.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPerfil;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmPerfil";
            this.Text = "Mi Perfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPerfil_FormClosing);
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPerfil;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.LinkLabel linkCambiarImagen;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPassNuevo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassNuevo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bEditarPersonal;
        private System.Windows.Forms.Button bEditarCuenta;
        private System.Windows.Forms.ProgressBar pbPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbNuevoPass2;
        private System.Windows.Forms.PictureBox pbNuevoPass1;
        private System.Windows.Forms.PictureBox pbPassActual;
        private System.Windows.Forms.OpenFileDialog ofdBuscarImagen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bEditarPass;
    }
}
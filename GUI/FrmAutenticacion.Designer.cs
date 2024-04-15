namespace GUI
{
    partial class FrmAutenticacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutenticacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblConectado = new System.Windows.Forms.Label();
            this.bConfig = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.bIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(360, 72);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(5);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(164, 23);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(360, 147);
            this.tbPass.Margin = new System.Windows.Forms.Padding(5);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(164, 23);
            this.tbPass.TabIndex = 2;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // lblConectado
            // 
            this.lblConectado.AutoSize = true;
            this.lblConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConectado.Location = new System.Drawing.Point(8, 335);
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(0, 16);
            this.lblConectado.TabIndex = 7;
            // 
            // bConfig
            // 
            this.bConfig.BackgroundImage = global::GUI.Properties.Resources.imgConfig;
            this.bConfig.Location = new System.Drawing.Point(603, 311);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(40, 40);
            this.bConfig.TabIndex = 8;
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::GUI.Properties.Resources.imgLogo;
            this.pbLogo.Location = new System.Drawing.Point(11, 9);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(199, 235);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // bSalir
            // 
            this.bSalir.BackgroundImage = global::GUI.Properties.Resources.imgSalir;
            this.bSalir.Location = new System.Drawing.Point(336, 251);
            this.bSalir.Margin = new System.Windows.Forms.Padding(5);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(188, 75);
            this.bSalir.TabIndex = 4;
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bIngresar
            // 
            this.bIngresar.BackgroundImage = global::GUI.Properties.Resources.imgAutenticarse;
            this.bIngresar.Location = new System.Drawing.Point(128, 251);
            this.bIngresar.Margin = new System.Windows.Forms.Padding(5);
            this.bIngresar.Name = "bIngresar";
            this.bIngresar.Size = new System.Drawing.Size(188, 75);
            this.bIngresar.TabIndex = 3;
            this.bIngresar.UseVisualStyleBackColor = true;
            this.bIngresar.Click += new System.EventHandler(this.bIngresar_Click);
            // 
            // FrmAutenticacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 360);
            this.Controls.Add(this.bConfig);
            this.Controls.Add(this.lblConectado);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bIngresar);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmAutenticacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAutenticacion_FormClosing);
            this.Load += new System.EventHandler(this.FrmAutenticacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button bIngresar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblConectado;
        private System.Windows.Forms.Button bConfig;
    }
}
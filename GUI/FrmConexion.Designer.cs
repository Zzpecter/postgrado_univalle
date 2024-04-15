namespace GUI
{
    partial class FrmConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConexion));
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbIP = new System.Windows.Forms.RadioButton();
            this.tbIP1 = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbIP2 = new System.Windows.Forms.TextBox();
            this.tbIP3 = new System.Windows.Forms.TextBox();
            this.tbIP4 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.tbPuerto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Checked = true;
            this.rbLocal.Location = new System.Drawing.Point(12, 12);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(76, 20);
            this.rbLocal.TabIndex = 0;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.ControlRB);
            // 
            // rbIP
            // 
            this.rbIP.AutoSize = true;
            this.rbIP.Location = new System.Drawing.Point(12, 47);
            this.rbIP.Name = "rbIP";
            this.rbIP.Size = new System.Drawing.Size(156, 20);
            this.rbIP.TabIndex = 1;
            this.rbIP.Text = "Dirección IP:";
            this.rbIP.UseVisualStyleBackColor = true;
            this.rbIP.CheckedChanged += new System.EventHandler(this.ControlRB);
            // 
            // tbIP1
            // 
            this.tbIP1.Location = new System.Drawing.Point(174, 46);
            this.tbIP1.MaxLength = 3;
            this.tbIP1.Name = "tbIP1";
            this.tbIP1.Size = new System.Drawing.Size(43, 23);
            this.tbIP1.TabIndex = 2;
            this.tbIP1.Visible = false;
            this.tbIP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTB);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(272, 81);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 97;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(164, 81);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 96;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbIP2
            // 
            this.tbIP2.Location = new System.Drawing.Point(247, 46);
            this.tbIP2.MaxLength = 3;
            this.tbIP2.Name = "tbIP2";
            this.tbIP2.Size = new System.Drawing.Size(43, 23);
            this.tbIP2.TabIndex = 98;
            this.tbIP2.Visible = false;
            this.tbIP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTB);
            // 
            // tbIP3
            // 
            this.tbIP3.Location = new System.Drawing.Point(320, 46);
            this.tbIP3.MaxLength = 3;
            this.tbIP3.Name = "tbIP3";
            this.tbIP3.Size = new System.Drawing.Size(43, 23);
            this.tbIP3.TabIndex = 99;
            this.tbIP3.Visible = false;
            this.tbIP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTB);
            // 
            // tbIP4
            // 
            this.tbIP4.Location = new System.Drawing.Point(393, 46);
            this.tbIP4.MaxLength = 3;
            this.tbIP4.Name = "tbIP4";
            this.tbIP4.Size = new System.Drawing.Size(43, 23);
            this.tbIP4.TabIndex = 100;
            this.tbIP4.Visible = false;
            this.tbIP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTB);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(223, 49);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(18, 16);
            this.lbl1.TabIndex = 101;
            this.lbl1.Text = ".";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(296, 49);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(18, 16);
            this.lbl2.TabIndex = 102;
            this.lbl2.Text = ".";
            this.lbl2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(369, 49);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(18, 16);
            this.lbl3.TabIndex = 103;
            this.lbl3.Text = ".";
            this.lbl3.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(442, 49);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(18, 16);
            this.lbl4.TabIndex = 104;
            this.lbl4.Text = ":";
            this.lbl4.Visible = false;
            // 
            // tbPuerto
            // 
            this.tbPuerto.Location = new System.Drawing.Point(466, 46);
            this.tbPuerto.MaxLength = 4;
            this.tbPuerto.Name = "tbPuerto";
            this.tbPuerto.Size = new System.Drawing.Size(58, 23);
            this.tbPuerto.TabIndex = 105;
            this.tbPuerto.Visible = false;
            this.tbPuerto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlTB);
            // 
            // FrmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 143);
            this.Controls.Add(this.tbPuerto);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tbIP4);
            this.Controls.Add(this.tbIP3);
            this.Controls.Add(this.tbIP2);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbIP1);
            this.Controls.Add(this.rbIP);
            this.Controls.Add(this.rbLocal);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConexion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbIP;
        private System.Windows.Forms.TextBox tbIP1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tbIP2;
        private System.Windows.Forms.TextBox tbIP3;
        private System.Windows.Forms.TextBox tbIP4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tbPuerto;
    }
}
namespace GUI
{
    partial class FrmPasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasswordReset));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPass1 = new System.Windows.Forms.TextBox();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Su Contraseña fue Reseteada! ¡Ingrese una nueva!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirme su Contraseña:";
            // 
            // tbPass1
            // 
            this.tbPass1.Location = new System.Drawing.Point(298, 52);
            this.tbPass1.Name = "tbPass1";
            this.tbPass1.PasswordChar = '*';
            this.tbPass1.Size = new System.Drawing.Size(236, 23);
            this.tbPass1.TabIndex = 3;
            // 
            // tbPass2
            // 
            this.tbPass2.Location = new System.Drawing.Point(298, 93);
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.PasswordChar = '*';
            this.tbPass2.Size = new System.Drawing.Size(236, 23);
            this.tbPass2.TabIndex = 4;
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(271, 128);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 18;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // FrmPasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 190);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbPass2);
            this.Controls.Add(this.tbPass1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPasswordReset_FormClosing);
            this.Load += new System.EventHandler(this.FrmPasswordReset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPass1;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.Button bGuardar;
    }
}
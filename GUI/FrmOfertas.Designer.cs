namespace GUI
{
    partial class FrmOfertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOfertas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAreas = new GUI.dgvBase();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.tbDestinatarios = new System.Windows.Forms.TextBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bCorreos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAreas);
            this.groupBox1.Location = new System.Drawing.Point(96, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Areas:";
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
            this.dgvAreas.Location = new System.Drawing.Point(6, 22);
            this.dgvAreas.MultiSelect = false;
            this.dgvAreas.Name = "dgvAreas";
            this.dgvAreas.ReadOnly = true;
            this.dgvAreas.RowHeadersVisible = false;
            this.dgvAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAreas.Size = new System.Drawing.Size(300, 155);
            this.dgvAreas.TabIndex = 49;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.tbDestinatarios);
            this.GroupBox3.Location = new System.Drawing.Point(18, 229);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(633, 125);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Destinatarios:";
            // 
            // tbDestinatarios
            // 
            this.tbDestinatarios.Location = new System.Drawing.Point(7, 34);
            this.tbDestinatarios.Multiline = true;
            this.tbDestinatarios.Name = "tbDestinatarios";
            this.tbDestinatarios.ReadOnly = true;
            this.tbDestinatarios.Size = new System.Drawing.Size(616, 74);
            this.tbDestinatarios.TabIndex = 0;
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(274, 360);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 40;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bCorreos
            // 
            this.bCorreos.BackgroundImage = global::GUI.Properties.Resources.imgCorreo;
            this.bCorreos.Location = new System.Drawing.Point(439, 140);
            this.bCorreos.Name = "bCorreos";
            this.bCorreos.Size = new System.Drawing.Size(125, 80);
            this.bCorreos.TabIndex = 41;
            this.bCorreos.UseVisualStyleBackColor = true;
            this.bCorreos.Click += new System.EventHandler(this.bCorreos_Click);
            // 
            // FrmOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 414);
            this.Controls.Add(this.bCorreos);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmOfertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de ofertas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOfertas_FormClosing);
            this.Load += new System.EventHandler(this.FrmOfertas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvAreas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.TextBox tbDestinatarios;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bCorreos;
    }
}
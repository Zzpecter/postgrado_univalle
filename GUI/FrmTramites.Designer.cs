namespace GUI
{
    partial class FrmTramites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTramites));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTramites = new GUI.dgvBase();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.tbComentario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramites)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTramites);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egresados";
            // 
            // dgvTramites
            // 
            this.dgvTramites.AllowUserToAddRows = false;
            this.dgvTramites.AllowUserToDeleteRows = false;
            this.dgvTramites.AllowUserToResizeColumns = false;
            this.dgvTramites.AllowUserToResizeRows = false;
            this.dgvTramites.BackgroundColor = System.Drawing.Color.White;
            this.dgvTramites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTramites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvTramites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramites.Location = new System.Drawing.Point(19, 22);
            this.dgvTramites.MultiSelect = false;
            this.dgvTramites.Name = "dgvTramites";
            this.dgvTramites.ReadOnly = true;
            this.dgvTramites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTramites.Size = new System.Drawing.Size(550, 234);
            this.dgvTramites.TabIndex = 0;
            this.dgvTramites.SelectionChanged += new System.EventHandler(this.dgvTramites_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bCancelar);
            this.groupBox2.Controls.Add(this.bGuardar);
            this.groupBox2.Controls.Add(this.cmbEstado);
            this.groupBox2.Controls.Add(this.tbComentario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado del Trámite";
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(305, 132);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 26;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(180, 132);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 25;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Faltan Documentos",
            "En Progreso",
            "Finalizado"});
            this.cmbEstado.Location = new System.Drawing.Point(240, 24);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(288, 24);
            this.cmbEstado.TabIndex = 6;
            // 
            // tbComentario
            // 
            this.tbComentario.Location = new System.Drawing.Point(240, 54);
            this.tbComentario.MaxLength = 499;
            this.tbComentario.Multiline = true;
            this.tbComentario.Name = "tbComentario";
            this.tbComentario.Size = new System.Drawing.Size(288, 68);
            this.tbComentario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comentario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(252, 492);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 19;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // FrmTramites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 550);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmTramites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Trámites";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTramites_FormClosing);
            this.Load += new System.EventHandler(this.FrmTramites_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramites)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvTramites;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbComentario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
    }
}
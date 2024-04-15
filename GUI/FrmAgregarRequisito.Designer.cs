namespace GUI
{
    partial class FrmAgregarRequisito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarRequisito));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCopia = new System.Windows.Forms.RadioButton();
            this.rbOriginal = new System.Windows.Forms.RadioButton();
            this.tbCopias = new System.Windows.Forms.NumericUpDown();
            this.lblCopias = new System.Windows.Forms.Label();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCopias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCopia);
            this.groupBox1.Controls.Add(this.rbOriginal);
            this.groupBox1.Controls.Add(this.tbCopias);
            this.groupBox1.Controls.Add(this.lblCopias);
            this.groupBox1.Controls.Add(this.cmbDocumento);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Requisito";
            // 
            // rbCopia
            // 
            this.rbCopia.AutoSize = true;
            this.rbCopia.Location = new System.Drawing.Point(229, 139);
            this.rbCopia.Name = "rbCopia";
            this.rbCopia.Size = new System.Drawing.Size(76, 20);
            this.rbCopia.TabIndex = 13;
            this.rbCopia.Text = "Copia";
            this.rbCopia.UseVisualStyleBackColor = true;
            // 
            // rbOriginal
            // 
            this.rbOriginal.AutoSize = true;
            this.rbOriginal.Checked = true;
            this.rbOriginal.Location = new System.Drawing.Point(229, 113);
            this.rbOriginal.Name = "rbOriginal";
            this.rbOriginal.Size = new System.Drawing.Size(106, 20);
            this.rbOriginal.TabIndex = 12;
            this.rbOriginal.TabStop = true;
            this.rbOriginal.Text = "Original";
            this.rbOriginal.UseVisualStyleBackColor = true;
            // 
            // tbCopias
            // 
            this.tbCopias.Location = new System.Drawing.Point(229, 177);
            this.tbCopias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbCopias.Name = "tbCopias";
            this.tbCopias.Size = new System.Drawing.Size(68, 23);
            this.tbCopias.TabIndex = 11;
            this.tbCopias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCopias
            // 
            this.lblCopias.AutoSize = true;
            this.lblCopias.Location = new System.Drawing.Point(21, 179);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(98, 16);
            this.lblCopias.TabIndex = 10;
            this.lblCopias.Text = "Cantidad:";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(229, 70);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(245, 24);
            this.cmbDocumento.TabIndex = 9;
            this.cmbDocumento.SelectedIndexChanged += new System.EventHandler(this.cmbDocumento_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(229, 31);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(173, 24);
            this.cmbTipo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Necesario Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo Ejemplar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documento:";
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(329, 234);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 16;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(190, 234);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 15;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // FrmAgregarRequisito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 296);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarRequisito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Requisito...";
            this.Load += new System.EventHandler(this.FrmAgregarRequisito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCopias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.NumericUpDown tbCopias;
        private System.Windows.Forms.Label lblCopias;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.RadioButton rbCopia;
        private System.Windows.Forms.RadioButton rbOriginal;
    }
}
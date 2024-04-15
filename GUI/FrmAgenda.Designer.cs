namespace GUI
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAgenda = new GUI.dgvBase();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFechaInvalida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnotaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAgenda);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anotaciones";
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.AllowUserToResizeColumns = false;
            this.dgvAgenda.AllowUserToResizeRows = false;
            this.dgvAgenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.ColumnHeadersVisible = false;
            this.dgvAgenda.Location = new System.Drawing.Point(6, 22);
            this.dgvAgenda.MultiSelect = false;
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(600, 154);
            this.dgvAgenda.TabIndex = 0;
            this.dgvAgenda.SelectionChanged += new System.EventHandler(this.dgvAgenda_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFechaInvalida);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbNombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbAnotaciones);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 232);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // lblFechaInvalida
            // 
            this.lblFechaInvalida.AutoSize = true;
            this.lblFechaInvalida.ForeColor = System.Drawing.Color.Red;
            this.lblFechaInvalida.Location = new System.Drawing.Point(203, 78);
            this.lblFechaInvalida.Name = "lblFechaInvalida";
            this.lblFechaInvalida.Size = new System.Drawing.Size(228, 16);
            this.lblFechaInvalida.TabIndex = 13;
            this.lblFechaInvalida.Text = "La Fecha ya es pasada!";
            this.lblFechaInvalida.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha Acuerdo:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(206, 31);
            this.tbNombre.MaxLength = 49;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(402, 23);
            this.tbNombre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre:";
            // 
            // tbAnotaciones
            // 
            this.tbAnotaciones.Location = new System.Drawing.Point(200, 131);
            this.tbAnotaciones.MaxLength = 499;
            this.tbAnotaciones.Multiline = true;
            this.tbAnotaciones.Name = "tbAnotaciones";
            this.tbAnotaciones.Size = new System.Drawing.Size(411, 95);
            this.tbAnotaciones.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anotaciones:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(200, 73);
            this.dtpFecha.MinDate = new System.DateTime(2014, 5, 21, 10, 27, 32, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(408, 23);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.Value = new System.DateTime(2014, 5, 21, 10, 27, 32, 0);
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(424, 225);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 10;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEditar;
            this.bEditar.Location = new System.Drawing.Point(271, 225);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(100, 50);
            this.bEditar.TabIndex = 9;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackgroundImage = global::GUI.Properties.Resources.imgAgregar;
            this.bAgregar.Location = new System.Drawing.Point(101, 225);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 50);
            this.bAgregar.TabIndex = 8;
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(424, 535);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 28;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Visible = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(271, 535);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 27;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(101, 535);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 45;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 593);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAgenda_FormClosing);
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvAgenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAnotaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaInvalida;
    }
}
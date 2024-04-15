namespace GUI
{
    partial class FrmHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorarios));
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.cmbAula = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.dgvClases = new GUI.dgvBase();
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(106, 6);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(502, 24);
            this.cmbMateria.TabIndex = 1;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpSalida);
            this.groupBox1.Controls.Add(this.dtpEntrada);
            this.groupBox1.Controls.Add(this.cmbAula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Clase...";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalida.Location = new System.Drawing.Point(235, 111);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.ShowUpDown = true;
            this.dtpSalida.Size = new System.Drawing.Size(148, 23);
            this.dtpSalida.TabIndex = 18;
            this.dtpSalida.Value = new System.DateTime(2014, 5, 28, 0, 0, 0, 0);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntrada.Location = new System.Drawing.Point(235, 70);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.ShowUpDown = true;
            this.dtpEntrada.Size = new System.Drawing.Size(148, 23);
            this.dtpEntrada.TabIndex = 17;
            this.dtpEntrada.Value = new System.DateTime(2014, 5, 28, 0, 0, 0, 0);
            // 
            // cmbAula
            // 
            this.cmbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAula.FormattingEnabled = true;
            this.cmbAula.Location = new System.Drawing.Point(235, 155);
            this.cmbAula.Name = "cmbAula";
            this.cmbAula.Size = new System.Drawing.Size(100, 24);
            this.cmbAula.TabIndex = 16;
            this.cmbAula.SelectedIndexChanged += new System.EventHandler(this.cmbAula_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Aula:";
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(509, 129);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 14;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(235, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(148, 23);
            this.dtpFecha.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bEliminar);
            this.groupBox2.Controls.Add(this.dgvClases);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clases Programadas";
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(599, 156);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 30;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // dgvClases
            // 
            this.dgvClases.AllowUserToAddRows = false;
            this.dgvClases.AllowUserToDeleteRows = false;
            this.dgvClases.AllowUserToResizeColumns = false;
            this.dgvClases.AllowUserToResizeRows = false;
            this.dgvClases.BackgroundColor = System.Drawing.Color.White;
            this.dgvClases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvClases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClases.Location = new System.Drawing.Point(3, 22);
            this.dgvClases.MultiSelect = false;
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.ReadOnly = true;
            this.dgvClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClases.Size = new System.Drawing.Size(700, 128);
            this.dgvClases.TabIndex = 0;
            this.dgvClases.SelectionChanged += new System.EventHandler(this.dgvClases_SelectionChanged);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(12, 460);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 15;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // FrmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 522);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHorarios_FormClosing);
            this.Load += new System.EventHandler(this.FrmHorarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private dgvBase dgvClases;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.ComboBox cmbAula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Button bEliminar;

    }
}
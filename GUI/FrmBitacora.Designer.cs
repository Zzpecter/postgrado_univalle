namespace GUI
{
    partial class FrmBitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBitacora));
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.rbTabla = new System.Windows.Forms.RadioButton();
            this.rbFechaAtras = new System.Windows.Forms.RadioButton();
            this.rbFechaAdelante = new System.Windows.Forms.RadioButton();
            this.rbFechaEsp = new System.Windows.Forms.RadioButton();
            this.rbTodo = new System.Windows.Forms.RadioButton();
            this.bVolver = new System.Windows.Forms.Button();
            this.dgvBitacora = new GUI.dgvBase();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cmbUsuario);
            this.gbFiltros.Controls.Add(this.cmbTabla);
            this.gbFiltros.Controls.Add(this.dtpFecha);
            this.gbFiltros.Controls.Add(this.rbUsuario);
            this.gbFiltros.Controls.Add(this.rbTabla);
            this.gbFiltros.Controls.Add(this.rbFechaAtras);
            this.gbFiltros.Controls.Add(this.rbFechaAdelante);
            this.gbFiltros.Controls.Add(this.rbFechaEsp);
            this.gbFiltros.Controls.Add(this.rbTodo);
            this.gbFiltros.Location = new System.Drawing.Point(28, 13);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1093, 179);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(476, 149);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(139, 24);
            this.cmbUsuario.TabIndex = 9;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // cmbTabla
            // 
            this.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Items.AddRange(new object[] {
            "Agenda",
            "Alumno",
            "Area",
            "AreaEspecialidad",
            "Aula",
            "DetalleMateria",
            "Docente",
            "Documento",
            "Egresado",
            "Especialidad",
            "EstadoTramite",
            "Fecha",
            "Interesado",
            "Materia",
            "MateriasDictadas",
            "Notas",
            "Persona",
            "Postgrado",
            "Requisitos",
            "Telefono",
            "TipoAula",
            "TipoTelefono",
            "Tramite",
            "Usuario"});
            this.cmbTabla.Location = new System.Drawing.Point(476, 90);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(139, 24);
            this.cmbTabla.TabIndex = 7;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.cmbTabla_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(476, 120);
            this.dtpFecha.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(139, 23);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Location = new System.Drawing.Point(972, 63);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(96, 20);
            this.rbUsuario.TabIndex = 5;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuario";
            this.rbUsuario.UseVisualStyleBackColor = true;
            this.rbUsuario.CheckedChanged += new System.EventHandler(this.CambioFiltro);
            // 
            // rbTabla
            // 
            this.rbTabla.AutoSize = true;
            this.rbTabla.Location = new System.Drawing.Point(972, 37);
            this.rbTabla.Name = "rbTabla";
            this.rbTabla.Size = new System.Drawing.Size(76, 20);
            this.rbTabla.TabIndex = 4;
            this.rbTabla.TabStop = true;
            this.rbTabla.Text = "Tabla";
            this.rbTabla.UseVisualStyleBackColor = true;
            this.rbTabla.CheckedChanged += new System.EventHandler(this.CambioFiltro);
            // 
            // rbFechaAtras
            // 
            this.rbFechaAtras.AutoSize = true;
            this.rbFechaAtras.Location = new System.Drawing.Point(419, 63);
            this.rbFechaAtras.Name = "rbFechaAtras";
            this.rbFechaAtras.Size = new System.Drawing.Size(236, 20);
            this.rbFechaAtras.TabIndex = 3;
            this.rbFechaAtras.TabStop = true;
            this.rbFechaAtras.Text = "Antes de Cierta Fecha";
            this.rbFechaAtras.UseVisualStyleBackColor = true;
            this.rbFechaAtras.CheckedChanged += new System.EventHandler(this.CambioFiltro);
            // 
            // rbFechaAdelante
            // 
            this.rbFechaAdelante.AutoSize = true;
            this.rbFechaAdelante.Location = new System.Drawing.Point(419, 37);
            this.rbFechaAdelante.Name = "rbFechaAdelante";
            this.rbFechaAdelante.Size = new System.Drawing.Size(266, 20);
            this.rbFechaAdelante.TabIndex = 2;
            this.rbFechaAdelante.TabStop = true;
            this.rbFechaAdelante.Text = "A partir de Cierta Fecha";
            this.rbFechaAdelante.UseVisualStyleBackColor = true;
            this.rbFechaAdelante.CheckedChanged += new System.EventHandler(this.CambioFiltro);
            // 
            // rbFechaEsp
            // 
            this.rbFechaEsp.AutoSize = true;
            this.rbFechaEsp.Location = new System.Drawing.Point(16, 63);
            this.rbFechaEsp.Name = "rbFechaEsp";
            this.rbFechaEsp.Size = new System.Drawing.Size(186, 20);
            this.rbFechaEsp.TabIndex = 1;
            this.rbFechaEsp.TabStop = true;
            this.rbFechaEsp.Text = "Fecha Específica";
            this.rbFechaEsp.UseVisualStyleBackColor = true;
            this.rbFechaEsp.CheckedChanged += new System.EventHandler(this.CambioFiltro);
            // 
            // rbTodo
            // 
            this.rbTodo.AutoSize = true;
            this.rbTodo.Location = new System.Drawing.Point(16, 37);
            this.rbTodo.Name = "rbTodo";
            this.rbTodo.Size = new System.Drawing.Size(66, 20);
            this.rbTodo.TabIndex = 0;
            this.rbTodo.TabStop = true;
            this.rbTodo.Text = "Todo";
            this.rbTodo.UseVisualStyleBackColor = true;
            this.rbTodo.CheckedChanged += new System.EventHandler(this.CambioFiltro);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(515, 451);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 19;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToResizeColumns = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.White;
            this.dgvBitacora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(28, 198);
            this.dgvBitacora.MultiSelect = false;
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(1093, 244);
            this.dgvBitacora.TabIndex = 0;
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 513);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dgvBitacora);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitácora de Transacciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBitacora_FormClosing);
            this.Load += new System.EventHandler(this.FrmBitacora_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dgvBase dgvBitacora;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.RadioButton rbTabla;
        private System.Windows.Forms.RadioButton rbFechaAtras;
        private System.Windows.Forms.RadioButton rbFechaAdelante;
        private System.Windows.Forms.RadioButton rbFechaEsp;
        private System.Windows.Forms.RadioButton rbTodo;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.ComboBox cmbUsuario;

    }
}
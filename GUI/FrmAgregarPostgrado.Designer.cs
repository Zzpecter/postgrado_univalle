namespace GUI
{
    partial class FrmAgregarPostgrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarPostgrado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMateriasACursar = new GUI.dgvBase();
            this.bQuitarMateria = new System.Windows.Forms.Button();
            this.bAgregarMateria = new System.Windows.Forms.Button();
            this.bMateriaNueva = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMateriasDisponibles = new GUI.dgvBase();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRequisitosNecesarios = new GUI.dgvBase();
            this.bQuitarRequisito = new System.Windows.Forms.Button();
            this.bAgregarRequisito = new System.Windows.Forms.Button();
            this.bRequisitoNuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRequisitosDisponibles = new GUI.dgvBase();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasACursar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasDisponibles)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosNecesarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbArea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Location = new System.Drawing.Point(185, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Postgrado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Área:";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(502, 51);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(163, 24);
            this.cmbArea.TabIndex = 4;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Diplomado",
            "Maestría"});
            this.cmbTipo.Location = new System.Drawing.Point(136, 51);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(163, 24);
            this.cmbTipo.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(136, 22);
            this.tbNombre.MaxLength = 49;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(529, 23);
            this.tbNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvMateriasACursar);
            this.groupBox2.Controls.Add(this.bQuitarMateria);
            this.groupBox2.Controls.Add(this.bAgregarMateria);
            this.groupBox2.Controls.Add(this.bMateriaNueva);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvMateriasDisponibles);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1168, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Materias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Materias a Cursar";
            // 
            // dgvMateriasACursar
            // 
            this.dgvMateriasACursar.AllowUserToAddRows = false;
            this.dgvMateriasACursar.AllowUserToDeleteRows = false;
            this.dgvMateriasACursar.AllowUserToResizeColumns = false;
            this.dgvMateriasACursar.AllowUserToResizeRows = false;
            this.dgvMateriasACursar.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriasACursar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMateriasACursar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMateriasACursar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMateriasACursar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasACursar.Location = new System.Drawing.Point(651, 38);
            this.dgvMateriasACursar.MultiSelect = false;
            this.dgvMateriasACursar.Name = "dgvMateriasACursar";
            this.dgvMateriasACursar.ReadOnly = true;
            this.dgvMateriasACursar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasACursar.Size = new System.Drawing.Size(500, 159);
            this.dgvMateriasACursar.TabIndex = 15;
            // 
            // bQuitarMateria
            // 
            this.bQuitarMateria.Location = new System.Drawing.Point(527, 111);
            this.bQuitarMateria.Name = "bQuitarMateria";
            this.bQuitarMateria.Size = new System.Drawing.Size(118, 49);
            this.bQuitarMateria.TabIndex = 14;
            this.bQuitarMateria.Text = "<<";
            this.bQuitarMateria.UseVisualStyleBackColor = true;
            this.bQuitarMateria.Click += new System.EventHandler(this.bQuitarMateria_Click);
            // 
            // bAgregarMateria
            // 
            this.bAgregarMateria.Location = new System.Drawing.Point(527, 38);
            this.bAgregarMateria.Name = "bAgregarMateria";
            this.bAgregarMateria.Size = new System.Drawing.Size(118, 49);
            this.bAgregarMateria.TabIndex = 13;
            this.bAgregarMateria.Text = ">>";
            this.bAgregarMateria.UseVisualStyleBackColor = true;
            this.bAgregarMateria.Click += new System.EventHandler(this.bAgregarMateria_Click);
            // 
            // bMateriaNueva
            // 
            this.bMateriaNueva.Location = new System.Drawing.Point(218, 203);
            this.bMateriaNueva.Name = "bMateriaNueva";
            this.bMateriaNueva.Size = new System.Drawing.Size(118, 49);
            this.bMateriaNueva.TabIndex = 12;
            this.bMateriaNueva.Text = "Nueva";
            this.bMateriaNueva.UseVisualStyleBackColor = true;
            this.bMateriaNueva.Click += new System.EventHandler(this.bMateriaNueva_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Materias Disponibles";
            // 
            // dgvMateriasDisponibles
            // 
            this.dgvMateriasDisponibles.AllowUserToAddRows = false;
            this.dgvMateriasDisponibles.AllowUserToDeleteRows = false;
            this.dgvMateriasDisponibles.AllowUserToResizeColumns = false;
            this.dgvMateriasDisponibles.AllowUserToResizeRows = false;
            this.dgvMateriasDisponibles.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriasDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMateriasDisponibles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMateriasDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMateriasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasDisponibles.Location = new System.Drawing.Point(21, 38);
            this.dgvMateriasDisponibles.MultiSelect = false;
            this.dgvMateriasDisponibles.Name = "dgvMateriasDisponibles";
            this.dgvMateriasDisponibles.ReadOnly = true;
            this.dgvMateriasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasDisponibles.Size = new System.Drawing.Size(500, 159);
            this.dgvMateriasDisponibles.TabIndex = 0;
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(600, 641);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 11;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(483, 641);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 12;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dgvRequisitosNecesarios);
            this.groupBox3.Controls.Add(this.bQuitarRequisito);
            this.groupBox3.Controls.Add(this.bAgregarRequisito);
            this.groupBox3.Controls.Add(this.bRequisitoNuevo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dgvRequisitosDisponibles);
            this.groupBox3.Location = new System.Drawing.Point(12, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1168, 265);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Requisitos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Requisitos Necesarios";
            // 
            // dgvRequisitosNecesarios
            // 
            this.dgvRequisitosNecesarios.AllowUserToAddRows = false;
            this.dgvRequisitosNecesarios.AllowUserToDeleteRows = false;
            this.dgvRequisitosNecesarios.AllowUserToResizeColumns = false;
            this.dgvRequisitosNecesarios.AllowUserToResizeRows = false;
            this.dgvRequisitosNecesarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequisitosNecesarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRequisitosNecesarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRequisitosNecesarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvRequisitosNecesarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitosNecesarios.Location = new System.Drawing.Point(651, 39);
            this.dgvRequisitosNecesarios.MultiSelect = false;
            this.dgvRequisitosNecesarios.Name = "dgvRequisitosNecesarios";
            this.dgvRequisitosNecesarios.ReadOnly = true;
            this.dgvRequisitosNecesarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequisitosNecesarios.Size = new System.Drawing.Size(500, 159);
            this.dgvRequisitosNecesarios.TabIndex = 15;
            // 
            // bQuitarRequisito
            // 
            this.bQuitarRequisito.Location = new System.Drawing.Point(527, 131);
            this.bQuitarRequisito.Name = "bQuitarRequisito";
            this.bQuitarRequisito.Size = new System.Drawing.Size(118, 49);
            this.bQuitarRequisito.TabIndex = 14;
            this.bQuitarRequisito.Text = "<<";
            this.bQuitarRequisito.UseVisualStyleBackColor = true;
            this.bQuitarRequisito.Click += new System.EventHandler(this.bQuitarRequisito_Click);
            // 
            // bAgregarRequisito
            // 
            this.bAgregarRequisito.Location = new System.Drawing.Point(527, 58);
            this.bAgregarRequisito.Name = "bAgregarRequisito";
            this.bAgregarRequisito.Size = new System.Drawing.Size(118, 49);
            this.bAgregarRequisito.TabIndex = 13;
            this.bAgregarRequisito.Text = ">>";
            this.bAgregarRequisito.UseVisualStyleBackColor = true;
            this.bAgregarRequisito.Click += new System.EventHandler(this.bAgregarRequisito_Click);
            // 
            // bRequisitoNuevo
            // 
            this.bRequisitoNuevo.Location = new System.Drawing.Point(218, 204);
            this.bRequisitoNuevo.Name = "bRequisitoNuevo";
            this.bRequisitoNuevo.Size = new System.Drawing.Size(118, 49);
            this.bRequisitoNuevo.TabIndex = 12;
            this.bRequisitoNuevo.Text = "Nuevo";
            this.bRequisitoNuevo.UseVisualStyleBackColor = true;
            this.bRequisitoNuevo.Click += new System.EventHandler(this.bRequisitoNuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Requisitos Disponibles";
            // 
            // dgvRequisitosDisponibles
            // 
            this.dgvRequisitosDisponibles.AllowUserToAddRows = false;
            this.dgvRequisitosDisponibles.AllowUserToDeleteRows = false;
            this.dgvRequisitosDisponibles.AllowUserToResizeColumns = false;
            this.dgvRequisitosDisponibles.AllowUserToResizeRows = false;
            this.dgvRequisitosDisponibles.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequisitosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRequisitosDisponibles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvRequisitosDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvRequisitosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitosDisponibles.Location = new System.Drawing.Point(17, 39);
            this.dgvRequisitosDisponibles.MultiSelect = false;
            this.dgvRequisitosDisponibles.Name = "dgvRequisitosDisponibles";
            this.dgvRequisitosDisponibles.ReadOnly = true;
            this.dgvRequisitosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequisitosDisponibles.Size = new System.Drawing.Size(500, 159);
            this.dgvRequisitosDisponibles.TabIndex = 0;
            // 
            // FrmAgregarPostgrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 702);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarPostgrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nuevo Postgrado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAgregarPostgrado_FormClosing);
            this.Load += new System.EventHandler(this.FrmAgregarPostgrado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasACursar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasDisponibles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosNecesarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private dgvBase dgvMateriasDisponibles;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label label4;
        private dgvBase dgvMateriasACursar;
        private System.Windows.Forms.Button bQuitarMateria;
        private System.Windows.Forms.Button bAgregarMateria;
        private System.Windows.Forms.Button bMateriaNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private dgvBase dgvRequisitosNecesarios;
        private System.Windows.Forms.Button bQuitarRequisito;
        private System.Windows.Forms.Button bAgregarRequisito;
        private System.Windows.Forms.Button bRequisitoNuevo;
        private System.Windows.Forms.Label label6;
        private dgvBase dgvRequisitosDisponibles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbArea;
    }
}
namespace GUI
{
    partial class FrmNotificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificaciones));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNotificaciones = new GUI.dgvBase();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bNotificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.bNotificacionesGuardadas = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNotificaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notificaciones";
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.AllowUserToAddRows = false;
            this.dgvNotificaciones.AllowUserToDeleteRows = false;
            this.dgvNotificaciones.AllowUserToResizeColumns = false;
            this.dgvNotificaciones.AllowUserToResizeRows = false;
            this.dgvNotificaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotificaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNotificaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvNotificaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Location = new System.Drawing.Point(7, 23);
            this.dgvNotificaciones.MultiSelect = false;
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            this.dgvNotificaciones.ReadOnly = true;
            this.dgvNotificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotificaciones.Size = new System.Drawing.Size(340, 208);
            this.dgvNotificaciones.TabIndex = 0;
            this.dgvNotificaciones.SelectionChanged += new System.EventHandler(this.dgvNotificaciones_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bEliminar);
            this.groupBox2.Controls.Add(this.bVolver);
            this.groupBox2.Controls.Add(this.bGuardar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTipo);
            this.groupBox2.Controls.Add(this.tbDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(12, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
            // 
            // bEliminar
            // 
            this.bEliminar.BackgroundImage = global::GUI.Properties.Resources.imgEliminar;
            this.bEliminar.Location = new System.Drawing.Point(135, 167);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 50);
            this.bEliminar.TabIndex = 78;
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Visible = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(10, 167);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 77;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(258, 167);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 76;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(7, 122);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.ReadOnly = true;
            this.tbTipo.Size = new System.Drawing.Size(215, 23);
            this.tbTipo.TabIndex = 1;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(7, 23);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.Size = new System.Drawing.Size(340, 78);
            this.tbDescripcion.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bNotificaciones,
            this.bNotificacionesGuardadas});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.verToolStripMenuItem.Text = "Ver...";
            // 
            // bNotificaciones
            // 
            this.bNotificaciones.Enabled = false;
            this.bNotificaciones.Name = "bNotificaciones";
            this.bNotificaciones.Size = new System.Drawing.Size(212, 22);
            this.bNotificaciones.Text = "Notificaciones";
            this.bNotificaciones.Click += new System.EventHandler(this.bNotificaciones_Click);
            // 
            // bNotificacionesGuardadas
            // 
            this.bNotificacionesGuardadas.Name = "bNotificacionesGuardadas";
            this.bNotificacionesGuardadas.Size = new System.Drawing.Size(212, 22);
            this.bNotificacionesGuardadas.Text = "Notificaciones  Guardadas";
            this.bNotificacionesGuardadas.Click += new System.EventHandler(this.notificacionesGuardadasToolStripMenuItem1_Click);
            // 
            // FrmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmNotificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNotificaciones_FormClosing);
            this.Load += new System.EventHandler(this.FrmNotificaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvNotificaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bNotificaciones;
        private System.Windows.Forms.ToolStripMenuItem bNotificacionesGuardadas;
        private System.Windows.Forms.Button bEliminar;
    }
}
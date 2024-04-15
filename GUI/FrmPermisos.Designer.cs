namespace GUI
{
    partial class FrmPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermisos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHorarios = new System.Windows.Forms.CheckBox();
            this.cbTramites = new System.Windows.Forms.CheckBox();
            this.cbInscripciones = new System.Windows.Forms.CheckBox();
            this.cbOfertas = new System.Windows.Forms.CheckBox();
            this.cbPersonas = new System.Windows.Forms.CheckBox();
            this.cbPostgrados = new System.Windows.Forms.CheckBox();
            this.cbAbms = new System.Windows.Forms.CheckBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHorarios);
            this.groupBox1.Controls.Add(this.cbTramites);
            this.groupBox1.Controls.Add(this.cbInscripciones);
            this.groupBox1.Controls.Add(this.cbOfertas);
            this.groupBox1.Controls.Add(this.cbPersonas);
            this.groupBox1.Controls.Add(this.cbPostgrados);
            this.groupBox1.Controls.Add(this.cbAbms);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos a Usuario:";
            // 
            // cbHorarios
            // 
            this.cbHorarios.AutoSize = true;
            this.cbHorarios.Location = new System.Drawing.Point(218, 87);
            this.cbHorarios.Name = "cbHorarios";
            this.cbHorarios.Size = new System.Drawing.Size(107, 20);
            this.cbHorarios.TabIndex = 6;
            this.cbHorarios.Text = "Horarios";
            this.cbHorarios.UseVisualStyleBackColor = true;
            // 
            // cbTramites
            // 
            this.cbTramites.AutoSize = true;
            this.cbTramites.Location = new System.Drawing.Point(218, 61);
            this.cbTramites.Name = "cbTramites";
            this.cbTramites.Size = new System.Drawing.Size(107, 20);
            this.cbTramites.TabIndex = 5;
            this.cbTramites.Text = "Tramites";
            this.cbTramites.UseVisualStyleBackColor = false;
            // 
            // cbInscripciones
            // 
            this.cbInscripciones.AutoSize = true;
            this.cbInscripciones.Location = new System.Drawing.Point(218, 35);
            this.cbInscripciones.Name = "cbInscripciones";
            this.cbInscripciones.Size = new System.Drawing.Size(157, 20);
            this.cbInscripciones.TabIndex = 4;
            this.cbInscripciones.Text = "Inscripciones";
            this.cbInscripciones.UseVisualStyleBackColor = true;
            // 
            // cbOfertas
            // 
            this.cbOfertas.AutoSize = true;
            this.cbOfertas.Location = new System.Drawing.Point(18, 113);
            this.cbOfertas.Name = "cbOfertas";
            this.cbOfertas.Size = new System.Drawing.Size(97, 20);
            this.cbOfertas.TabIndex = 3;
            this.cbOfertas.Text = "Ofertas";
            this.cbOfertas.UseVisualStyleBackColor = true;
            // 
            // cbPersonas
            // 
            this.cbPersonas.AutoSize = true;
            this.cbPersonas.Location = new System.Drawing.Point(18, 87);
            this.cbPersonas.Name = "cbPersonas";
            this.cbPersonas.Size = new System.Drawing.Size(107, 20);
            this.cbPersonas.TabIndex = 2;
            this.cbPersonas.Text = "Personas";
            this.cbPersonas.UseVisualStyleBackColor = true;
            // 
            // cbPostgrados
            // 
            this.cbPostgrados.AutoSize = true;
            this.cbPostgrados.Location = new System.Drawing.Point(18, 61);
            this.cbPostgrados.Name = "cbPostgrados";
            this.cbPostgrados.Size = new System.Drawing.Size(127, 20);
            this.cbPostgrados.TabIndex = 1;
            this.cbPostgrados.Text = "Postgrados";
            this.cbPostgrados.UseVisualStyleBackColor = true;
            // 
            // cbAbms
            // 
            this.cbAbms.AutoSize = true;
            this.cbAbms.Location = new System.Drawing.Point(18, 35);
            this.cbAbms.Name = "cbAbms";
            this.cbAbms.Size = new System.Drawing.Size(157, 20);
            this.cbAbms.TabIndex = 0;
            this.cbAbms.Text = "ABM\'s Menores";
            this.cbAbms.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.BackgroundImage = global::GUI.Properties.Resources.imgCancelar;
            this.bCancelar.Location = new System.Drawing.Point(299, 165);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(100, 50);
            this.bCancelar.TabIndex = 71;
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(12, 165);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 70;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackgroundImage = global::GUI.Properties.Resources.imgGuardar;
            this.bGuardar.Location = new System.Drawing.Point(157, 165);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 50);
            this.bGuardar.TabIndex = 69;
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 227);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPermisos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPermisos_FormClosing);
            this.Load += new System.EventHandler(this.FrmPermisos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbOfertas;
        private System.Windows.Forms.CheckBox cbPersonas;
        private System.Windows.Forms.CheckBox cbPostgrados;
        private System.Windows.Forms.CheckBox cbAbms;
        private System.Windows.Forms.CheckBox cbHorarios;
        private System.Windows.Forms.CheckBox cbTramites;
        private System.Windows.Forms.CheckBox cbInscripciones;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
    }
}
﻿namespace GUI
{
    partial class FrmDocenteSeleccionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocenteSeleccionar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDocentes = new GUI.dgvBase();
            this.bVolver = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDocentes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 361);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Docentes:";
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AllowUserToResizeColumns = false;
            this.dgvDocentes.AllowUserToResizeRows = false;
            this.dgvDocentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDocentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDocentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(16, 32);
            this.dgvDocentes.MultiSelect = false;
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(400, 310);
            this.dgvDocentes.TabIndex = 0;
            this.dgvDocentes.SelectionChanged += new System.EventHandler(this.dgvDocentes_SelectionChanged);
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(12, 399);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 20;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bEditar
            // 
            this.bEditar.BackgroundImage = global::GUI.Properties.Resources.imgEspecialidades;
            this.bEditar.Location = new System.Drawing.Point(248, 379);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(195, 70);
            this.bEditar.TabIndex = 2;
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // FrmDocenteSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 456);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDocenteSeleccionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDocenteSeleccionar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDocenteSeleccionar_FormClosing);
            this.Load += new System.EventHandler(this.FrmDocenteSeleccionar_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private dgvBase dgvDocentes;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bVolver;
    }
}
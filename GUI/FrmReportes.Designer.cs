namespace GUI
{
    partial class FrmReportes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.PaReporteAlumnosPostgradoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtoReportes = new GUI.DtoReportes();
            this.rvReportes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbAño = new System.Windows.Forms.NumericUpDown();
            this.lblAño = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.PaReporteDocentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaReporteMateriaNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaReporteAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaReporteAlumnosTableAdapter = new GUI.DtoReportesTableAdapters.PaReporteAlumnosTableAdapter();
            this.PaReporteMateriaNotasTableAdapter = new GUI.DtoReportesTableAdapters.PaReporteMateriaNotasTableAdapter();
            this.PaReporteDocentesTableAdapter = new GUI.DtoReportesTableAdapters.PaReporteDocentesTableAdapter();
            this.PaReporteAlumnosPostgradoTableAdapter = new GUI.DtoReportesTableAdapters.PaReporteAlumnosPostgradoTableAdapter();
            this.rvReportes2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvReportes3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvReportes4 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteAlumnosPostgradoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtoReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteDocentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteMateriaNotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteAlumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PaReporteAlumnosPostgradoBindingSource
            // 
            this.PaReporteAlumnosPostgradoBindingSource.DataMember = "PaReporteAlumnosPostgrado";
            this.PaReporteAlumnosPostgradoBindingSource.DataSource = this.DtoReportes;
            // 
            // DtoReportes
            // 
            this.DtoReportes.DataSetName = "DtoReportes";
            this.DtoReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvReportes
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PaReporteAlumnosBindingSource;
            this.rvReportes.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReportes.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.rvReportes.Location = new System.Drawing.Point(12, 72);
            this.rvReportes.Name = "rvReportes";
            this.rvReportes.Size = new System.Drawing.Size(854, 246);
            this.rvReportes.TabIndex = 0;
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(216, 34);
            this.tbAño.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.tbAño.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(120, 23);
            this.tbAño.TabIndex = 1;
            this.tbAño.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.tbAño.ValueChanged += new System.EventHandler(this.tbAño_ValueChanged);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(12, 36);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(198, 16);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año de Inscripción:";
            // 
            // bVolver
            // 
            this.bVolver.BackgroundImage = global::GUI.Properties.Resources.imgVolver2;
            this.bVolver.Location = new System.Drawing.Point(12, 324);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(100, 50);
            this.bVolver.TabIndex = 95;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // PaReporteDocentesBindingSource
            // 
            this.PaReporteDocentesBindingSource.DataMember = "PaReporteDocentes";
            this.PaReporteDocentesBindingSource.DataSource = this.DtoReportes;
            // 
            // PaReporteMateriaNotasBindingSource
            // 
            this.PaReporteMateriaNotasBindingSource.DataMember = "PaReporteMateriaNotas";
            this.PaReporteMateriaNotasBindingSource.DataSource = this.DtoReportes;
            // 
            // PaReporteAlumnosBindingSource
            // 
            this.PaReporteAlumnosBindingSource.DataMember = "PaReporteAlumnos";
            this.PaReporteAlumnosBindingSource.DataSource = this.DtoReportes;
            // 
            // PaReporteAlumnosTableAdapter
            // 
            this.PaReporteAlumnosTableAdapter.ClearBeforeFill = true;
            // 
            // PaReporteMateriaNotasTableAdapter
            // 
            this.PaReporteMateriaNotasTableAdapter.ClearBeforeFill = true;
            // 
            // PaReporteDocentesTableAdapter
            // 
            this.PaReporteDocentesTableAdapter.ClearBeforeFill = true;
            // 
            // PaReporteAlumnosPostgradoTableAdapter
            // 
            this.PaReporteAlumnosPostgradoTableAdapter.ClearBeforeFill = true;
            // 
            // rvReportes2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PaReporteMateriaNotasBindingSource;
            this.rvReportes2.LocalReport.DataSources.Add(reportDataSource2);
            this.rvReportes2.LocalReport.ReportEmbeddedResource = "GUI.Report2.rdlc";
            this.rvReportes2.Location = new System.Drawing.Point(15, 21);
            this.rvReportes2.Name = "rvReportes2";
            this.rvReportes2.Size = new System.Drawing.Size(854, 246);
            this.rvReportes2.TabIndex = 96;
            // 
            // rvReportes3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.PaReporteDocentesBindingSource;
            this.rvReportes3.LocalReport.DataSources.Add(reportDataSource3);
            this.rvReportes3.LocalReport.ReportEmbeddedResource = "GUI.Report3.rdlc";
            this.rvReportes3.Location = new System.Drawing.Point(15, 21);
            this.rvReportes3.Name = "rvReportes3";
            this.rvReportes3.Size = new System.Drawing.Size(854, 246);
            this.rvReportes3.TabIndex = 97;
            // 
            // rvReportes4
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.PaReporteAlumnosPostgradoBindingSource;
            this.rvReportes4.LocalReport.DataSources.Add(reportDataSource4);
            this.rvReportes4.LocalReport.ReportEmbeddedResource = "GUI.Report4.rdlc";
            this.rvReportes4.Location = new System.Drawing.Point(15, 21);
            this.rvReportes4.Name = "rvReportes4";
            this.rvReportes4.Size = new System.Drawing.Size(854, 246);
            this.rvReportes4.TabIndex = 98;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 377);
            this.Controls.Add(this.rvReportes4);
            this.Controls.Add(this.rvReportes3);
            this.Controls.Add(this.rvReportes2);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.rvReportes);
            this.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReportes_FormClosing);
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteAlumnosPostgradoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtoReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteDocentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteMateriaNotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaReporteAlumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReportes;
        private System.Windows.Forms.NumericUpDown tbAño;
        private DtoReportes DtoReportes;
        private System.Windows.Forms.BindingSource PaReporteAlumnosBindingSource;
        private DtoReportesTableAdapters.PaReporteAlumnosTableAdapter PaReporteAlumnosTableAdapter;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.BindingSource PaReporteMateriaNotasBindingSource;
        private DtoReportesTableAdapters.PaReporteMateriaNotasTableAdapter PaReporteMateriaNotasTableAdapter;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.BindingSource PaReporteDocentesBindingSource;
        private DtoReportesTableAdapters.PaReporteDocentesTableAdapter PaReporteDocentesTableAdapter;
        private System.Windows.Forms.BindingSource PaReporteAlumnosPostgradoBindingSource;
        private DtoReportesTableAdapters.PaReporteAlumnosPostgradoTableAdapter PaReporteAlumnosPostgradoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvReportes2;
        private Microsoft.Reporting.WinForms.ReportViewer rvReportes3;
        private Microsoft.Reporting.WinForms.ReportViewer rvReportes4;
    }
}
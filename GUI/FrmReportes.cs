using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class FrmReportes : Form
    {
        private BLL.Reportes reportes = new BLL.Reportes();
        private DataTable dtReportes = new DataTable();
        private DateTime fInf, fSup;
        private int n = 0;

        public FrmReportes()
        {
            InitializeComponent();
        }

        public FrmReportes(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void CargarInscripciones()
        {
            rvReportes2.Visible = false;
            rvReportes3.Visible = false;
            rvReportes4.Visible = false;
            // TODO: This line of code loads data into the 'DtoReportes.PaReporteAlumnos' table. You can move, or remove it, as needed.
            fInf = DateTime.ParseExact((tbAño.Value.ToString() + "-01-01"), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            fSup = DateTime.ParseExact((tbAño.Value.ToString() + "-12-31"), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

            this.PaReporteAlumnosTableAdapter.Fill(this.DtoReportes.PaReporteAlumnos, fInf, fSup);
            this.rvReportes.RefreshReport();
        }

        private void CargarMateriaNotas()
        {
            rvReportes.Visible = false;
            rvReportes3.Visible = false;
            rvReportes4.Visible = false;
            tbAño.Visible = false;
            lblAño.Visible = false;
            this.PaReporteMateriaNotasTableAdapter.Fill(this.DtoReportes.PaReporteMateriaNotas);
            this.rvReportes2.RefreshReport();
        }

        private void CargarDocentes()
        {
            rvReportes.Visible = false;
            rvReportes2.Visible = false;
            rvReportes4.Visible = false;
            tbAño.Visible = false;
            lblAño.Visible = false;
            this.PaReporteDocentesTableAdapter.Fill(this.DtoReportes.PaReporteDocentes);
            this.rvReportes3.RefreshReport();
        }

        private void CargarAlumnosPostgrado()
        {
            rvReportes.Visible = false;
            rvReportes2.Visible = false;
            rvReportes3.Visible = false;
            tbAño.Visible = false;
            lblAño.Visible = false;
            this.PaReporteAlumnosPostgradoTableAdapter.Fill(this.DtoReportes.PaReporteAlumnosPostgrado);
            this.rvReportes4.RefreshReport();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            if (n.Equals(1))
            {
                CargarInscripciones();
            }
            else if (n.Equals(2))
            {
                CargarMateriaNotas();
            }
            else if (n.Equals(3))
            {
                CargarDocentes();
            }
            else if (n.Equals(4))
            {
                CargarAlumnosPostgrado();
            }
        }

        private void tbAño_ValueChanged(object sender, EventArgs e)
        {
            fInf = DateTime.ParseExact((tbAño.Value.ToString() + "-01-01"), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            fSup = DateTime.ParseExact((tbAño.Value.ToString() + "-12-31"), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

            this.PaReporteAlumnosTableAdapter.Fill(this.DtoReportes.PaReporteAlumnos, fInf, fSup);
            this.rvReportes.RefreshReport();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void FrmReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

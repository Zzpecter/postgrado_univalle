using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConexion : Form
    {
        public FrmConexion()
        {
            InitializeComponent();
            tbPuerto.Text = "1433";
        }

        private void ControlTB(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ControlRB(object sender, EventArgs e)
        {
            tbIP1.Visible = rbIP.Checked;
            tbIP2.Visible = rbIP.Checked;
            tbIP3.Visible = rbIP.Checked;
            tbIP4.Visible = rbIP.Checked;
            tbPuerto.Visible = rbIP.Checked;

            lbl1.Visible = rbIP.Checked;
            lbl2.Visible = rbIP.Checked;
            lbl3.Visible = rbIP.Checked;
            lbl4.Visible = rbIP.Checked;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            FrmAutenticacion frm = new FrmAutenticacion();
            frm.Show();
            this.Hide();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (rbIP.Checked)
            {
                string cad = string.Empty;
                cad = tbIP1.Text + "." + tbIP2.Text + "." + tbIP3.Text + "." + tbIP4.Text + "," + tbPuerto.Text;
                BLL.CadenaConexion.Setear(cad);
            }
            else
                BLL.CadenaConexion.SetearLocal();

            FrmAutenticacion frm = new FrmAutenticacion();
            frm.Show();
            this.Hide();
        }

        private void FrmConexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FrmBitacora : Form
    {
        #region Variables
        private BLL.Bitacora bit = new BLL.Bitacora();
        private BLL.Usuario usr = new BLL.Usuario();
        private DataTable dtBitacora = new DataTable();
        private DataTable dtUsuario = new DataTable();
        private string filtro = string.Empty;
        #endregion

        #region Carga
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Carga los Datatables
            dtUsuario = usr.TablaCompletaUsuario();
            dtBitacora = bit.ListarCompleto();

            //Llena el Combo
            for (int i = 0; i < dtUsuario.Rows.Count; ++i)
                cmbUsuario.Items.Add(dtUsuario.Rows[i].ItemArray[5].ToString());

            rbTodo.Checked = true;
        }

        private void FormatearGrid()
        {
            dgvBitacora.Columns[0].Width = 220;
            dgvBitacora.Columns[2].Width = 180;
            dgvBitacora.Columns[3].Width = 150;
            dgvBitacora.Columns[4].Width = 130;
            dgvBitacora.Columns[5].Width = 140;
            dgvBitacora.Columns[6].Width = 140;
        }
        #endregion

        #region Botones y Métodos
        private void CambioFiltro(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            if (ctrl.GetType() == typeof(RadioButton))
                filtro = ((RadioButton)ctrl).Name;

            switch (filtro)
            {
                case "rbTodo":
                    {
                        //Oculta los controles innecesarios
                        dtpFecha.Visible = false;
                        cmbTabla.Visible = false;
                        cmbUsuario.Visible = false;

                        dtBitacora = bit.ListarCompleto();
                        dgvBitacora.DataSource = null;
                        dgvBitacora.DataSource = dtBitacora;
                        dgvBitacora.Refresh();
                        FormatearGrid();
                    } break;
                case "rbFechaEsp":
                    {
                        //Oculta los controles innecesarios
                        dtpFecha.Visible = true;
                        cmbTabla.Visible = false;
                        cmbUsuario.Visible = false;
                        dtpFecha.Value = DateTime.Now;
                    }break;
                case "rbFechaAdelante":
                    {
                        //Oculta los controles innecesarios
                        dtpFecha.Visible = true;
                        cmbTabla.Visible = false;
                        cmbUsuario.Visible = false;
                        dtpFecha.Value = DateTime.Now;
                    } break;
                case "rbFechaAtras":
                    {
                        //Oculta los controles innecesarios
                        dtpFecha.Visible = true;
                        cmbTabla.Visible = false;
                        cmbUsuario.Visible = false;
                        dtpFecha.Value = DateTime.Now;
                    } break;
                case "rbTabla":
                    {
                        //Oculta los controles innecesarios
                        dtpFecha.Visible = false;
                        cmbTabla.Visible = true;
                        cmbUsuario.Visible = false;
                        cmbTabla.SelectedIndex = 0;
                    } break;
                case "rbUsuario":
                    {
                        //Oculta los controles innecesarios
                        dtpFecha.Visible = false;
                        cmbTabla.Visible = false;
                        cmbUsuario.Visible = true;
                        cmbUsuario.SelectedIndex = 0;
                    } break;
                default: break;
            }
        }

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            bit.Tabla = cmbTabla.SelectedItem.ToString();
            dtBitacora = bit.ListarTabla();
            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = dtBitacora;
            dgvBitacora.Refresh();
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            bit.Usuario = cmbUsuario.SelectedItem.ToString();
            dtBitacora = bit.ListarUsuario();
            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = dtBitacora;
            dgvBitacora.Refresh();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            bit.Fecha = dtpFecha.Value;

            if (rbFechaEsp.Checked.Equals(true))
                dtBitacora = bit.ListarFecha(dtpFecha.Value, dtpFecha.Value.AddDays(1));
            else if (rbFechaAdelante.Checked.Equals(true))
                dtBitacora = bit.ListarFechaUP();
            else if (rbFechaAtras.Checked.Equals(true))
                dtBitacora = bit.ListarFechaDN();

            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = dtBitacora;
            dgvBitacora.Refresh();
        }

        private void FrmBitacora_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }
        #endregion
    }
}

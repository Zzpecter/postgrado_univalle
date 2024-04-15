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
    public partial class FrmDocenteSeleccionar : Form
    {
        #region Variables
        private BLL.Docente docente = new BLL.Docente();

        private DataTable dtDocente = new DataTable();

        private bool cargado = false;
        private int idDocente = 0;
        int index = 0;
        #endregion

        #region Carga
        public FrmDocenteSeleccionar()
        {
            InitializeComponent();
        }

        private void FrmDocenteSeleccionar_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvDocentes.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void Cargar()
        {
            //Carga los datos
            dtDocente = docente.Listar();
            dgvDocentes.DataSource = null;
            dgvDocentes.DataSource = dtDocente;

            //Da formato al grid
            dgvDocentes.Columns.Remove("idPersona");
            dgvDocentes.Columns.Remove("idDocente");
            dgvDocentes.Columns.Remove("numDocumento");
            dgvDocentes.Columns.Remove("tipoDocumento");
            dgvDocentes.Columns.Remove("correo");
            dgvDocentes.Columns.Remove("direccion");
            dgvDocentes.Columns.Remove("nacionalidad");

            dgvDocentes.Columns[0].HeaderText = "Nombres";
            dgvDocentes.Columns[1].HeaderText = "Apellidos";

            dgvDocentes.Columns[0].Width = 175;
            dgvDocentes.Columns[1].Width = 175;

            dgvDocentes.ClearSelection();
            DeshabilitarOrdenamiento();
            cargado = true;
        }
        #endregion

        #region Botones

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.SelectedRows.Count == 1)
            {
                FrmEspecialidades frm = new FrmEspecialidades(idDocente);
                frm.Show();
                this.Hide();
            }
        }
        #endregion

        #region Otros Métodos
        private void FrmDocenteSeleccionar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvDocentes.SelectedRows[0].Index;
                idDocente = Convert.ToInt32(dtDocente.Rows[index].ItemArray[1].ToString());
            }
        }
        #endregion
    }
}

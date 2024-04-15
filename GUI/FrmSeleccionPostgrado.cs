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
    public partial class FrmSeleccionPostgrado : Form
    {
        #region Variables
        private BLL.Postgrado postgrado = new BLL.Postgrado();
        private BLL.Alumno alumno = new BLL.Alumno();

        private DataTable dtPostgrado = new DataTable();
        private DataTable dtAlumno = new DataTable();

        private bool cargado = false;
        private int idAlumno = 0;
        private int idPostgrado = 0;
        #endregion

        #region Carga
        public FrmSeleccionPostgrado()
        {
            InitializeComponent();
        }

        private void FrmSeleccionPostgrado_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Llena el grid de postgrados
            dtPostgrado = postgrado.Listar();
            dgvPostgrados.DataSource = null;
            dgvPostgrados.DataSource = dtPostgrado;

            //Elimina y redimensiona
            dgvPostgrados.Columns.Remove("idPostgrado");
            dgvPostgrados.Columns.Remove("tipoPostgrado");

            dgvPostgrados.Columns[0].Width = 300;
            dgvPostgrados.Refresh();

            dgvPostgrados.Rows[0].Selected = true;
            dgvPostgrados.Rows[0].Selected = false;

            DeshabilitarOrdenamiento();

            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvAlumnos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvPostgrados.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void CargarAlumnos()
        {
            //Carga el datagrid
            dtAlumno = postgrado.SeleccionarPostgrado();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = dtAlumno;

            //Quita las columnas innecesarias y redimensiona el ancho
            dgvAlumnos.Columns.Remove("idAlumno");
            dgvAlumnos.Columns.Remove("idPostgrado");
            dgvAlumnos.Columns.Remove("idAlumnoPostgrado");

            dgvAlumnos.Columns[0].Width = 150;
            dgvAlumnos.Columns[1].Width = 150;

            dgvAlumnos.Refresh();
        }
        #endregion

        #region Datagrids
        private void dgvPostgrados_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                idPostgrado = Convert.ToInt32(dtPostgrado.Rows[dgvPostgrados.SelectedRows[0].Index].ItemArray[0].ToString());
                postgrado.IdPostgrado = idPostgrado;
                cargado = false;
                CargarAlumnos();
                cargado = true;
            }
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado && dgvAlumnos.Rows.Count > 0)
                idAlumno = Convert.ToInt32(dtAlumno.Rows[dgvAlumnos.SelectedRows[0].Index].ItemArray[0].ToString());
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
            FrmNotas frm = new FrmNotas(idAlumno, idPostgrado);
            frm.Show();
            this.Hide();
        }
        #endregion

        private void FrmSeleccionPostgrado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

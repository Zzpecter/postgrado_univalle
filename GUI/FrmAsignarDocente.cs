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
    public partial class FrmAsignarDocente : Form
    {
        #region Variables
        private BLL.Materias materias = new BLL.Materias();
        private BLL.MateriaPostgrado materiaPostgrado = new BLL.MateriaPostgrado();
        private BLL.Docente docente = new BLL.Docente();

        private DataTable dtMaterias = new DataTable();
        private DataTable dtDocentes = new DataTable();

        private bool cargado = false;
        private int idDocente = 0;
        private int idMateria = 0;
        private int idPostgrado = 0;
        private int idMateriaPostgrado = 0;
        int index = 0;
        #endregion

        #region Carga
        public FrmAsignarDocente()
        {
            InitializeComponent();
        }

        private void FrmAsignarDocente_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Llena el datagrid de materias sin docente
            dtMaterias = materias.ListarSinDocente();
            dgvMaterias.DataSource = null;
            dgvMaterias.DataSource = dtMaterias;

            dgvDocentes.Enabled = false;

            //Da formato al grid
            dgvMaterias.Columns.Remove("idDocente");
            dgvMaterias.Columns.Remove("idMateria");
            dgvMaterias.Columns.Remove("idPostgrado");
            dgvMaterias.Columns.Remove("idMateriaPostgrado");
            dgvMaterias.Columns[0].Width = 300;

            dgvMaterias.ClearSelection();

            //Carga todos los docentes
            dtDocentes = docente.Listar();
            dgvDocentes.DataSource = null;
            dgvDocentes.DataSource = dtDocentes;

            //Da formato al grid
            dgvDocentes.Columns.Remove("idDocente");
            dgvDocentes.Columns.Remove("idPersona");
            dgvDocentes.Columns.Remove("numDocumento");
            dgvDocentes.Columns.Remove("tipoDocumento");
            dgvDocentes.Columns.Remove("correo");
            dgvDocentes.Columns.Remove("direccion");
            dgvDocentes.Columns.Remove("nacionalidad");
            dgvDocentes.Columns[0].Width = 150;
            dgvDocentes.Columns[1].Width = 150;

            dgvDocentes.ClearSelection();
            dgvDocentes.Enabled = false;

            DeshabilitarOrdenamiento();
            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvDocentes.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvMaterias.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion 

        #region Botones
        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            dgvDocentes.Enabled = false;
            bGuardar.Visible = false;
            bCancelar.Visible = false;
            cargado = false;
            dgvMaterias.ClearSelection();
            dgvDocentes.ClearSelection();
            cargado = true;
        }

        private void dgvMaterias_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Recupera el id de la materia
                index = dgvMaterias.SelectedRows[0].Index;
                idMateriaPostgrado = Convert.ToInt32(dtMaterias.Rows[index].ItemArray[1].ToString());
                idMateria = Convert.ToInt32(dtMaterias.Rows[index].ItemArray[0].ToString());
                idPostgrado = Convert.ToInt32(dtMaterias.Rows[index].ItemArray[4].ToString());
                dgvDocentes.Enabled = true;
                bGuardar.Visible = true;
                bCancelar.Visible = true;
            }
        }

        private void dgvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Recupera el id del docente
                index = dgvDocentes.SelectedRows[0].Index;
                idDocente = Convert.ToInt32(dtDocentes.Rows[index].ItemArray[1].ToString());

                bGuardar.Enabled = true;
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            materiaPostgrado.IdMateriaPostgrado = idMateriaPostgrado;
            materiaPostgrado.IdMateria = idMateria;
            materiaPostgrado.IdDocente = idDocente;
            materiaPostgrado.IdPostgrado = idPostgrado;

            materiaPostgrado.Actualizar();
            cargado = false;
            Cargar();
        }
        #endregion

        private void FrmAsignarDocente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

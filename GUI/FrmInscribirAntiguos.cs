using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Hacer un filtro para alumnos
namespace GUI
{
    public partial class FrmInscribirAntiguos : Form
    {
        #region Variables
        private BLL.Postgrado postgrado = new BLL.Postgrado();
        private BLL.Alumno alumno = new BLL.Alumno();
        private BLL.AlumnoPostgrado alumnoPostgrado = new BLL.AlumnoPostgrado();

        private DataTable dtPostgrado = new DataTable();
        private DataTable dtPostgradoTotal = new DataTable();
        private DataTable dtAlumno = new DataTable();

        private bool cargado = false;
        private int idAlumno = 0;
        private int idPostgrado = 0;
        #endregion

        #region Carga
        public FrmInscribirAntiguos()
        {
            InitializeComponent();
        }

        private void FrmInscribirAntiguos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Llena el grid de alumnos
            dtAlumno = alumno.Listar();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = dtAlumno;

            //Elimina y redimensiona
            dgvAlumnos.Columns.Remove("idPersona");
            dgvAlumnos.Columns.Remove("idAlumno");
            dgvAlumnos.Columns.Remove("correo");
            dgvAlumnos.Columns.Remove("direccion");
            dgvAlumnos.Columns.Remove("tipoDocumento");
            dgvAlumnos.Columns.Remove("numeroDocumento");
            dgvAlumnos.Columns.Remove("nacionalidad");

            dgvAlumnos.Columns[0].Width = 150;
            dgvAlumnos.Columns[1].Width = 150;

            dgvAlumnos.Refresh();

            dgvAlumnos.ClearSelection();
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

        private void CargarPostgrados()
        {
            //Carga el datagrid
            dtPostgrado = postgrado.Seleccionar(idAlumno);
            dgvPostgrados.DataSource = null;
            dgvPostgrados.DataSource = dtPostgrado;

            //Quita las columnas innecesarias y redimensiona el ancho
            dgvPostgrados.Columns.Remove("idAlumno");
            dgvPostgrados.Columns.Remove("idPostgrado");
            dgvPostgrados.Columns.Remove("tipoPostgrado");
            dgvPostgrados.Columns[0].Width = 300;
            dgvPostgrados.Columns[0].HeaderText = "Postgrado";

            //Carga todos los postgrados y agrega solo los que el alumno no lleva al combo
            dtPostgradoTotal = postgrado.Listar();
            cmbPostgrados.Items.Clear();
            bool repetido = false;
            foreach (DataRow dr in dtPostgradoTotal.Rows)
            {
                foreach (DataGridViewRow dgr in dgvPostgrados.Rows)
                {
                    if (dr.ItemArray[1].ToString().Equals(dgr.Cells[0].ToString()))
                        repetido = true;
                }
                if (!repetido)
                    cmbPostgrados.Items.Add(dr.ItemArray[1].ToString());
            }

            if (cmbPostgrados.Items.Count > 0)
                cmbPostgrados.SelectedIndex = 0;

        }
        #endregion

        #region Datagrid y Combobox
        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                idAlumno = Convert.ToInt32(dtAlumno.Rows[dgvAlumnos.SelectedRows[0].Index].ItemArray[1].ToString());
                CargarPostgrados();
            }
        }

        private void cmbPostgrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Recupera el id del postgrado
            foreach (DataRow dr in dtPostgradoTotal.Rows)
            {
                if (dr.ItemArray[1].ToString().Equals(cmbPostgrados.SelectedItem.ToString()))
                    idPostgrado = Convert.ToInt32(dr.ItemArray[0].ToString());
            }
        }
        #endregion

        #region Botones
        private void bAgregar_Click(object sender, EventArgs e)
        {
            //Activa los controles para agregar un nuevo
            lblPostgrados.Visible = true;
            cmbPostgrados.Visible = true;
            bGuardar.Visible = true;
            bCancelar.Visible = true;

            //Deshabilita el datagrid de alumnos para evitar errores
            dgvAlumnos.Enabled = false;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            //esconde los controles para agregar un nuevo
            lblPostgrados.Visible = false;
            cmbPostgrados.Visible = false;
            bGuardar.Visible = false;
            bCancelar.Visible = false;

            //habilita el datagrid de alumnos
            dgvAlumnos.Enabled = true;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            //Guarda en la base de datos
            alumnoPostgrado.IdAlumno = idAlumno;
            alumnoPostgrado.IdPostgrado = idPostgrado;

            alumnoPostgrado.Insertar();

            //esconde los controles para agregar un nuevo
            lblPostgrados.Visible = false;
            cmbPostgrados.Visible = false;
            bGuardar.Visible = false;
            bCancelar.Visible = false;

            //habilita el datagrid de alumnos
            dgvAlumnos.Enabled = true;

            CargarPostgrados();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }
        #endregion

        private void FrmInscribirAntiguos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

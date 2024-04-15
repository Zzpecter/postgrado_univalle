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
    public partial class FrmEspecialidades : Form
    {
        #region Variables
        private BLL.Especialidad especialidad = new BLL.Especialidad();
        private BLL.DocenteEspecialidad docenteEspecialidad = new BLL.DocenteEspecialidad();

        private DataTable dtEspecialidadD = new DataTable();
        private DataTable dtEspecialidadU = new DataTable();
        private DataTable dtAuxiliar = new DataTable();

        private int idDocente = 0;
        private int idEspecialidad = 0;
        private int idEspecialidad2 = 0;
        private int index = 0;
        private int index2 = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private List<int> ids = new List<int>();
        #endregion

        #region Carga
        public FrmEspecialidades(int idDocente)
        {
            InitializeComponent();
            this.idDocente = idDocente;
        }

        private void FrmEspecialidades_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            ids.Clear();

            //Carga las especialidades Disponibles
            dtEspecialidadD = especialidad.ListarABM();
            dtEspecialidadU = especialidad.ListarABM();
            dtEspecialidadU.Clear();

            //Carga las especialidades del docente seleccionado
            especialidad.IdDocente = idDocente;
            dtAuxiliar = especialidad.Seleccionar();

            //Se lista los ids de las especialidades del docente
            foreach (DataRow dtr in dtAuxiliar.Rows)
                ids.Add(Convert.ToInt32(dtr.ItemArray[2].ToString()));

            //Se comprueba que ID's estan siendo utilizados de las especialidades y se los pasa
            //Al otro datatable
            foreach (int id in ids)
                foreach (DataRow dtr in dtEspecialidadD.Rows)
                    if (dtr.ItemArray[0].ToString().Equals(id.ToString()))
                    {
                        dtEspecialidadU.Rows.Add(dtr.ItemArray);
                        dtEspecialidadD.Rows.Remove(dtr);
                        break;
                    }

            //Se muestra los datos en el Datagrid
            dgvEspecialidadesD.DataSource = null;
            dgvEspecialidadesD.DataSource = dtEspecialidadD;
            dgvEspecialidadesU.DataSource = null;
            dgvEspecialidadesU.DataSource = dtEspecialidadU;

            //Se da formato a los datagrids
            dgvEspecialidadesD.Columns.Remove("idEspecialidad");
            dgvEspecialidadesD.Columns.Remove("idAreaEspecialidad");
            dgvEspecialidadesU.Columns.Remove("idEspecialidad");
            dgvEspecialidadesU.Columns.Remove("idAreaEspecialidad");

            dgvEspecialidadesD.Columns[0].Width = 150;
            dgvEspecialidadesD.Columns[1].Width = 150;
            dgvEspecialidadesU.Columns[0].Width = 150;
            dgvEspecialidadesU.Columns[1].Width = 150;

            dgvEspecialidadesD.Columns[0].HeaderText = "Especialidad";
            dgvEspecialidadesD.Columns[1].HeaderText = "Area";
            dgvEspecialidadesU.Columns[0].HeaderText = "Especialidad";
            dgvEspecialidadesU.Columns[1].HeaderText = "Area";

            dgvEspecialidadesD.ClearSelection();
            dgvEspecialidadesU.ClearSelection();

            DeshabilitarOrdenamiento();

            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvEspecialidadesD.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvEspecialidadesU.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion

        #region Botones
        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmDocenteSeleccionar frm = new FrmDocenteSeleccionar();
            frm.Show();
            this.Hide();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidadesD.SelectedRows.Count == 1)
            {
                docenteEspecialidad.IdDocente = idDocente;
                docenteEspecialidad.IdEspecialidad = idEspecialidad;
                docenteEspecialidad.Insertar();

                cargado = false;
                Cargar();
            }
        }

        private void bQuitar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidadesU.SelectedRows.Count == 1)
            {
                docenteEspecialidad.IdDocente = idDocente;
                docenteEspecialidad.IdEspecialidad = idEspecialidad;
                docenteEspecialidad.Eliminar();

                cargado = false;
                Cargar();
            }
        }
        #endregion

        #region Otros Métodos
        private void FrmEspecialidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvEspecialidadesD_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvEspecialidadesD.SelectedRows[0].Index;
                idEspecialidad = Convert.ToInt32(dtEspecialidadD.Rows[index].ItemArray[0].ToString());
            }
        }

        private void dgvEspecialidadesU_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index2 = dgvEspecialidadesU.SelectedRows[0].Index;
                idEspecialidad2 = Convert.ToInt32(dtEspecialidadU.Rows[index2].ItemArray[0].ToString());
            }
        }
        #endregion
    }
}

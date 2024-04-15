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
    public partial class FrmTramites : Form
    {
        #region Variables
        private DataTable dtTramites = new DataTable();
        private DataTable dtEstado = new DataTable();

        private BLL.Tramite tramite = new BLL.Tramite();
        private BLL.EstadoTramite estado = new BLL.EstadoTramite();

        private bool cargado = false;
        private int idTramite = 0;
        private int idEstadoTramite = 0;
        private int idEgresado = 0;
        #endregion

        #region Carga
        public FrmTramites()
        {
            InitializeComponent();
        }

        private void FrmTramites_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Llena el datagrid
            dtTramites = tramite.Listar();
            dgvTramites.DataSource = null;
            dgvTramites.DataSource = dtTramites;

            //Llena el combobox
            dtEstado = estado.Listar();
            cmbEstado.Items.Clear();
            foreach (DataRow r in dtEstado.Rows)
                cmbEstado.Items.Add(r.ItemArray[1].ToString());

            //Elimina las columnas excedentes y ajusta el tamaño
            dgvTramites.Columns.Remove("idPersona");
            dgvTramites.Columns.Remove("idAlumno");
            dgvTramites.Columns.Remove("idEgresado");
            dgvTramites.Columns.Remove("estado");
            dgvTramites.Columns.Remove("comentario");
            dgvTramites.Columns.Remove("idTramite");
            dgvTramites.Columns.Remove("idEstadoTramite");

            dgvTramites.Columns[0].HeaderText = "Nombres";
            dgvTramites.Columns[1].HeaderText = "Apellidos";
            dgvTramites.Columns[2].HeaderText = "Postgrado";

            dgvTramites.Columns[0].Width = 150;
            dgvTramites.Columns[1].Width = 150;
            dgvTramites.Columns[2].Width = 200;

            dgvTramites.ClearSelection();

            DeshabilitarOrdenamiento();
            
            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvTramites.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion

        #region Botones
        private void dgvTramites_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Extrae los IDs del elemento seleccionado
                idTramite = Convert.ToInt32(dtTramites.Rows[dgvTramites.SelectedRows[0].Index].ItemArray[8].ToString());
                idEstadoTramite = Convert.ToInt32(dtTramites.Rows[dgvTramites.SelectedRows[0].Index].ItemArray[9].ToString());
                idEgresado = Convert.ToInt32(dtTramites.Rows[dgvTramites.SelectedRows[0].Index].ItemArray[2].ToString());

                //Carga los campos
                tbComentario.Text = dtTramites.Rows[dgvTramites.SelectedRows[0].Index].ItemArray[7].ToString();
                for (int i = 0; i < 3; ++i)
                    if (cmbEstado.Items[i].ToString().Equals(dtTramites.Rows[dgvTramites.SelectedRows[0].Index].ItemArray[6].ToString()))
                        cmbEstado.SelectedIndex = i;
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            //Guarda el tramite, obteniendo primero el id del estado

            foreach (DataRow r in dtEstado.Rows)
                if(cmbEstado.SelectedItem.ToString().Equals(r.ItemArray[1].ToString()))
                    idEstadoTramite = Convert.ToInt32(r.ItemArray[0].ToString());

            //Setea los valores y ejecuta el update
            tramite.IdTramite = idTramite;
            tramite.IdEstadoTramite = idEstadoTramite;
            tramite.IdEgresado = idEgresado;
            tramite.Comentario = tbComentario.Text;

            tramite.Actualizar();

            cargado = false;
            Cargar();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            dgvTramites.ClearSelection();
            tbComentario.Text = string.Empty;
            cmbEstado.SelectedIndex = 0;
        }
        #endregion

        #region Otros Métodos
        private void FrmTramites_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}

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
    public partial class FrmAgenda : Form
    {
        #region Variables
        private DataTable dtAgenda = new DataTable();

        private BLL.Agenda agenda = new BLL.Agenda();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private bool cargado = false;
        private string accionActual = string.Empty;
        private int idAgenda = 0;
        private int index = 0;
        private string[] valores = new string[3];
        #endregion

        #region Carga
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Setea la Fecha
            lblFecha.Text = "Fecha Actual: " + DateTime.Today.ToShortDateString();

            //Carga el datagrid
            dtAgenda = agenda.Listar();
            dgvAgenda.DataSource = null;
            dgvAgenda.DataSource = dtAgenda;

            //Da formato al datagrid
            dgvAgenda.Columns.Remove("idAgenda");
            dgvAgenda.Columns.Remove("anotacion");

            dgvAgenda.Columns[0].Width = 200;
            dgvAgenda.Columns[1].Width = 350;

            dgvAgenda.Columns[0].HeaderText = "Fecha Acuerdo";
            dgvAgenda.Columns[1].HeaderText = "Nombre del Cliente";

            //Ajusta la fecha mínima del dtp
            dtpFecha.MinDate = DateTime.Today;

            dgvAgenda.ClearSelection();
            DeshabilitarOrdenamiento();

            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvAgenda.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion

        #region Botones
        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            ActivarControles(true);
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            accionActual = "editar";
            ActivarControles(true);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo))
            {
                //Elimina el registro
                agenda.IdAgenda = idAgenda;
                agenda.Eliminar();

                //inserta en la bitácora
                InsertarBitacora("Eliminar", "Agenda", "Nombre", 0, "-");
                InsertarBitacora("Eliminar", "Agenda", "Anotación", 1, "-");
                InsertarBitacora("Eliminar", "Agenda", "Fecha", 2, "-");

                tbNombre.Text = string.Empty;
                tbAnotaciones.Text = string.Empty;
                dtpFecha.Value = DateTime.Now;

                cargado = false;
                Cargar();
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            //Controla que los campos estén Llenos
            string error = string.Empty;
            agenda.Nombre = tbNombre.Text;
            agenda.Anotacion = tbAnotaciones.Text;
            error = agenda.ControlCampos();

            if (error.Equals(string.Empty))
            {
                switch (accionActual)
                {
                    case "agregar":
                        {
                            agenda.Anotacion = tbAnotaciones.Text;
                            agenda.Fecha = dtpFecha.Value;

                            agenda.Insertar();
                        } break;
                    case "editar":
                        {
                            agenda.IdAgenda = idAgenda;
                            agenda.Anotacion = tbAnotaciones.Text;
                            agenda.Fecha = dtpFecha.Value;

                            agenda.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Agenda", "Nombre", 0, tbNombre.Text);
                            InsertarBitacora("Editar", "Agenda", "Anotación", 1, tbAnotaciones.Text);
                            InsertarBitacora("Editar", "Agenda", "Fecha", 2, dtpFecha.Value.ToShortDateString());
                        } break;
                }
                cargado = false;
                Cargar();
                ActivarControles(false);
            }
            else
                MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            accionActual = string.Empty;
            ActivarControles(false);
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Otros Métodos
        private void ActivarControles(bool editando)
        {
            lblFechaInvalida.Visible = false;
            dtpFecha.Visible = true;

            dgvAgenda.Enabled = !editando;

            bAgregar.Enabled = !editando;
            bEditar.Enabled = !editando;
            bEliminar.Enabled = !editando;

            tbNombre.ReadOnly = !editando;
            tbAnotaciones.ReadOnly = !editando;
            dtpFecha.Enabled = editando;

            bVolver.Visible = !editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;

            if (accionActual.Equals("agregar"))
            {
                tbAnotaciones.Text = string.Empty;
                tbNombre.Text = string.Empty;
                dtpFecha.Value = DateTime.Today;
                cargado = false;
                dgvAgenda.ClearSelection();
                cargado = true;
            }
        }

        private void FrmAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void InsertarBitacora(string accion, string tabla, string campo, int indice, string valorNuevo)
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = BLL.SesionActual.Login;
            bitacora.Accion = accion;
            bitacora.Tabla = tabla;
            bitacora.Campo = campo;
            bitacora.ValorAntiguo = valores[indice];
            bitacora.ValorNuevo = valorNuevo;
            bitacora.Insertar();
        }
        #endregion

        #region Otros Controles
        private void dgvAgenda_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado && dgvAgenda.Rows.Count > 0)
            {
                //Consigue los IDs seleccionados
                if(dgvAgenda.SelectedRows.Count == 1)
                    index = dgvAgenda.SelectedRows[0].Index;
                idAgenda = Convert.ToInt32(dtAgenda.Rows[index].ItemArray[0].ToString());

                //Llena los campos con el registro seleccionado
                tbNombre.Text = dtAgenda.Rows[index].ItemArray[3].ToString();
                tbAnotaciones.Text = dtAgenda.Rows[index].ItemArray[1].ToString();
                if (Convert.ToDateTime(dtAgenda.Rows[index].ItemArray[2].ToString()).CompareTo(DateTime.Now) == 1)
                {
                    dtpFecha.Value = Convert.ToDateTime(dtAgenda.Rows[index].ItemArray[2].ToString());
                    lblFechaInvalida.Visible = false;
                    dtpFecha.Visible = true;
                }
                else if (Convert.ToDateTime(dtAgenda.Rows[index].ItemArray[2].ToString()).CompareTo(DateTime.Today) == 0)
                {
                    dtpFecha.Value = Convert.ToDateTime(dtAgenda.Rows[index].ItemArray[2].ToString());
                    lblFechaInvalida.Visible = false;
                    dtpFecha.Visible = true;
                }
                else if (Convert.ToDateTime(dtAgenda.Rows[index].ItemArray[2].ToString()).CompareTo(DateTime.Now) == -1)
                {
                    dtpFecha.Value = DateTime.Today;
                    lblFechaInvalida.Visible = true;
                    dtpFecha.Visible = false;
                }

                //Registra los valores para la bitacora
                valores[0] = tbNombre.Text;
                valores[1] = tbAnotaciones.Text;
                valores[2] = dtpFecha.Value.ToShortDateString();
            }
        }
        #endregion
    }
}

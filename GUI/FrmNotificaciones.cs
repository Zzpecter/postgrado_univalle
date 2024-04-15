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
    public partial class FrmNotificaciones : Form
    {
        #region Variables
        private DataTable dtNotificaciones = new DataTable();
        private DataTable dtNotificacionesBD = new DataTable();
        private BLL.Notificacion notificacion = new BLL.Notificacion();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private bool cargado = false;
        private int index = 0;
        private int idNotificacion = 0;
        private string[] valores = new string[3];
        #endregion

        #region Carga
        public FrmNotificaciones(DataTable dtNotificaciones)
        {
            InitializeComponent();
            this.dtNotificaciones = dtNotificaciones;
        }

        private void FrmNotificaciones_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Vacia los campos
            tbDescripcion.Text = string.Empty;
            tbTipo.Text = string.Empty;
            bEliminar.Visible = false;
            bGuardar.Visible = true;

            //Llena el datagrid
            dgvNotificaciones.DataSource = null;
            dgvNotificaciones.DataSource = dtNotificaciones;
            dtNotificacionesBD = notificacion.Listar();

            //Le da formato
            dgvNotificaciones.Columns.Remove("descripcion");

            dgvNotificaciones.Columns[0].Width = 195;
            dgvNotificaciones.Columns[1].Width = 195;

            dgvNotificaciones.ClearSelection();
            DeshabilitarOrdenamiento();

            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvNotificaciones.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void CargarGuardadas()
        {
            //Vacia los campos
            tbDescripcion.Text = string.Empty;
            tbTipo.Text = string.Empty;

            //Llena el datagrid
            dgvNotificaciones.DataSource = null;
            dtNotificacionesBD = notificacion.Listar();
            dgvNotificaciones.DataSource = dtNotificacionesBD;

            //Le da formato
            dgvNotificaciones.Columns.Remove("idNotificacion");
            dgvNotificaciones.Columns.Remove("descripcion");

            dgvNotificaciones.Columns[0].Width = 195;
            dgvNotificaciones.Columns[1].Width = 195;

            dgvNotificaciones.ClearSelection();

            cargado = true;
        }
        #endregion

        #region Botones
        private void dgvNotificaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                if (!bNotificaciones.Enabled)
                {
                    //Llena los TextBox
                    index = dgvNotificaciones.SelectedRows[0].Index;
                    tbDescripcion.Text = dtNotificaciones.Rows[index].ItemArray[0].ToString();
                    tbTipo.Text = dtNotificaciones.Rows[index].ItemArray[1].ToString();
                }
                else
                {
                    dtNotificacionesBD = notificacion.Listar();
                    index = dgvNotificaciones.SelectedRows[0].Index;
                    tbDescripcion.Text = dtNotificacionesBD.Rows[index].ItemArray[1].ToString();
                    tbTipo.Text = dtNotificacionesBD.Rows[index].ItemArray[2].ToString();
                }

                //Comprueba si tiene id
                if (dgvNotificaciones.Rows.Count == dtNotificacionesBD.Rows.Count)
                    idNotificacion = Convert.ToInt32(dtNotificacionesBD.Rows[index].ItemArray[0].ToString());

                //Registra los valores para la bitacora
                valores[0] = tbDescripcion.Text;
                valores[1] = tbTipo.Text;
                valores[2] = DateTime.Now.ToShortDateString();
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (dgvNotificaciones.SelectedRows.Count == 1)
            {
                notificacion.Descripcion = tbDescripcion.Text;
                notificacion.Tipo = tbTipo.Text;
                notificacion.Fecha = Convert.ToDateTime(dtNotificaciones.Rows[index].ItemArray[2].ToString());

                //Controla que el registro no fue guardado aun
                string aux = string.Empty;
                string aux2 = string.Empty;
                bool puede = true;

                dtNotificacionesBD = notificacion.Listar();
                aux = tbDescripcion.Text;
                foreach (DataRow dtr in dtNotificacionesBD.Rows)
                {
                    aux2 = dtr.ItemArray[1].ToString();
                    if (aux.Equals(aux2))
                        puede = false;
                }

                //Si no se encuentra un registro igual, se guarda
                if (puede)
                    notificacion.Insertar();
                else
                    MessageBox.Show(BLL.Mensajes.msjRegistroRepetido, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvNotificaciones.SelectedRows.Count > 0)
            {
                notificacion.IdNotificacion = idNotificacion;
                notificacion.Eliminar();

                //inserta en la bitácora
                InsertarBitacora("Eliminar", "Notificaciones", "Descripcion", 0, "-");
                InsertarBitacora("Eliminar", "Notificaciones", "Tipo", 1, "-");
                InsertarBitacora("Eliminar", "Notificaciones", "Fecha", 2, "-");

                cargado = false;
                CargarGuardadas();
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void notificacionesGuardadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bEliminar.Visible = true;
            bGuardar.Visible = false;
            bNotificaciones.Enabled = true;
            bNotificacionesGuardadas.Enabled = false;

            cargado = false;
            CargarGuardadas();
        }

        private void bNotificaciones_Click(object sender, EventArgs e)
        {
            bEliminar.Visible = false;
            bGuardar.Visible = true;
            bNotificaciones.Enabled = false;
            bNotificacionesGuardadas.Enabled = true;

            cargado = false;
            Cargar();
        }
        #endregion

        #region Otros Métodos
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

        private void FrmNotificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}

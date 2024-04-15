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
    public partial class FrmABMTelefono : Form
    {
        #region Variables
        private BLL.TipoTelefono tipoTelefono = new BLL.TipoTelefono();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtTelefono = new DataTable();

        private int idTipoTelefono = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private int index = 0;
        private string[] valores = new string[1];
        #endregion

        #region Carga
        public FrmABMTelefono()
        {
            InitializeComponent();
        }

        private void FrmABMTelefono_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Carga el datagrid
            dtTelefono = tipoTelefono.Listar();
            dgvTelefonos.DataSource = null;
            dgvTelefonos.DataSource = dtTelefono;

            //Da formato al datagrid
            dgvTelefonos.Columns.Remove("idTipoTelefono");
            dgvTelefonos.Columns[0].Width = 234;
            dgvTelefonos.Columns[0].HeaderText = "Tipo de Teléfono";

            dgvTelefonos.ClearSelection();

            DeshabilitarOrdenamiento();
            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvTelefonos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void HabilitarControles(bool editando)
        {
            dgvTelefonos.Enabled = !editando;

            tbTipoTelefono.ReadOnly = !editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;

            bAgregar.Enabled = !editando;
            bEditar.Enabled = !editando;
            bEliminar.Enabled = !editando;
            bVolver.Enabled = !editando;

            if (accionActual.Equals("agregar"))
            {
                cargado = false;
                tbTipoTelefono.Text = string.Empty;
                dgvTelefonos.ClearSelection();
                cargado = true;
            }
        }
        #endregion

        #region Botones
        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            HabilitarControles(true);
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.SelectedRows.Count.Equals(1))
            {
            accionActual = "editar";
            HabilitarControles(true);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.SelectedRows.Count.Equals(1))
            {
                if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tipoTelefono.IdTipoTelefono = idTipoTelefono;

                    tipoTelefono.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "TipoTelefono", "TipoTelefono", 0, "-");

                    tbTipoTelefono.Text = string.Empty;

                    cargado = false;
                    Cargar();
                }
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            switch (accionActual)
            {
                case "agregar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        tipoTelefono.TipoTelf = tbTipoTelefono.Text;

                        string error = tipoTelefono.ControlCampos();

                        if (error == string.Empty)
                        {
                            //inserta en la base de datos
                            tipoTelefono.Insertar();
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
                        }
                    } break;

                case "editar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        tipoTelefono.TipoTelf = tbTipoTelefono.Text;

                        string error = tipoTelefono.ControlCampos();

                        if (error == string.Empty)
                        {
                            //actualiza la base de datos
                            tipoTelefono.IdTipoTelefono = idTipoTelefono;

                            tipoTelefono.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "TipoTelefono", "TipoTelefono", 0, tbTipoTelefono.Text);
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
                        }

                    } break;

                default: break;
            }
            cargado = false;
            Cargar();
            HabilitarControles(false);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            accionActual = string.Empty;
            HabilitarControles(false);
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void dgvTelefonos_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Selecciona el id
                index = dgvTelefonos.SelectedRows[0].Index;
                idTipoTelefono = Convert.ToInt32(dtTelefono.Rows[index].ItemArray[0].ToString());

                //Llena el textbox
                tbTipoTelefono.Text = dtTelefono.Rows[index].ItemArray[1].ToString();

                //Registra los valores para la bitacora
                valores[0] = tbTipoTelefono.Text;
            }
        }
        #endregion

        #region Otros Métodos
        private void FrmABMTelefono_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

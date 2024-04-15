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
    public partial class FrmTelefonos : Form
    {
        #region Variables
        private BLL.Telefono telefono = new BLL.Telefono();
        private BLL.TipoTelefono tipoTelefono = new BLL.TipoTelefono();
        private BLL.Persona persona = new BLL.Persona();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtTelefono = new DataTable();
        private DataTable dtTipoTelefono = new DataTable();

        private bool cargado = false;
        private string accionActual = string.Empty;
        private int idTelefono = 0;
        private int idTipoTelefono = 0;
        private int idPersona = 0;
        private int index = 0;
        private string[] valores = new string[7];
        #endregion

        #region Carga
        public FrmTelefonos(int idPersona, string nombre)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            this.Text = "Gestión de Teléfonos de " + nombre;
        }

        private void FrmTelefonos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Carga el datagrid
            dtTelefono = telefono.Listar(idPersona);
            dgvTelefonos.DataSource = null;
            dgvTelefonos.DataSource = dtTelefono;

            //Da formato al datagrid
            dgvTelefonos.Columns.Remove("idTelefono");
            dgvTelefonos.Columns.Remove("idPersona");
            dgvTelefonos.Columns[0].Width = 117;
            dgvTelefonos.Columns[1].Width = 117;
            dgvTelefonos.Columns[0].HeaderText = "Número";
            dgvTelefonos.Columns[1].HeaderText = "Tipo";

            dgvTelefonos.ClearSelection();

            //Llena el combobox
            dtTipoTelefono = tipoTelefono.Listar();
            cmbTipo.Items.Clear();
            foreach (DataRow dtr in dtTipoTelefono.Rows)
                cmbTipo.Items.Add(dtr.ItemArray[1].ToString());
            DeshabilitarOrdenamiento();

            cargado = true;
            cmbTipo.SelectedIndex = 0;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvTelefonos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void HabilitarControles(bool editando)
        {
            dgvTelefonos.Enabled = !editando;

            tbNumero.ReadOnly = !editando;
            cmbTipo.Enabled = editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;

            bAgregar.Enabled = !editando;
            bEditar.Enabled = !editando;
            bEliminar.Enabled = !editando;
            bVolver.Enabled = !editando;

            if (accionActual.Equals("agregar"))
            {
                tbNumero.Text = string.Empty;
                cmbTipo.SelectedIndex = 0;
                dgvTelefonos.ClearSelection();
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
                    telefono.IdTelefono = idTelefono;
                    telefono.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "Telefono", "Numero", 0, "-");
                    InsertarBitacora("Eliminar", "Telefono", "Tipo", 1, "-");

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
                        telefono.Numero = tbNumero.Text;

                        string error = telefono.ControlCampos();

                        if (error == string.Empty)
                        {
                            //inserta en la base de datos
                            telefono.Numero = tbNumero.Text;
                            telefono.IdTipoTelefono = idTipoTelefono;

                            telefono.Insertar(idPersona);
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
                        }
                    } break;

                case "editar":
                    {
                        //Manda variables a la capa de negocio para controlarlas
                        telefono.Numero = tbNumero.Text;

                        string error = telefono.ControlCampos();

                        if (error == string.Empty)
                        {
                            //actualiza la base de datos
                            telefono.IdTelefono = idTelefono;
                            telefono.Numero = tbNumero.Text;
                            telefono.IdTipoTelefono = idTipoTelefono;

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Telefonos", "Numero", 0, tbNumero.Text);
                            InsertarBitacora("Editar", "Telefonos", "Tipo", 1, cmbTipo.SelectedItem.ToString());

                            telefono.Actualizar(idPersona);
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
            this.Hide();
        }

        private void dgvTelefonos_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Selecciona el id
                index = dgvTelefonos.SelectedRows[0].Index;
                idTelefono = Convert.ToInt32(dtTelefono.Rows[index].ItemArray[1].ToString());

                //Llena el textbox
                tbNumero.Text = dtTelefono.Rows[index].ItemArray[2].ToString();

                //Registra los valores para la bitacora
                valores[0] = tbNumero.Text;
                valores[1] = cmbTipo.SelectedItem.ToString();

                //Selecciona el Combo
                foreach (DataRow dtr in dtTipoTelefono.Rows)
                    if(dtr.ItemArray[1].ToString().Equals(dgvTelefonos.SelectedRows[0].Cells[1].Value.ToString()))
                        cmbTipo.SelectedItem = dtr.ItemArray[1].ToString();
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
                idTipoTelefono = Convert.ToInt32(dtTipoTelefono.Rows[cmbTipo.SelectedIndex].ItemArray[0].ToString());
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
        #endregion
    }
}

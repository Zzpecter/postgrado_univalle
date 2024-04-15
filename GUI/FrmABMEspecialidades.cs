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
    public partial class FrmABMEspecialidades : Form
    {
        #region Variables
        private BLL.Area area = new BLL.Area();
        private BLL.Especialidad especialidad = new BLL.Especialidad();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtEspecialidad = new DataTable();
        private DataTable dtArea = new DataTable();

        private int idArea = 0;
        private int idEspecialidad = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private int index = 0;
        private string[] valores = new string[2];
        #endregion

        #region Carga
        public FrmABMEspecialidades()
        {
            InitializeComponent();
        }

        private void FrmABMEspecialidades_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Carga los Datos
            dgvEspecialidades.DataSource = null;
            dtEspecialidad = especialidad.ListarABM();
            dgvEspecialidades.DataSource = dtEspecialidad;

            //Da formato al datagrid
            dgvEspecialidades.Columns.Remove("idAreaEspecialidad");
            dgvEspecialidades.Columns.Remove("idEspecialidad");
            dgvEspecialidades.Columns[0].HeaderText = "Especialidad";
            dgvEspecialidades.Columns[1].HeaderText = "Area";
            dgvEspecialidades.Columns[0].Width = 134;

            //Carga el combobox
            dtArea = area.Listar();
            cmbArea.Items.Clear();
            foreach (DataRow dtr in dtArea.Rows)
                cmbArea.Items.Add(dtr.ItemArray[1].ToString());
            cmbArea.SelectedIndex = 0;

            dgvEspecialidades.ClearSelection();
            DeshabilitarOrdenamiento();
            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvEspecialidades.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void HabilitarControles(bool editando)
        {
            dgvEspecialidades.Enabled = !editando;

            tbEspecialidad.ReadOnly = !editando;
            cmbArea.Enabled = editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;

            bAgregar.Enabled = !editando;
            bEditar.Enabled = !editando;
            bEliminar.Enabled = !editando;
            bVolver.Enabled = !editando;

            if (accionActual.Equals("agregar"))
            {
                cargado = false;
                tbEspecialidad.Text = string.Empty;
                dgvEspecialidades.ClearSelection();
                cargado = true;
                cmbArea.SelectedIndex = 0;
            }
        }
        #endregion 

        #region Botones
        private void dgvEspecialidades_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvEspecialidades.SelectedRows[0].Index;
                idEspecialidad = Convert.ToInt32(dtEspecialidad.Rows[index].ItemArray[0].ToString());
                idArea = Convert.ToInt32(dtEspecialidad.Rows[index].ItemArray[1].ToString());

                //Da el valor al textbox y combo
                tbEspecialidad.Text = dtEspecialidad.Rows[index].ItemArray[2].ToString();

                for (int i = 0; i < dtArea.Rows.Count; ++i)
                    if (dtArea.Rows[i].ItemArray[0].ToString().Equals(idArea.ToString()))
                        cmbArea.SelectedIndex = i;

                //Registra los valores para la bitacora
                valores[0] = tbEspecialidad.Text;
                valores[1] = cmbArea.SelectedItem.ToString();
            }
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargado)
                idArea = Convert.ToInt32(dtArea.Rows[cmbArea.SelectedIndex].ItemArray[0].ToString());
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            HabilitarControles(true);
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count.Equals(1))
            {
            accionActual = "editar";
            HabilitarControles(true);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count.Equals(1))
            {
                if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    especialidad.IdEspecialidad = idEspecialidad;
                    especialidad.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "Especialidad", "Nombre", 0, "-");
                    InsertarBitacora("Eliminar", "Especialidad", "Area", 1, "-");

                    tbEspecialidad.Text = string.Empty;
                    cmbArea.SelectedIndex = 0;

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
                        especialidad.Nombre = tbEspecialidad.Text;

                        string error = especialidad.ComprobarCampos();

                        if (error == string.Empty)
                        {
                            //inserta en la base de datos
                            especialidad.IdAreaEspecialidad = idArea;

                            especialidad.Insertar();
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;

                case "editar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        especialidad.Nombre = tbEspecialidad.Text;

                        string error = especialidad.ComprobarCampos();


                        if (error == string.Empty)
                        {
                            //actualiza la base de datos
                            especialidad.IdAreaEspecialidad = idArea;
                            especialidad.IdEspecialidad = idEspecialidad;

                            especialidad.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Especialidad", "Nombre", 0, tbEspecialidad.Text);
                            InsertarBitacora("Editar", "Especialidad", "Area", 1, cmbArea.SelectedItem.ToString());
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

        private void FrmABMEspecialidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}

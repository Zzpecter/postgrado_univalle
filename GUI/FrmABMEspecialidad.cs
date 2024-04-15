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
    public partial class FrmABMEspecialidad : Form
    {
        #region Variables
        private BLL.Area area = new BLL.Area();
        private BLL.AreaEspecialidad areaEspecialidad = new BLL.AreaEspecialidad();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtArea = new DataTable();

        private int idArea = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private int index = 0;
        private string[] valores = new string[1];
        #endregion

        #region Carga
        public FrmABMEspecialidad()
        {
            InitializeComponent();
        }

        private void FrmABMEspecialidad_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Carga el datagrid
            dtArea = area.Listar();
            dgvAreas.DataSource = null;
            dgvAreas.DataSource = dtArea;

            //Da formato al datagrid
            dgvAreas.Columns.Remove("idArea");
            dgvAreas.Columns[0].Width = 234;
            dgvAreas.Columns[0].HeaderText = "Area de Especialidad";

            dgvAreas.ClearSelection();

            DeshabilitarOrdenamiento();
            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvAreas.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void HabilitarControles(bool editando)
        {
            dgvAreas.Enabled = !editando;

            tbArea.ReadOnly = !editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;

            bAgregar.Enabled = !editando;
            bEditar.Enabled = !editando;
            bEliminar.Enabled = !editando;
            bVolver.Enabled = !editando;

            if (accionActual.Equals("agregar"))
            {
                cargado = false;
                tbArea.Text = string.Empty;
                dgvAreas.ClearSelection();
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
            if (dgvAreas.SelectedRows.Count.Equals(1))
            {
            accionActual = "editar";
            HabilitarControles(true);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAreas.SelectedRows.Count.Equals(1))
            {
                if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    area.IdArea = idArea;
                    areaEspecialidad.IdAreaEspecialidad = idArea;

                    areaEspecialidad.Eliminar();
                    area.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "Area", "NombreArea", 0, "-");

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
                        area.NombreArea = tbArea.Text;

                        string error = area.ControlCampos();

                        if (error == string.Empty)
                        {
                            //inserta en la base de datos
                            areaEspecialidad.Nombre = tbArea.Text;

                            area.Insertar();
                            areaEspecialidad.Insertar();
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
                        }
                    } break;

                case "editar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        area.NombreArea = tbArea.Text;

                        string error = area.ControlCampos();

                        if (error == string.Empty)
                        {
                            //actualiza la base de datos
                            areaEspecialidad.Nombre = tbArea.Text;
                            areaEspecialidad.IdAreaEspecialidad = idArea;
                            area.IdArea = idArea;

                            area.Actualizar();
                            areaEspecialidad.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Area", "NombreArea", 0, tbArea.Text);
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

        private void dgvAreas_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Selecciona el id
                index = dgvAreas.SelectedRows[0].Index;
                idArea = Convert.ToInt32(dtArea.Rows[index].ItemArray[0].ToString());

                //Llena el textbox
                tbArea.Text = dtArea.Rows[index].ItemArray[1].ToString();

                //Registra los valores para la bitacora

                valores[0] = tbArea.Text;
            }
        }
        #endregion

        #region Otros Métodos
        private void FrmABMEspecialidad_FormClosing(object sender, FormClosingEventArgs e)
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

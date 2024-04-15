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
    public partial class FrmABMAula : Form
    {
        #region Variables
        private BLL.Aula aula = new BLL.Aula();
        private BLL.TipoAula tipoAula = new BLL.TipoAula();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtAula = new DataTable();
        private DataTable dtTipoAula = new DataTable();

        private int idTipoAula = 0;
        private int idAula = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private int index = 0;
        private string[] valores = new string[2];
        #endregion

        #region Carga
        public FrmABMAula()
        {
            InitializeComponent();
        }

        private void FrmABMAula_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Carga el datagrid
            dtAula = aula.Listar();
            dgvAula.DataSource = null;
            dgvAula.DataSource = dtAula;

            //Llena el Combobox
            dtTipoAula = tipoAula.Listar();
            cmbTipo.Items.Clear();
            foreach(DataRow dtr in dtTipoAula.Rows)
                cmbTipo.Items.Add(dtr.ItemArray[1].ToString());
            cmbTipo.SelectedIndex = 0;

            //Da formato al datagrid
            dgvAula.Columns.Remove("idTipoAula");
            dgvAula.Columns.Remove("idAula");
            dgvAula.Columns[0].Width = 234;
            dgvAula.Columns[0].HeaderText = "Número de Aula";

            dgvAula.ClearSelection();
            DeshabilitarOrdenamiento();

            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvAula.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void HabilitarControles(bool editando)
        {
            dgvAula.Enabled = !editando;

            tbAula.Enabled = editando;
            cmbTipo.Enabled = editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;

            bAgregar.Enabled = !editando;
            bEditar.Enabled = !editando;
            bEliminar.Enabled = !editando;
            bVolver.Enabled = !editando;

            if (accionActual.Equals("agregar"))
            {
                cargado = false;
                tbAula.Value = 100;
                dgvAula.ClearSelection();
                cargado = true;
                cmbTipo.SelectedIndex = 0;
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
            if (dgvAula.SelectedRows.Count.Equals(1))
            {
                accionActual = "editar";
                HabilitarControles(true);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAula.SelectedRows.Count.Equals(1))
            {
                if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    aula.IdAula = idAula;

                    aula.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "Aula", "NumAula", 0, "-");

                    tbAula.Value = 100;
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
                        aula.NumAula = Convert.ToInt32(tbAula.Value);

                        string error = aula.ControlCampos();

                        if (error == string.Empty)
                        {
                            //inserta en la base de datos
                            aula.IdTipoAula = idTipoAula;
                            aula.Insertar();
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
                        }
                    } break;

                case "editar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        aula.NumAula = Convert.ToInt32(tbAula.Value);

                        string error = aula.ControlCampos();

                        if (error == string.Empty)
                        {
                            //actualiza la base de datos
                            aula.IdAula = idAula;
                            aula.IdTipoAula = idTipoAula;

                            aula.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Aula", "NumAula", 0, tbAula.Value.ToString());
                            InsertarBitacora("Editar", "Aula", "TipoAula", 1, cmbTipo.SelectedItem.ToString());
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

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTipoAula = Convert.ToInt32(dtTipoAula.Rows[cmbTipo.SelectedIndex].ItemArray[0].ToString());
        }

        private void dgvAula_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Selecciona el id
                index = dgvAula.SelectedRows[0].Index;
                idAula = Convert.ToInt32(dtAula.Rows[index].ItemArray[0].ToString());
                idTipoAula = Convert.ToInt32(dtAula.Rows[index].ItemArray[1].ToString());

                //Llena el textbox
                tbAula.Value = Convert.ToInt32(dtAula.Rows[index].ItemArray[2].ToString());

                //Selecciona el Combo
                for (int i = 0; i < dtTipoAula.Rows.Count; ++i)
                    if (dtTipoAula.Rows[i].ItemArray[0].ToString().Equals(idTipoAula.ToString()))
                        cmbTipo.SelectedIndex = i;

                //Registra los valores para la bitacora

                valores[0] = tbAula.Value.ToString();
                valores[1] = cmbTipo.SelectedItem.ToString();
            }
        }

        #endregion

        #region Otros Métodos
        private void FrmABMAula_FormClosing(object sender, FormClosingEventArgs e)
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

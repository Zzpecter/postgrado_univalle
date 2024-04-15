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
    public partial class FrmABMMateria : Form
    {
        #region Variables
        private BLL.Materias materias = new BLL.Materias();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtMaterias = new DataTable();

        private int idMateria = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private int index = 0;
        private string[] valores = new string[2];
        #endregion

        #region Carga
        public FrmABMMateria()
        {
            InitializeComponent();
        }
        
        private void FrmABMMateria_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Carga los Datos
            dgvMaterias.DataSource = null;
            dtMaterias = materias.Listar();
            dgvMaterias.DataSource = dtMaterias;

            //Da formato al datagrid
            dgvMaterias.Columns.Remove("idMateria");
            dgvMaterias.Columns[0].HeaderText = "Materia";
            dgvMaterias.Columns[1].HeaderText = "Horas";
            dgvMaterias.Columns[0].Width = 340;
            dgvMaterias.Columns[1].Width = 60;

            dgvMaterias.ClearSelection();
            DeshabilitarOrdenamiento();
            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvMaterias.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void HabilitarControles(bool editando)
        {
            dgvMaterias.Enabled = !editando;

            tbMateria.ReadOnly = !editando;
            tbHoras.Enabled = editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;

            bAgregar.Enabled = !editando;
            bEditar.Enabled = !editando;
            bEliminar.Enabled = !editando;
            bVolver.Enabled = !editando;

            if (accionActual.Equals("agregar"))
            {
                cargado = false;
                tbMateria.Text = string.Empty;
                tbHoras.Value = 1;
                dgvMaterias.ClearSelection();
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
            if (dgvMaterias.SelectedRows.Count.Equals(1))
            {
                accionActual = "editar";
                HabilitarControles(true);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count.Equals(1))
            {
                if (ComprobarMateria().Equals(0))
                {
                    if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        materias.IdMateria = idMateria;
                        materias.Eliminar();

                        //inserta en la bitácora
                        InsertarBitacora("Eliminar", "Materia", "Nombre", 0, "-");
                        InsertarBitacora("Eliminar", "Materia", "HorasTotales", 1, "-");

                        tbMateria.Text = string.Empty;
                        tbHoras.Value = 1;

                        cargado = false;
                        Cargar();
                    }
                }
                else
                    MessageBox.Show(BLL.Mensajes.msjMateriaEnUso, BLL.Mensajes.capError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvMaterias_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvMaterias.SelectedRows[0].Index;
                idMateria = Convert.ToInt32(dtMaterias.Rows[index].ItemArray[0].ToString());

                //Da el valor al textbox y combo
                tbMateria.Text = dtMaterias.Rows[index].ItemArray[1].ToString();
                tbHoras.Value = Convert.ToInt32(dtMaterias.Rows[index].ItemArray[2].ToString());

                //Registra los valores para la bitacora
                valores[0] = tbMateria.Text;
                valores[1] = tbHoras.Value.ToString();
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            switch (accionActual)
            {
                case "agregar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        materias.NombreMateria = tbMateria.Text;

                        string error = materias.ControlCampos();

                        if (error == string.Empty)
                        {
                            //inserta en la base de datos
                            materias.HorasTotales = Convert.ToInt32(tbHoras.Value);

                            materias.Insertar();
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } break;

                case "editar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        materias.NombreMateria = tbMateria.Text;

                        string error = materias.ControlCampos();


                        if (error == string.Empty)
                        {
                            //actualiza la base de datos
                            materias.IdMateria = idMateria;
                            materias.HorasTotales = Convert.ToInt32(tbHoras.Value);

                            materias.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Materia", "NombreMateria", 0, tbMateria.Text);
                            InsertarBitacora("Editar", "Materia", "HorasTotales", 1, tbHoras.Value.ToString());
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
        private int ComprobarMateria()
        {
            materias.IdMateria = idMateria;
            DataTable dtAux = materias.Seleccionar();
            return dtAux.Rows.Count;
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

        private void FrmABMMateria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}

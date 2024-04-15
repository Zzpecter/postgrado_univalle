using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmInteresados : Form
    {
        #region Variables
        private BLL.Area area = new BLL.Area();
        private BLL.AreaInteresado areaInteresado = new BLL.AreaInteresado();
        private BLL.Interesado interesado = new BLL.Interesado();
        private BLL.Telefono telefono = new BLL.Telefono();
        private BLL.Persona persona = new BLL.Persona();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtArea = new DataTable();
        private DataTable dtInteresado = new DataTable();
        private DataTable dtAreaInteresado = new DataTable();
        private DataTable dtAreaSeleccionadas = new DataTable();
        private DataTable dtTelefono = new DataTable();

        private int index = 0;
        private int idPersona = 0;
        private int idInteresado = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private string[] valores = new string[4];
        #endregion

        #region Carga
        public FrmInteresados()
        {
            InitializeComponent();
        }

        private void FrmInteresados_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Llena el Datagrid de Interesados
            dgvInteresados.DataSource = null;
            dtInteresado = interesado.Listar();
            dgvInteresados.DataSource = dtInteresado;

            //Le da formato
            dgvInteresados.Columns.Remove("idInteresado");
            dgvInteresados.Columns.Remove("idPersona");
            dgvInteresados.Columns.Remove("tipoInteresado");
            dgvInteresados.Columns.Remove("direccion");
            dgvInteresados.Columns.Remove("correo");

            dgvInteresados.Columns[0].Width = 211;
            dgvInteresados.Columns[1].Width = 211;

            //Llena el Datagrid de Areas
            dgvAreas.DataSource = null;
            dtArea = area.Listar();
            dgvAreas.DataSource = dtArea;

            //Le da formato
            dgvAreas.Columns.Remove("idArea");
            dgvAreas.Columns[0].HeaderText = "";
            dgvAreas.Columns[0].Width = 50;
            dgvAreas.Columns[1].Width = 250;

            //Limpia la seleccion del Datagrid
            for(int i = 0; i < dgvAreas.Rows.Count; ++i)
                dgvAreas.Rows[i].Cells[0].Value = false;

            dgvInteresados.ClearSelection();
            DeshabilitarOrdenamiento();

            dgvAreas.ReadOnly = false;
            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvAreas.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvInteresados.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvTelefonos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void CargarTelefonos()
        {
            dtTelefono = telefono.Listar(idPersona);
            dgvTelefonos.DataSource = null;
            dgvTelefonos.DataSource = dtTelefono;
            dgvTelefonos.Columns.Remove("idPersona");
            dgvTelefonos.Columns.Remove("idTelefono");
            dgvTelefonos.Refresh();
        }

        private void HabilitarControles(bool editando)
        {
            dgvInteresados.Enabled = !editando;
            dgvAreas.Enabled = editando;

            bAgregar.Visible = !editando;
            bEditar.Visible = !editando;
            bEliminar.Visible = !editando;
            bVolver.Visible = !editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;
            bEditarTelf.Visible = !editando;

            tbNombres.ReadOnly = !editando;
            tbApellidos.ReadOnly = !editando;
            tbCorreo.ReadOnly = !editando;
            tbDireccion.ReadOnly = !editando;

            if (accionActual.Equals("agregar"))
            {
                tbNombres.Text = string.Empty;
                tbApellidos.Text = string.Empty;
                tbCorreo.Text = string.Empty;
                tbDireccion.Text = string.Empty;

                //Limpia la seleccion del Datagrid
                cargado = false;
                for (int i = 0; i < dgvAreas.Rows.Count; ++i)
                    dgvAreas.Rows[i].Cells[0].Value = false;
                dgvInteresados.ClearSelection();
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
            if (dgvInteresados.SelectedRows.Count.Equals(1))
            {
                accionActual = "editar";
                HabilitarControles(true);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInteresados.SelectedRows.Count.Equals(1))
            {
                if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    interesado.IdInteresado = idInteresado;
                    persona.IdPersona = idPersona;

                    interesado.Eliminar();
                    persona.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "Persona", "Nombres", 0, "-");
                    InsertarBitacora("Eliminar", "Persona", "Apellidos", 1, "-");
                    InsertarBitacora("Eliminar", "Interesado", "Correo", 2, "-");
                    InsertarBitacora("Eliminar", "Interesado", "Direccion", 3, "-");

                    tbNombres.Text = string.Empty;
                    tbApellidos.Text = string.Empty;
                    tbCorreo.Text = string.Empty;
                    tbDireccion.Text = string.Empty;

                    cargado = false;
                    Cargar();
                }
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEditarTelf_Click(object sender, EventArgs e)
        {
            FrmTelefonos frm = new FrmTelefonos(idPersona, dgvInteresados.SelectedRows[0].Cells[0].Value.ToString() + " " + dgvInteresados.SelectedRows[0].Cells[1].Value.ToString());
            frm.ShowDialog();
            CargarTelefonos();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            byte[] pic = new byte[0];
            string error = string.Empty;
            List<int> areas = new List<int>();

            //Setear las variables a ser controladas
            persona.Nombres = tbNombres.Text;
            persona.Apellidos = tbApellidos.Text;
            error = persona.ControlCampos();

            interesado.Correo = tbCorreo.Text;
            interesado.Direccion = tbDireccion.Text;
            error += interesado.ControlCampos();

            switch (accionActual)
            {
                case "agregar":
                    {
                        if (error.Equals(string.Empty))
                        {
                            //Se consigue todos los ID's de las areas del interesado
                            areas.Clear();
                            for (int i = 0; i < dgvAreas.Rows.Count; ++i)
                                if (Convert.ToBoolean(dgvAreas.Rows[i].Cells[0].Value) == true)
                                    areas.Add(Convert.ToInt32(dtArea.Rows[i].ItemArray[0].ToString()));

                            //se ingresa la informacion en la BDD
                            //Empezando por persona
                            persona.Nombres = tbNombres.Text;
                            persona.Apellidos = tbApellidos.Text;
                            //foto por defecto
                            Properties.Resources.imgPerfil.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            pic = stream.ToArray();
                            persona.Foto = pic;
                            idPersona = persona.Insertar();

                            //ingresa Interesado
                            interesado.Correo = tbCorreo.Text;
                            interesado.IdPersona = idPersona;
                            interesado.TipoInteresado = "cliente";
                            interesado.Direccion = tbDireccion.Text;
                            idInteresado = interesado.Insertar();

                            //Ingresa la relación con las areas de interes
                            areaInteresado.IdInteresado = idInteresado;
                            if (areas.Count > 0)
                                foreach (int i in areas)
                                {
                                    areaInteresado.IdArea = i;
                                    areaInteresado.Insertar();
                                }
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
                        }
                    } break;

                case "editar":
                    {
                        if (error.Equals(string.Empty))
                        {
                            //actualiza la información, empezando por la persona
                            persona.IdPersona = idPersona;
                            persona.Nombres = tbNombres.Text;
                            persona.Apellidos = tbApellidos.Text;
                            Properties.Resources.imgPerfil.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            pic = stream.ToArray();
                            persona.Foto = pic;

                            persona.Actualizar();

                            //actualiza Interesado
                            interesado.IdInteresado = idInteresado;
                            interesado.Correo = tbCorreo.Text;
                            interesado.IdPersona = idPersona;
                            interesado.TipoInteresado = "cliente";
                            interesado.Direccion = tbDireccion.Text;
                            interesado.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Persona", "Nombres", 0, tbNombres.Text);
                            InsertarBitacora("Editar", "Persona", "Apellidos", 1, tbApellidos.Text);
                            InsertarBitacora("Editar", "Interesado", "Correo", 2, tbCorreo.Text);
                            InsertarBitacora("Editar", "Interesado", "Direccion", 3, tbDireccion.Text);

                            //Se consigue todos los ID's de las areas del interesado
                            areas.Clear();
                            for (int i = 0; i < dgvAreas.Rows.Count; ++i)
                                if (Convert.ToBoolean(dgvAreas.Rows[i].Cells[0].Value) == true)
                                    areas.Add(Convert.ToInt32(dtArea.Rows[i].ItemArray[0].ToString()));

                            //Actualiza sus areas de interes
                            bool existe = false;
                            areaInteresado.IdInteresado = idInteresado;

                            //Comprueba si hay nuevas areas y las inserta
                            for (int i = 0; i < areas.Count; ++i)
                            {
                                existe = false;
                                foreach (DataRow dtr in dtAreaSeleccionadas.Rows)
                                {
                                    if (Convert.ToInt32(dtr.ItemArray[1].ToString()) == areas[i])
                                        existe = true;
                                }
                                if (!existe)
                                {
                                    //inserta nueva area
                                    areaInteresado.IdArea = areas[i];
                                    areaInteresado.Insertar();
                                }
                            }

                            //comprueba que areas ya no estan y las elimina
                            for (int i = 0; i < dtAreaSeleccionadas.Rows.Count; ++i)
                            {
                                existe = false;
                                foreach (int ar in areas)
                                {
                                    if (Convert.ToInt32(dtAreaSeleccionadas.Rows[i].ItemArray[1].ToString()) == ar)
                                        existe = true;
                                }
                                if (!existe)
                                {
                                    //elimina el area
                                    areaInteresado.IdInteresado = idInteresado;
                                    areaInteresado.IdArea = Convert.ToInt32(dtAreaSeleccionadas.Rows[i].ItemArray[1].ToString());
                                    areaInteresado.Eliminar2();
                                }
                            }
                        }
                    } break;
            }

            HabilitarControles(false);
            cargado = false;
            Cargar();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            accionActual = string.Empty;
            HabilitarControles(false);
        }

        private void dgvInteresados_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Saca los IDs
                index = dgvInteresados.SelectedRows[0].Index;
                idPersona = Convert.ToInt32(dtInteresado.Rows[index].ItemArray[1].ToString());
                idInteresado = Convert.ToInt32(dtInteresado.Rows[index].ItemArray[0].ToString());

                //saca la lista de Areas del interesado
                areaInteresado.IdInteresado = idInteresado;
                dtAreaSeleccionadas = areaInteresado.Seleccionar();

                //Marca las areas del interesado
                if (dtAreaSeleccionadas.Rows.Count > 0)
                {
                    foreach (DataGridViewRow d in dgvAreas.Rows)
                        d.Cells[0].Value = false;
                    foreach (DataRow dtr in dtAreaSeleccionadas.Rows)
                        for (int i = 0; i < dtArea.Rows.Count; ++i)
                            if (dtArea.Rows[i].ItemArray[0].ToString().Equals(dtr.ItemArray[1].ToString()))
                                dgvAreas.Rows[i].Cells[0].Value = true;
                }

                //Carga teléfonos
                CargarTelefonos();

                //Llena los Textbox
                tbNombres.Text = dtInteresado.Rows[index].ItemArray[2].ToString();
                tbApellidos.Text = dtInteresado.Rows[index].ItemArray[3].ToString();
                tbDireccion.Text = dtInteresado.Rows[index].ItemArray[5].ToString();
                tbCorreo.Text = dtInteresado.Rows[index].ItemArray[6].ToString();

                //Registra los valores para la bitacora
                valores[0] = tbNombres.Text;
                valores[1] = tbApellidos.Text;
                valores[2] = tbCorreo.Text;
                valores[3] = tbDireccion.Text;
            }
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

        private void FrmInteresados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}

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
    public partial class FrmAlumnos : Form
    {
        #region Variables
        private BLL.Persona persona = new BLL.Persona();
        private BLL.Alumno alumno = new BLL.Alumno();
        private BLL.Telefono telefono = new BLL.Telefono();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtAlumno = new DataTable();
        private DataTable dtTelefono = new DataTable();

        private int idPersona = 0;
        private int idAlumno = 0;
        private int index = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private string[] valores = new string[7];
        #endregion

        #region Carga
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void HabilitarControles(bool editar)
        {
            dgvAlumnos.Enabled = !editar;

            tbNombres.ReadOnly = !editar;
            tbApellidos.ReadOnly = !editar;
            tbCorreo.ReadOnly = !editar;
            tbDireccion.ReadOnly = !editar;
            tbNumDocumento.ReadOnly = !editar;
            tbNacionalidad.ReadOnly = !editar;

            cmbTipoDocumento.Enabled = editar;

            bGuardar.Visible = editar;
            bCancelar.Visible = editar;

            bAgregar.Enabled = !editar;
            bEliminar.Enabled = !editar;
            bEditar.Enabled = !editar;
            dgvTelefonos.Enabled = editar;
            bEditarTelf.Visible = !editar;

            if (accionActual == "agregar")
            {
                tbNombres.Text = string.Empty;
                tbApellidos.Text = string.Empty;
                tbCorreo.Text = string.Empty;
                tbDireccion.Text = string.Empty;
                tbNacionalidad.Text = string.Empty;
                tbNumDocumento.Text = string.Empty;
                cmbTipoDocumento.SelectedIndex = 0;
                dgvTelefonos.DataSource = null;
                cargado = false;
                dgvAlumnos.ClearSelection();
                cargado = true;
            }
        }

        private void Cargar()
        {
            //Carga la lista de alumnos
            dgvAlumnos.DataSource = null;
            dtAlumno = alumno.Listar();
            dgvAlumnos.DataSource = dtAlumno;
            dgvAlumnos.Refresh();

            //Dar formato al datagrid
            dgvAlumnos.Columns.Remove("idPersona");
            dgvAlumnos.Columns.Remove("idAlumno");
            dgvAlumnos.Columns.Remove("correo");
            dgvAlumnos.Columns.Remove("direccion");
            dgvAlumnos.Columns.Remove("tipoDocumento");
            dgvAlumnos.Columns.Remove("nacionalidad");

            dgvAlumnos.Columns[0].Width = 250;
            dgvAlumnos.Columns[1].Width = 200;

            dgvAlumnos.Columns[0].HeaderText = "Nombres";
            dgvAlumnos.Columns[1].HeaderText = "Apellidos";
            dgvAlumnos.Columns[2].HeaderText = "Documento";

            //Carga el combobox
            cmbTipoDocumento.Items.Clear();
            cmbTipoDocumento.Items.Add("CI");
            cmbTipoDocumento.Items.Add("Pasaporte");

            if (dgvAlumnos.Rows.Count > 0)
            {
                dgvAlumnos.Rows[0].Selected = true;
                dgvAlumnos.Rows[0].Selected = false;
            }

            DeshabilitarOrdenamiento();
            cargado = true;
        }

        private void CargarTelefonos()
        {
            dtTelefono = telefono.Listar(idPersona);
            dgvTelefonos.DataSource = null;
            dgvTelefonos.DataSource = dtTelefono;
            dgvTelefonos.Columns.Remove("idPersona");
            dgvTelefonos.Columns.Remove("idTelefono");
            dgvTelefonos.Columns[1].HeaderText = "Tipo";
            dgvTelefonos.Columns[1].Width = 125;
            dgvTelefonos.Refresh();
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvAlumnos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            foreach (DataGridViewColumn dgvc in dgvTelefonos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion

        #region Botones
        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Guarda los ids seleccionados
                index = dgvAlumnos.SelectedRows[0].Index;
                idPersona = Convert.ToInt32(dtAlumno.Rows[index].ItemArray[0].ToString());
                idAlumno = Convert.ToInt32(dtAlumno.Rows[index].ItemArray[1].ToString());

                //Llena los textbox
                tbNombres.Text = dtAlumno.Rows[index].ItemArray[2].ToString();
                tbApellidos.Text = dtAlumno.Rows[index].ItemArray[3].ToString();
                tbCorreo.Text = dtAlumno.Rows[index].ItemArray[4].ToString();
                tbDireccion.Text = dtAlumno.Rows[index].ItemArray[5].ToString();
                tbNacionalidad.Text = dtAlumno.Rows[index].ItemArray[8].ToString();
                tbNumDocumento.Text = dtAlumno.Rows[index].ItemArray[7].ToString();

                //Selecciona el index del combo
                if (dtAlumno.Rows[index].ItemArray[6].ToString().Equals("CI"))
                    cmbTipoDocumento.SelectedIndex = 0;
                else
                    cmbTipoDocumento.SelectedIndex = 1;

                CargarTelefonos();

                //Registra los valores para la bitacora
                valores[0] = tbNombres.Text;
                valores[1] = tbApellidos.Text;
                valores[2] = tbCorreo.Text;
                valores[3] = tbDireccion.Text;
                valores[4] = tbNacionalidad.Text;
                valores[5] = tbNumDocumento.Text;
                valores[6] = cmbTipoDocumento.SelectedItem.ToString();
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            HabilitarControles(true);
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count.Equals(1))
            {
                accionActual = "editar";
                HabilitarControles(true);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            accionActual = string.Empty;
            HabilitarControles(false);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            byte[] pic = new byte[0];

            switch (accionActual)
            {
                case "agregar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        persona.Nombres = tbNombres.Text;
                        persona.Apellidos = tbApellidos.Text;

                        string error = persona.ControlCampos();

                        alumno.Correo = tbCorreo.Text;
                        alumno.Direccion = tbDireccion.Text;
                        alumno.NumeroDocumento = tbNumDocumento.Text;
                        alumno.Nacionalidad = tbNacionalidad.Text;

                        error += alumno.ControlCampos();

                        if (error == string.Empty)
                        {
                            //inserta en la base de datos
                            alumno.TipoDocumento = cmbTipoDocumento.SelectedItem.ToString();

                            Properties.Resources.imgPerfil.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            pic = stream.ToArray();
                            persona.Foto = pic;

                            idPersona = persona.Insertar();

                            alumno.IdPersona = idPersona;

                            alumno.Insertar();

                        }
                        else
                        {
                            MessageBox.Show(error);
                        }
                    }break;

                case "editar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        persona.Nombres = tbNombres.Text;
                        persona.Apellidos = tbApellidos.Text;

                        string error = persona.ControlCampos();

                        alumno.IdPersona = idPersona;
                        alumno.Correo = tbCorreo.Text;
                        alumno.Direccion = tbDireccion.Text;
                        alumno.NumeroDocumento = tbNumDocumento.Text;
                        alumno.Nacionalidad = tbNacionalidad.Text;

                        error += alumno.ControlCampos();

                        if (error == string.Empty)
                        {
                            //actualiza la base de datos
                            alumno.TipoDocumento = cmbTipoDocumento.SelectedItem.ToString();

                            Properties.Resources.imgPerfil.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            pic = stream.ToArray();
                            persona.Foto = pic;

                            persona.IdPersona = idPersona;
                            alumno.IdAlumno = idAlumno;

                            persona.Actualizar();
                            alumno.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Persona", "Nombres", 0, tbNombres.Text);
                            InsertarBitacora("Editar", "Persona", "Apellidos", 1, tbApellidos.Text);
                            InsertarBitacora("Editar", "Alumno", "Correo", 2, tbCorreo.Text);
                            InsertarBitacora("Editar", "Alumno", "Direccion", 3, tbDireccion.Text);
                            InsertarBitacora("Editar", "Alumno", "Nacionalidad", 4, tbNacionalidad.Text);
                            InsertarBitacora("Editar", "Alumno", "NumeroDocumento", 5, tbNumDocumento.Text);
                            InsertarBitacora("Editar", "Alumno", "TipoDocumento", 6, cmbTipoDocumento.SelectedItem.ToString());
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError);
                        }

                    }break;

                default: break;
            }
            cargado = false;
            Cargar();
            HabilitarControles(false);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    persona.IdPersona = idPersona;
                    alumno.IdAlumno = idAlumno;

                    alumno.Eliminar();
                    persona.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "Persona", "Nombres", 0, "-");
                    InsertarBitacora("Eliminar", "Persona", "Apellidos", 1, "-");
                    InsertarBitacora("Eliminar", "Alumno", "Correo", 2, "-");
                    InsertarBitacora("Eliminar", "Alumno", "Direccion", 3, "-");
                    InsertarBitacora("Eliminar", "Alumno", "Nacionalidad", 4, "-");
                    InsertarBitacora("Eliminar", "Alumno", "NumeroDocumento", 5, "-");
                    InsertarBitacora("Eliminar", "Alumno", "TipoDocumento", 6, "-");

                    cargado = false;
                    Cargar();
                }
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void bEditarTelf_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count.Equals(1))
            {
                FrmTelefonos frm = new FrmTelefonos(idPersona, dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString() + dgvAlumnos.SelectedRows[0].Cells[1].Value.ToString());
                frm.ShowDialog();
                CargarTelefonos();
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FrmAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}

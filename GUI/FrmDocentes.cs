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
    public partial class FrmDocentes : Form
    {
        #region Variables
        private BLL.Docente docente = new BLL.Docente();
        private BLL.Telefono telefono = new BLL.Telefono();
        private BLL.TipoTelefono tipoTelefono = new BLL.TipoTelefono();
        private BLL.Persona persona = new BLL.Persona();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtDocente = new DataTable();
        private DataTable dtTelefono = new DataTable();
        private DataTable dtTipoTelefono = new DataTable();

        private string accionActual = string.Empty;
        private int idPersona;
        private int idDocente;
        private bool cargado = false;
        private string[] valores = new string[7];

        private List<string> listaInicial = new List<string>();
        private List<string> listaFinal = new List<string>();
        #endregion

        #region Carga
        public FrmDocentes()
        {
            InitializeComponent();
        }

        private void FrmDocentes_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            dtDocente = docente.Listar();
            dgvDocentes.DataSource = null;
            dgvDocentes.DataSource = dtDocente;
            dgvDocentes.Refresh();

            dgvDocentes.Columns.Remove("idPersona");
            dgvDocentes.Columns.Remove("idDocente");
            dgvDocentes.Columns.Remove("tipoDocumento");
            dgvDocentes.Columns.Remove("correo");
            dgvDocentes.Columns.Remove("direccion");
            dgvDocentes.Columns.Remove("nacionalidad");
            dgvDocentes.Columns[2].HeaderText = "Documento";

            dgvDocentes.Columns[0].Width = 200;
            dgvDocentes.Columns[1].Width = 200;

            dgvDocentes.ClearSelection();

            dtTipoTelefono = tipoTelefono.Listar();
            dgvTelefonos.DataSource = null;
            dgvTelefonos.Rows.Clear();
            dgvTelefonos.Columns.Clear();
            DeshabilitarOrdenamiento();

            cargado = true;

            cmbTipoDocumento.Items.Clear();
            cmbTipoDocumento.Items.Add("CI");
            cmbTipoDocumento.Items.Add("Pasaporte");

            cmbTipoDocumento.SelectedIndex = 0;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvDocentes.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvTelefonos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void ActivarControles(bool editando)
        {
            tbNombres.ReadOnly = !editando;
            tbApellidos.ReadOnly = !editando;
            tbCorreo.ReadOnly = !editando;
            tbNacionalidad.ReadOnly = !editando;
            tbNumDocumento.ReadOnly = !editando;
            tbDireccion.ReadOnly = !editando;
            bEditarTelf.Visible = !editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;
            bAgregar.Visible = !editando;
            bEditar.Visible = !editando;
            bEliminar.Visible = !editando;
            dgvDocentes.Enabled = !editando;
            dgvTelefonos.Enabled = editando;
            cmbTipoDocumento.Enabled = editando;

            if (accionActual.Equals("agregar"))
            {
                tbNombres.Text = string.Empty;
                tbApellidos.Text = string.Empty;
                tbCorreo.Text = string.Empty;
                tbNacionalidad.Text = string.Empty;
                tbDireccion.Text = string.Empty;
                tbNumDocumento.Text = string.Empty;
                cmbTipoDocumento.SelectedIndex = 0;
                dgvTelefonos.DataSource = null;
                cargado = false;
                dgvDocentes.ClearSelection();
                cargado = true;
            }
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
        #endregion

        #region Botones
        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            ActivarControles(true);    
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.SelectedRows.Count.Equals(1))
            {
                accionActual = "editar";
                ActivarControles(true);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.SelectedRows.Count.Equals(1))
            {
                if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    docente.IdDocente = idDocente;
                    persona.IdPersona = idPersona;
                    docente.Eliminar();
                    persona.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "Persona", "Nombres", 0, "-");
                    InsertarBitacora("Eliminar", "Persona", "Apellidos", 1, "-");
                    InsertarBitacora("Eliminar", "Docente", "Correo", 2, "-");
                    InsertarBitacora("Eliminar", "Docente", "Direccion", 3, "-");
                    InsertarBitacora("Eliminar", "Docente", "Nacionalidad", 4, "-");
                    InsertarBitacora("Eliminar", "Docente", "NumDocumento", 5, "-");
                    InsertarBitacora("Eliminar", "Docente", "TipoDocumento", 6, "-");

                    //Resetea Los Textbox
                    tbApellidos.Text = string.Empty;
                    tbCorreo.Text = string.Empty;
                    tbDireccion.Text = string.Empty;
                    tbNacionalidad.Text = string.Empty;
                    tbNombres.Text = string.Empty;
                    tbNumDocumento.Text = string.Empty;
                    cmbTipoDocumento.SelectedIndex = 0;

                    cargado = false;
                    Cargar();
                }
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void dgvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            int index = 0;
            if (cargado)
            {
                //recupera los datos del indice seleccionado
                for (int i = 0; i < dgvDocentes.Rows.Count; ++i)
                    if (dgvDocentes.SelectedRows[0].Cells[2].Value.Equals(dtDocente.Rows[i].ItemArray[4].ToString()))
                    {
                        idDocente = Convert.ToInt32(dtDocente.Rows[i].ItemArray[1].ToString());
                        idPersona = Convert.ToInt32(dtDocente.Rows[i].ItemArray[0].ToString());
                        index = i;
                    }
                tbNombres.Text = dtDocente.Rows[index].ItemArray[2].ToString();
                tbApellidos.Text = dtDocente.Rows[index].ItemArray[3].ToString();
                tbNumDocumento.Text = dtDocente.Rows[index].ItemArray[4].ToString();
                tbCorreo.Text = dtDocente.Rows[index].ItemArray[6].ToString();
                tbDireccion.Text = dtDocente.Rows[index].ItemArray[7].ToString();
                tbNacionalidad.Text = dtDocente.Rows[index].ItemArray[8].ToString();

                cmbTipoDocumento.SelectedItem = dtDocente.Rows[index].ItemArray[5].ToString();


                //Carga los teléfonos de la persona
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

        private void bAgregarTelf_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.SelectedRows.Count.Equals(1))
            {
                FrmTelefonos frm = new FrmTelefonos(idPersona, dgvDocentes.SelectedRows[0].Cells[0].Value.ToString() + dgvDocentes.SelectedRows[0].Cells[1].Value.ToString());
                frm.ShowDialog();
                CargarTelefonos();
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            BLL.CtrlDocente ctrlDoc = new BLL.CtrlDocente();
            MemoryStream stream = new MemoryStream();
            byte[] pic = new byte[0];

            //Setear las variables a ser controladas
            ctrlDoc.Nombres = tbNombres.Text;
            ctrlDoc.Apellidos = tbApellidos.Text;
            ctrlDoc.Correo = tbCorreo.Text;
            ctrlDoc.Direccion = tbDireccion.Text;
            ctrlDoc.NumeroDocumento = tbNumDocumento.Text;
            ctrlDoc.Nacionalidad = tbNacionalidad.Text;
            
            string error;
            error = ctrlDoc.DetectarErrores();

            switch (accionActual)
            {
                case "agregar":
                    {
                        if (error.Equals(string.Empty))
                        {
                            //se ingresa la informacion en la BDD
                            //Empezando por persona
                            persona.Nombres = tbNombres.Text;
                            persona.Apellidos = tbApellidos.Text;
                            //foto por defecto
                            Properties.Resources.imgPerfil.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            pic = stream.ToArray();
                            persona.Foto = pic;
                            idPersona = persona.Insertar();

                            //ingresa docente
                            docente.IdPersona = idPersona;
                            docente.Correo = tbCorreo.Text;
                            docente.Direccion = tbDireccion.Text;
                            docente.NumDocumento = tbNumDocumento.Text;
                            docente.TipoDocumento = cmbTipoDocumento.SelectedItem.ToString();
                            docente.Nacionalidad = tbNacionalidad.Text;

                            docente.Insertar();
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
                        }
                    }break;

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

                            //actualiza docente
                            docente.IdDocente = idDocente;
                            docente.IdPersona = idPersona;
                            docente.Correo = tbCorreo.Text;
                            docente.Direccion = tbDireccion.Text;
                            docente.NumDocumento = tbNumDocumento.Text;
                            docente.TipoDocumento = cmbTipoDocumento.SelectedItem.ToString();
                            docente.Nacionalidad = tbNacionalidad.Text;

                            docente.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Persona", "Nombres", 0, tbNombres.Text);
                            InsertarBitacora("Editar", "Persona", "Apellidos", 1, tbApellidos.Text);
                            InsertarBitacora("Editar", "Docente", "Correo", 2, tbCorreo.Text);
                            InsertarBitacora("Editar", "Docente", "Direccion", 3, tbDireccion.Text);
                            InsertarBitacora("Editar", "Docente", "Nacionalidad", 4, tbNacionalidad.Text);
                            InsertarBitacora("Editar", "Docente", "NumeroDocumento", 5, tbNumDocumento.Text);
                            InsertarBitacora("Editar", "Docente", "TipoDocumento", 6, cmbTipoDocumento.SelectedItem.ToString());
                            }
                    } break;
            }

            ActivarControles(false);
            cargado = false;
            Cargar();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            accionActual = string.Empty;
            ActivarControles(false);
            cargado = false;
            Cargar();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }
        #endregion 

        #region Otro Métodos
        private void FrmDocentes_FormClosing(object sender, FormClosingEventArgs e)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FrmUsuarios : Form
    {
        #region Variables
        private BLL.Usuario usr = new BLL.Usuario();
        private BLL.Controladora ctrl = new Controladora();
        private BLL.Persona prs = new Persona();
        private BLL.Autenticacion aut = new Autenticacion();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtUsuario = new DataTable();

        private string accionActual = string.Empty;
        private bool camposVacios = true;
        private bool campoCorreo = true;
        private bool campoPass = true;
        private bool nombreValido = true;
        private bool apellidoValido = true;
        private int idPersona;
        private int idUsuario;
        private bool cargado = false;
        private bool loginRepetido = false;
        private int index = 0;
        private string[] valores = new string[5];
        #endregion

        #region Carga del Formulario
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            dgvUsuarios.DataSource = usr.TablaVisualUsuario();
            dtUsuario = usr.TablaCompletaUsuario();
            cmbNivel.Items.Add("Usuario");
            cmbNivel.Items.Add("Administrador");
            ActivarControles(false);

            DeshabilitarOrdenamiento();

            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvUsuarios.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void ActivarControles(bool editando)
        {
            bResetear.Visible = editando;
            tbNombres.ReadOnly = !editando;
            tbApellidos.ReadOnly = !editando;
            tbCorreo.ReadOnly = !editando;
            tbLogin.ReadOnly = !editando;
            cmbNivel.Enabled = editando;
            linkCambiarImagen.Enabled = editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;
            bAgregar.Visible = !editando;
            bEditar.Visible = !editando;
            bEliminar.Visible = !editando;
            dgvUsuarios.Enabled = !editando;

            if (accionActual.Equals("agregar"))
            {
                tbNombres.Text = string.Empty;
                tbApellidos.Text = string.Empty;
                tbCorreo.Text = string.Empty;
                tbLogin.Text = string.Empty;
                tbPass.ReadOnly = !editando;
                tbPass.Text = string.Empty;
                pbFoto.BackgroundImage = Properties.Resources.imgPerfil;
                cmbNivel.SelectedIndex = 0;
            }
        }
        #endregion

        #region Tratamiento de Imágenes
        private void linkCambiarImagen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdBuscarImagen.Filter = "Imagenes (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofdBuscarImagen.InitialDirectory = @"C:\";
            ofdBuscarImagen.Title = "Seleccione su imagen de perfil";
            if (ofdBuscarImagen.ShowDialog() == DialogResult.OK)
            {
                pbFoto.BackgroundImage = new Bitmap(ofdBuscarImagen.FileName);
                pbFoto.BackgroundImage = resizeImage(pbFoto.BackgroundImage);
            }
        }

        private static Image resizeImage(Image imgToResize)
        {
            
            Bitmap b = new Bitmap(150, 150);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, 150, 150);
            g.Dispose();

            return (Image)b;
        }
        #endregion

        #region Botones
        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            ActivarControles(true);            
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            byte[] pic = new byte[0];
            switch (accionActual)
            {
                case "agregar":
                    {
                        //comprueba que todos los campos esten llenos
                        camposVacios = ctrl.CampoVacio(tbNombres.Text);
                        if(camposVacios)
                            camposVacios = ctrl.CampoVacio(tbApellidos.Text);
                        if (camposVacios)
                            camposVacios = ctrl.CampoVacio(tbCorreo.Text);
                        if (camposVacios)
                            camposVacios = ctrl.CampoVacio(tbLogin.Text);
                        if (camposVacios)
                            camposVacios = ctrl.CampoVacio(tbPass.Text);
                        if (camposVacios)
                        {
                            //comprueba que se haya ingresado un correo válido
                            campoCorreo = ctrl.CampoCorreo(tbCorreo.Text);

                            //comprueba que la contraseña sea válida
                            campoPass = ctrl.CampoContraseña(tbPass.Text);

                            //comprueba que no exista números en nombre y apellido
                            nombreValido = ctrl.CampoSinNumeros(tbNombres.Text);
                            apellidoValido = ctrl.CampoSinNumeros(tbNombres.Text);
                        }

                        if (!camposVacios)
                            MessageBox.Show(Mensajes.msjCampoVacio, Mensajes.capError, MessageBoxButtons.OK);
                        else if (!campoCorreo)
                            MessageBox.Show(Mensajes.msjCorreoIncorrecto, Mensajes.capError, MessageBoxButtons.OK);
                        else if (!campoPass)
                            MessageBox.Show(Mensajes.msjPassInvalido, Mensajes.capError, MessageBoxButtons.OK);
                        else if (!nombreValido)
                            MessageBox.Show(Mensajes.msjNombreIncorrecto, Mensajes.capError, MessageBoxButtons.OK);
                        else if (!apellidoValido)
                            MessageBox.Show(Mensajes.msjApellidoIncorrecto, Mensajes.capError, MessageBoxButtons.OK);
                        else
                        {
                            //busca si ya existe un login idéntico
                            for (int i = 0; i < dgvUsuarios.Rows.Count; ++i)
                                if (tbLogin.Text.Equals(dgvUsuarios.Rows[i].Cells[3].Value.ToString()))
                                    loginRepetido = true;
                            if (loginRepetido)
                                MessageBox.Show(Mensajes.msjLoginRepetido, Mensajes.capError, MessageBoxButtons.OK);
                            else
                            {
                                //Ingresa primeramente la información de persona
                                prs.Nombres = tbNombres.Text;
                                prs.Apellidos = tbApellidos.Text;
                                pbFoto.BackgroundImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                                pic = stream.ToArray();
                                prs.Foto = pic;

                                idPersona = prs.Insertar();

                                //Ingresa información de usuario

                                usr.IdPersona = idPersona;
                                if (cmbNivel.SelectedIndex == 0)
                                    usr.IdNivel = 1;
                                else
                                    usr.IdNivel = 2;
                                usr.Correo = tbCorreo.Text;
                                usr.Login = tbLogin.Text;
                                usr.Password = aut.HashPassword(tbPass.Text);

                                usr.Insertar();
                            }
                        }
                    }break;
                case "editar":
                    {
                        //comprueba que todos los campos esten llenos
                        camposVacios = ctrl.CampoVacio(tbNombres.Text);
                        if (camposVacios)
                            camposVacios = ctrl.CampoVacio(tbApellidos.Text);
                        if (camposVacios)
                            camposVacios = ctrl.CampoVacio(tbCorreo.Text);
                        if (camposVacios)
                            camposVacios = ctrl.CampoVacio(tbLogin.Text);
                        if (camposVacios)
                            camposVacios = ctrl.CampoVacio(tbPass.Text);
                        if (camposVacios)
                        {
                            //comprueba que se haya ingresado un correo válido
                            campoCorreo = ctrl.CampoCorreo(tbCorreo.Text);

                            //comprueba que no exista números en nombre y apellido
                            nombreValido = ctrl.CampoSinNumeros(tbNombres.Text);
                            apellidoValido = ctrl.CampoSinNumeros(tbNombres.Text);
                        }

                        if (!camposVacios)
                            MessageBox.Show(Mensajes.msjCampoVacio, Mensajes.capError, MessageBoxButtons.OK);
                        else if (!campoCorreo)
                            MessageBox.Show(Mensajes.msjCorreoIncorrecto, Mensajes.capError, MessageBoxButtons.OK);
                        else if (!campoPass)
                            MessageBox.Show(Mensajes.msjPassInvalido, Mensajes.capError, MessageBoxButtons.OK);
                        else if (!nombreValido)
                            MessageBox.Show(Mensajes.msjNombreIncorrecto, Mensajes.capError, MessageBoxButtons.OK);
                        else if (!apellidoValido)
                            MessageBox.Show(Mensajes.msjApellidoIncorrecto, Mensajes.capError, MessageBoxButtons.OK);
                        else
                        {
                            //Ingresa primeramente la información de persona
                            prs.IdPersona = idPersona;
                            prs.Nombres = tbNombres.Text;
                            prs.Apellidos = tbApellidos.Text;
                            pbFoto.BackgroundImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            pic = stream.ToArray();
                            prs.Foto = pic;

                            prs.Actualizar();

                            //Ingresa información de usuario

                            usr.IdUsuario = idUsuario;
                            usr.IdPersona = idPersona;
                            if (cmbNivel.SelectedIndex == 0)
                                usr.IdNivel = 1;
                            else
                                usr.IdNivel = 2;
                            usr.Correo = tbCorreo.Text;
                            usr.Login = tbLogin.Text;
                            usr.Password = tbPass.Text;

                            usr.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "Persona", "Nombres", 0, tbNombres.Text);
                            InsertarBitacora("Editar", "Persona", "Apellidos", 1, tbApellidos.Text);
                            InsertarBitacora("Editar", "Alumno", "Correo", 2, tbCorreo.Text);
                            InsertarBitacora("Editar", "Alumno", "Login", 3, tbLogin.Text);
                            InsertarBitacora("Editar", "Alumno", "Nivel", 4, cmbNivel.SelectedItem.ToString());
                        }
                    } break;
            }
            if (!loginRepetido)
            {
                ActivarControles(false);
                cargado = false;
                Cargar();
                loginRepetido = false;
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            
            byte[] datosFoto = new byte[0];
            if (dgvUsuarios.GetCellCount(DataGridViewElementStates.Selected) == 4 && cargado)
            {
                for (int i = 0; i < dgvUsuarios.Rows.Count; ++i)
                    if (dgvUsuarios.SelectedRows[0].Cells[3].Value.Equals(dtUsuario.Rows[i].ItemArray[5].ToString()))
                    {
                        idUsuario = Convert.ToInt32(dtUsuario.Rows[i].ItemArray[8].ToString());
                        idPersona = Convert.ToInt32(dtUsuario.Rows[i].ItemArray[7].ToString());
                        index = i;
                    }
                tbNombres.Text = dtUsuario.Rows[index].ItemArray[0].ToString();
                tbApellidos.Text = dtUsuario.Rows[index].ItemArray[1].ToString();

                datosFoto = (byte[])dtUsuario.Rows[index].ItemArray[2];
                MemoryStream stream = new MemoryStream(datosFoto);
                pbFoto.BackgroundImage = Image.FromStream(stream);

                tbCorreo.Text = dtUsuario.Rows[index].ItemArray[3].ToString();

                if (Convert.ToInt32(dtUsuario.Rows[index].ItemArray[4].ToString()) == 2)
                    cmbNivel.SelectedIndex = 1;
                else
                    cmbNivel.SelectedIndex = 0;

                tbLogin.Text = dtUsuario.Rows[index].ItemArray[5].ToString();
                tbPass.Text = dtUsuario.Rows[index].ItemArray[6].ToString();

                //Registra los valores para la bitacora
                valores[0] = tbNombres.Text;
                valores[1] = tbApellidos.Text;
                valores[2] = tbCorreo.Text;
                valores[3] = tbLogin.Text;
                valores[4] = cmbNivel.SelectedItem.ToString();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            ActivarControles(false);
            dgvUsuarios.ClearSelection();
        }
        
        private void bEditar_Click(object sender, EventArgs e)
        {
            accionActual = "editar";
            ActivarControles(true);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(Mensajes.msjEliminarRegistro, Mensajes.capWarning, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usr.IdUsuario = idUsuario;
                    prs.IdPersona = idPersona;
                    usr.Eliminar();
                    prs.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "Persona", "Nombres", 0, "-");
                    InsertarBitacora("Eliminar", "Persona", "Apellidos", 1, "-");
                    InsertarBitacora("Eliminar", "Usuario", "Correo", 2, "-");
                    InsertarBitacora("Eliminar", "Usuario", "Login", 3, "-");
                    InsertarBitacora("Eliminar", "Usuario", "Nivel", 4, "-");

                    cargado = false;
                    Cargar();
                }
            }
        }

        private void bResetear_Click(object sender, EventArgs e)
        {
            usr.IdUsuario = idUsuario;
            usr.IdPersona = idPersona;
            usr.Correo = dtUsuario.Rows[index].ItemArray[3].ToString();
            usr.Login = dtUsuario.Rows[index].ItemArray[5].ToString();
            //Resetea el password a 0000
            usr.Password = aut.HashPassword("0000");

            usr.Actualizar();

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

        #region Otros Métodos
        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
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
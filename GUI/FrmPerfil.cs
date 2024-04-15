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
    public partial class FrmPerfil : Form
    {
        #region Variables y Carga del Form
        BLL.Controladora ctrl = new Controladora();
        BLL.Autenticacion aut = new Autenticacion();
        BLL.Usuario usr = new Usuario();
        BLL.Persona prs = new Persona();
        BLL.CtrlPerfil ctrlPerfil = new BLL.CtrlPerfil();

        private string errores = string.Empty;

        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            tbNombres.Text = SesionActual.Nombres;
            tbApellidos.Text = SesionActual.Apellidos;
            tbCorreo.Text = SesionActual.Correo;
            tbLogin.Text = SesionActual.Login;
            MemoryStream stream = new MemoryStream(SesionActual.foto);
            pbFoto.BackgroundImage = Image.FromStream(stream);
        }
        #endregion

        #region Botones
        private void bEditarPersonal_Click(object sender, EventArgs e)
        {
            if (!tbNombres.ReadOnly)
                bEditarPersonal.BackgroundImage = Properties.Resources.imgNoEditarMini;
            else
                bEditarPersonal.BackgroundImage = Properties.Resources.imgEditarMini;
            tbNombres.ReadOnly =  !tbNombres.ReadOnly;
            tbApellidos.ReadOnly = !tbApellidos.ReadOnly;
        }

        private void bEditarCuenta_Click(object sender, EventArgs e)
        {
            if (!tbCorreo.ReadOnly)
                bEditarCuenta.BackgroundImage = Properties.Resources.imgNoEditarMini;
            else
                bEditarCuenta.BackgroundImage = Properties.Resources.imgEditarMini;

            tbCorreo.ReadOnly = !tbCorreo.ReadOnly;
            tbLogin.ReadOnly = !tbLogin.ReadOnly;
            linkCambiarImagen.Enabled = !linkCambiarImagen.Enabled;
        }

        private void bEditarPass_Click(object sender, EventArgs e)
        {
            if (!tbPassActual.ReadOnly)
                bEditarPass.BackgroundImage = Properties.Resources.imgNoEditarMini;
            else
                bEditarPass.BackgroundImage = Properties.Resources.imgEditarMini;
            tbPassActual.ReadOnly = !tbPassActual.ReadOnly;
            tbPassNuevo1.ReadOnly = !tbPassNuevo1.ReadOnly;
            tbPassNuevo2.ReadOnly = !tbPassNuevo2.ReadOnly;
            tbPassActual.Text = "";
            tbPassNuevo1.Text = "";
            tbPassNuevo2.Text = "";
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            errores = string.Empty;
            MemoryStream stream = new MemoryStream();
            byte[] pic = new byte[0];

            //Manda a la clase a controlar los errores, dependiendo de que se modificó
            if (!tbNombres.ReadOnly)
            {
                //Controla y Actualiza solo la persona
                ctrlPerfil.Nombres = tbNombres.Text;
                ctrlPerfil.Apellidos = tbApellidos.Text;
                errores = ctrlPerfil.DetectarErroresPersona();
            }

            if (!tbLogin.ReadOnly)
            {
                //Controla y Actualiza solo al usuario
                ctrlPerfil.Login = tbLogin.Text;
                ctrlPerfil.Correo = tbCorreo.Text;
                errores += ctrlPerfil.DetectarErroresUsuario();
            }

            if (!tbPassActual.ReadOnly)
            {
                //Controla y Actualiza solo la contraseña
                ctrlPerfil.PassActual = aut.HashPassword(tbPassActual.Text);
                ctrlPerfil.Pass1 = tbPassNuevo1.Text;
                ctrlPerfil.Pass2 = tbPassNuevo2.Text;
                errores += ctrlPerfil.DetectarErroresPass();
            }

            if (!errores.Equals(string.Empty))
                MessageBox.Show("Se produjeron los siguientes errores:\n" + errores, Mensajes.capError, MessageBoxButtons.OK);
            else
            {
                //Actualiza la persona
                prs.Nombres = tbNombres.Text;
                prs.Apellidos = tbApellidos.Text;
                pbFoto.BackgroundImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                pic = stream.ToArray();
                prs.Foto = pic;
                prs.IdPersona = SesionActual.IdPersona;

                prs.Actualizar();

                //Actualiza el usuario sin pass
                if (tbPassNuevo1.ReadOnly)
                {
                    usr.IdUsuario = SesionActual.IdUsuario;
                    usr.IdPersona = SesionActual.IdPersona;
                    usr.IdNivel = SesionActual.IdNivel;
                    usr.Correo = tbCorreo.Text;
                    usr.Login = tbLogin.Text;
                    usr.Password = SesionActual.Password;
                }

                //Actualiza el usuario con pass
                if (!tbPassNuevo1.ReadOnly)
                {
                    usr.IdUsuario = SesionActual.IdUsuario;
                    usr.IdPersona = SesionActual.IdPersona;
                    usr.IdNivel = SesionActual.IdNivel;
                    usr.Correo = tbCorreo.Text;
                    usr.Login = tbLogin.Text;
                    usr.Password = aut.HashPassword(tbPassNuevo1.Text);
                }

                usr.Actualizar();

                //Actualiza la sesion actual
                SesionActual.Nombres = tbNombres.Text;
                SesionActual.Apellidos = tbApellidos.Text;
                SesionActual.Correo = tbCorreo.Text;
                SesionActual.Login = tbLogin.Text;
                SesionActual.Password = tbPassNuevo1.Text;
                SesionActual.foto = pic;
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Cambios de Texto

        private void tbPassNuevo1_TextChanged(object sender, EventArgs e)
        {
            pbPass.Value = ctrl.FuerzaContraseña(tbPassNuevo1.Text) * 10;
            if (ctrl.CampoContraseña(tbPassNuevo1.Text))
                pbNuevoPass1.BackgroundImage = Properties.Resources.imgOK;
            else
                pbNuevoPass1.BackgroundImage = Properties.Resources.imgWrong;
        }

        private void tbPassNuevo2_TextChanged(object sender, EventArgs e)
        {
            if(ctrl.CamposIguales(tbPassNuevo1.Text, tbPassNuevo2.Text))
                pbNuevoPass2.BackgroundImage = Properties.Resources.imgOK;
            else
                pbNuevoPass2.BackgroundImage = Properties.Resources.imgWrong;
        }

        private void tbPassActual_TextChanged(object sender, EventArgs e)
        {
            if(SesionActual.Password.Equals(aut.HashPassword(tbPassActual.Text)))
                pbPassActual.BackgroundImage = Properties.Resources.imgOK;
            else
                pbPassActual.BackgroundImage = Properties.Resources.imgWrong;
        }
        #endregion 

        #region Tratado de Imágen
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

        private void FrmPerfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

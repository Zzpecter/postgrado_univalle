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
    public partial class FrmPasswordReset : Form
    {
        #region Variables
        private BLL.Usuario usuario = new BLL.Usuario();
        private BLL.Autenticacion aut = new BLL.Autenticacion();
        private BLL.Controladora ctrl = new BLL.Controladora();

        private DataTable dtUsuario = new DataTable();
        #endregion

        #region Carga
        public FrmPasswordReset()
        {
            InitializeComponent();
        }

        private void FrmPasswordReset_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            usuario.IdUsuario = BLL.SesionActual.IdUsuario;
            usuario.IdPersona = BLL.SesionActual.IdPersona;
            usuario.Correo = BLL.SesionActual.Correo;
            usuario.Login = BLL.SesionActual.Login;
        }
        #endregion

        #region Botones
        private void bGuardar_Click(object sender, EventArgs e)
        {
            string errores = string.Empty;
            errores = usuario.ControlPass(tbPass2.Text);
            if (errores.Equals(string.Empty))
            {
                //Se hashea la contraseña y se guarda
                usuario.Password = aut.HashPassword(tbPass1.Text);
                BLL.SesionActual.Password = usuario.Password;

                //Se guarda en la base de datos
                usuario.Actualizar();
                this.Hide();
            }
            else
            {
                tbPass1.Text = string.Empty;
                tbPass2.Text = string.Empty;
                MessageBox.Show(errores, BLL.Mensajes.capError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPasswordReset_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}

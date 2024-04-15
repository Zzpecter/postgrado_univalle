using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FrmAutenticacion : Form
    {
        #region Variables
        private BLL.Autenticacion bll = new Autenticacion();
        private BLL.Controladora ctrl = new Controladora();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private string[] valores = new string[7];
        #endregion

        #region Carga
        public FrmAutenticacion()
        {
            InitializeComponent();
        }

        private void FrmAutenticacion_Load(object sender, EventArgs e)
        {
            string estado = bll.ConexionActual();
            if (estado.Equals("Conectado Correctamente a la base de datos"))
                lblConectado.Text = estado;
            else
            {
                lblConectado.Text = "No se pudo establecer conexión con la base de datos";
                MessageBox.Show(estado);
                bIngresar.Enabled = false;
            }
        }
        #endregion

        #region Botones
        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void bConfig_Click(object sender, EventArgs e)
        {
            FrmConexion configConexion = new FrmConexion();
            configConexion.Show();
            this.Hide();
        }
        #endregion

        #region Otros Métodos
        private void Ingresar()
        {
            if (ctrl.CampoVacio(tbLogin.Text) && ctrl.CampoVacio(tbPass.Text))
            {
                string pass = bll.HashPassword(tbPass.Text);
                string res = bll.BuscarUsuario(tbLogin.Text, pass);

                if (res.Equals(string.Empty))
                {
                    //Registra en la Bitácora
                    InsertarBitacora();

                    //Abre el menu Principal
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    InsertarBitacoraFallo();
                    MessageBox.Show(res, Mensajes.capError, MessageBoxButtons.OK);
                }
            }
            else if (!ctrl.CampoVacio(tbLogin.Text) || !ctrl.CampoVacio(tbPass.Text))
                MessageBox.Show(Mensajes.msjCampoVacio, Mensajes.capError, MessageBoxButtons.OK);
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                Ingresar();
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                Ingresar();
        }

        private void FrmAutenticacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void InsertarBitacora()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = BLL.SesionActual.Login;
            bitacora.Accion = "Inicio de Sesion";
            bitacora.Tabla = "-";
            bitacora.Campo = "-";
            bitacora.ValorAntiguo = "-";
            bitacora.ValorNuevo = "-";
            bitacora.Insertar();
        }

        private void InsertarBitacoraFallo()
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = tbLogin.Text;
            bitacora.Accion = "Inicio Fallido";
            bitacora.Tabla = "-";
            bitacora.Campo = "-";
            bitacora.ValorAntiguo = "-";
            bitacora.ValorNuevo = "-";
            bitacora.Insertar();
        }
        #endregion
    }
}


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
    public partial class FrmPermisos : Form
    {
        #region Variables
        private BLL.Permisos permisos = new BLL.Permisos();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtPermisos = new DataTable();

        private string[] valores = new string[7];
        //Vector que identifica con que valores estaban los campos
        private bool[] estadoInicial = new bool[7];
        #endregion

        #region Carga
        public FrmPermisos()
        {
            InitializeComponent();
        }

        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            CargarPermisos();
        }

        private void CargarPermisos()
        {
            dtPermisos = permisos.Listar();
            cbAbms.Checked = Convert.ToBoolean(dtPermisos.Rows[0].ItemArray[1].ToString());
            cbPostgrados.Checked = Convert.ToBoolean(dtPermisos.Rows[0].ItemArray[2].ToString());
            cbPersonas.Checked = Convert.ToBoolean(dtPermisos.Rows[0].ItemArray[3].ToString());
            cbOfertas.Checked = Convert.ToBoolean(dtPermisos.Rows[0].ItemArray[4].ToString());
            cbInscripciones.Checked = Convert.ToBoolean(dtPermisos.Rows[0].ItemArray[5].ToString());
            cbTramites.Checked = Convert.ToBoolean(dtPermisos.Rows[0].ItemArray[6].ToString());
            cbHorarios.Checked = Convert.ToBoolean(dtPermisos.Rows[0].ItemArray[7].ToString());

            //Carga los valores al vector
            estadoInicial[0] = cbAbms.Checked;
            estadoInicial[1] = cbPostgrados.Checked;
            estadoInicial[2] = cbPersonas.Checked;
            estadoInicial[3] = cbOfertas.Checked;
            estadoInicial[4] = cbInscripciones.Checked;
            estadoInicial[5] = cbTramites.Checked;
            estadoInicial[6] = cbHorarios.Checked;
        }
        #endregion

        #region Botones
        private void bCancelar_Click(object sender, EventArgs e)
        {
            cbAbms.Checked = estadoInicial[0];
            cbPostgrados.Checked = estadoInicial[1];
            cbPersonas.Checked = estadoInicial[2];
            cbOfertas.Checked = estadoInicial[3];
            cbInscripciones.Checked = estadoInicial[4];
            cbTramites.Checked = estadoInicial[5];
            cbHorarios.Checked = estadoInicial[6];
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            permisos.Abms = cbAbms.Checked;
            permisos.Postgrados = cbPostgrados.Checked;
            permisos.Personas = cbPersonas.Checked;
            permisos.Ofertas = cbOfertas.Checked;
            permisos.Inscripciones = cbInscripciones.Checked;
            permisos.Tramites = cbTramites.Checked;
            permisos.Horarios = cbHorarios.Checked;

            //Registra los valores para la bitacora
            valores[0] = estadoInicial[0].ToString();
            valores[1] = estadoInicial[1].ToString();
            valores[2] = estadoInicial[2].ToString();
            valores[3] = estadoInicial[3].ToString();
            valores[4] = estadoInicial[4].ToString();
            valores[5] = estadoInicial[5].ToString();
            valores[6] = estadoInicial[6].ToString();

            //inserta en la bitácora
            InsertarBitacora("Editar", "Permisos", "ABM's", 0, cbAbms.Checked.ToString());
            InsertarBitacora("Editar", "Permisos", "Postgrados", 1, cbAbms.Checked.ToString());
            InsertarBitacora("Editar", "Permisos", "Personas", 2, cbAbms.Checked.ToString());
            InsertarBitacora("Editar", "Permisos", "Ofertas",  3, cbAbms.Checked.ToString());
            InsertarBitacora("Editar", "Permisos", "Inscripciones", 4, cbAbms.Checked.ToString());
            InsertarBitacora("Editar", "Permisos", "Trámites", 5, cbAbms.Checked.ToString());
            InsertarBitacora("Editar", "Permisos", "Horarios", 6, cbAbms.Checked.ToString());

            permisos.Actualizar();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
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

        private void FrmPermisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion 
    }
}

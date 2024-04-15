using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FrmMenuPrincipal : Form
    {
        #region Variables
        private BLL.Notificacion notificacion = new Notificacion();
        private BLL.Autenticacion aut = new Autenticacion();
        private BLL.Permisos permiso = new Permisos();

        private DataTable dtNotificaciones = new DataTable();
        private DataTable dtPermiso = new DataTable();
        #endregion

        #region Carga
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //Coloca el anuncio de bienvenida
            lblAutenticacion.Text = "Bienvenido, " + SesionActual.Nombres + " " + SesionActual.Apellidos + "!";
            
            //Coloca la foto del usuario autenticado
            byte[] datosFoto = new byte[0];
            datosFoto = SesionActual.foto;
            MemoryStream stream = new MemoryStream(datosFoto);
            pbFoto.BackgroundImage = Image.FromStream(stream);

            //Pone la fechay hora actual
            DateTime fecha = DateTime.Today;
            lblFecha.Text = "Sucre, " + fecha.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            tHora.Start();

            VerificarPass();
            CargarPermisos();
            CargarNotificaciones();
        }

        private void VerificarPass()
        {
            string pass = aut.HashPassword("0000");
            if (pass.Equals(SesionActual.Password))
            {
                FrmPasswordReset frm = new FrmPasswordReset();
                frm.ShowDialog();
            }
        }

        private void CargarNotificaciones()
        {
            int cont = 0;
            
            dtNotificaciones = notificacion.VerificarAgenda();
            dtNotificaciones.Merge(notificacion.VerificarMaterias(), true);
            dtNotificaciones.Merge(notificacion.VerificarRecordatorios(), true);
            cont = dtNotificaciones.Rows.Count;
            lblNotificaciones.Text = cont.ToString();
        }

        private void CargarPermisos()
        {
            //Si no es administrador se controla
            if (SesionActual.IdNivel == 1)
            {
                //Ningun usuario tiene acceso a la bitácora ni a la asignacion de permisos
                bBitacora.Visible = false;
                bEditarPermisos.Enabled = false;
                bAgenda.Visible = false;

                //Carga los permisos
                dtPermiso = permiso.Listar();

                if (dtPermiso.Rows[0].ItemArray[1].Equals(false))
                {
                    bCatalogos.Enabled = false;
                    bMaterias.Enabled = false;
                }
                if (dtPermiso.Rows[0].ItemArray[2].Equals(false))
                    bPostgrado.Enabled = false;
                if (dtPermiso.Rows[0].ItemArray[3].Equals(false))
                {
                    bGestionAlumnos.Enabled = false;
                    bGestionDelPersonal.Enabled = false;
                    bGestionEgresados.Enabled = false;
                    bNotas.Enabled = false;
                }
                if (dtPermiso.Rows[0].ItemArray[4].Equals(false))
                    bOfertas.Enabled = false;
                if (dtPermiso.Rows[0].ItemArray[5].Equals(false))
                {
                    bInscribirExistente.Enabled = false;
                    bInscribirNuevo.Enabled = false;
                }
                if (dtPermiso.Rows[0].ItemArray[6].Equals(false))
                {
                    bTramites.Enabled = false;
                    bReportes.Enabled = false;
                }
                if (dtPermiso.Rows[0].ItemArray[7].Equals(false))
                    bAsignarDocentes.Enabled = false;
            }
        }
        #endregion

        #region Timer
        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion

        #region Botones
        private void bPerfil_Click(object sender, EventArgs e)
        {
            tHora.Stop();
            FrmPerfil frm = new FrmPerfil();
            frm.Show();
            this.Hide();
        }

        private void bBitacora_Click(object sender, EventArgs e)
        {
            FrmBitacora bit = new FrmBitacora();
            bit.Show();
            this.Hide();
        }

        private void bAgenda_Click(object sender, EventArgs e)
        {
            FrmAgenda frm = new FrmAgenda();
            frm.Show();
            this.Hide();
        }

        private void bNotificaciones_Click(object sender, EventArgs e)
        {
            FrmNotificaciones frm = new FrmNotificaciones(dtNotificaciones);
            frm.Show();
            this.Hide();
        }
        #endregion 

        #region Botones Menú Superior
        #region Catálogos
        private void bABMAulas_Click(object sender, EventArgs e)
        {
            FrmABMAula frm = new FrmABMAula();
            frm.Show();
            this.Hide();
        }

        private void bABMAreasEspecialidad_Click(object sender, EventArgs e)
        {
            FrmABMEspecialidad frm = new FrmABMEspecialidad();
            frm.Show();
            this.Hide();
        }

        private void bABMEspecialidades_Click(object sender, EventArgs e)
        {
            FrmABMEspecialidades frm = new FrmABMEspecialidades();
            frm.Show();
            this.Hide();
        }

        private void bABMTelefonos_Click(object sender, EventArgs e)
        {
            FrmABMTelefono frm = new FrmABMTelefono();
            frm.Show();
            this.Hide();
        }

        private void bABMTiposAula_Click(object sender, EventArgs e)
        {
            FrmABMTipoAula frm = new FrmABMTipoAula();
            frm.Show();
            this.Hide();
        }
        #endregion Catálogos

        #region Postgrados
        private void bGestionPostgrado_Click(object sender, EventArgs e)
        {
            FrmPostgrados frm = new FrmPostgrados();
            frm.Show();
            this.Hide();
        }

        private void bAsignarDocentes_Click(object sender, EventArgs e)
        {
            FrmAsignarDocente frm = new FrmAsignarDocente();
            frm.Show();
            this.Hide();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMMateria frm = new FrmABMMateria();
            frm.Show();
            this.Hide();
        }
        #endregion Postgrados

        #region Ofertas
        private void bGestionInteresados_Click(object sender, EventArgs e)
        {
            FrmInteresados frm = new FrmInteresados();
            frm.Show();
            this.Hide();
        }

        private void bEnvioOfertas_Click(object sender, EventArgs e)
        {
            FrmOfertas frm = new FrmOfertas();
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Reportes
        private void bReporteInscripciones_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes(1);
            frm.Show();
            this.Hide();
        }

        private void bReporteMateriaNotas_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes(2);
            frm.Show();
            this.Hide();
        }

        private void bReporteDocentes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes(3);
            frm.Show();
            this.Hide();
        }

        private void bReportePostgrados_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes(4);
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Alumnos
        private void inscribirNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInscripcion frm = new FrmInscripcion();
            frm.Show();
            this.Hide();
        }

        private void inscribirExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInscribirAntiguos frm = new FrmInscribirAntiguos();
            frm.Show();
            this.Hide();
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumnos frm = new FrmAlumnos();
            frm.Show();
            this.Hide();
        }

        private void bNotas_Click(object sender, EventArgs e)
        {
            FrmSeleccionPostgrado frm = new FrmSeleccionPostgrado();
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Permisos
        private void bEditarPermisos_Click(object sender, EventArgs e)
        {
            FrmPermisos frm = new FrmPermisos();
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Egresados
        private void bTramites_Click(object sender, EventArgs e)
        {
            FrmTramites frm = new FrmTramites();
            frm.Show();
            this.Hide();
        }

        private void bGestionEgresados_Click(object sender, EventArgs e)
        {
            FrmABMEgresados frm = new FrmABMEgresados();
            frm.Show();
            this.Hide();
        }
        #endregion

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.Show();
            this.Hide();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocentes frm = new FrmDocentes();
            frm.Show();
            this.Hide();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocenteSeleccionar frm = new FrmDocenteSeleccionar();
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Botones para Salir
        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmAutenticacion frm = new FrmAutenticacion();
            frm.Show();
            this.Hide();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible.Equals(false))
                tHora.Stop();
        }
        #endregion

        

        

        

        

        

        

        

        

        

        
    }
}

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
    public partial class FrmInscripcion : Form
    {
        #region variables
        private int idPersona, idAlumno, idPostgrado, idTipoTelefono;

        private DataTable dtPostgrado = new DataTable();
        private DataTable dtTipoTelefono = new DataTable();

        private BLL.Postgrado postgrado = new BLL.Postgrado();
        private BLL.TipoTelefono tipoTelefono = new BLL.TipoTelefono();
        private BLL.Controladora ctrl = new BLL.Controladora();
        private BLL.Persona prs = new BLL.Persona();
        private BLL.Alumno alm = new BLL.Alumno();
        private BLL.Telefono telefono = new BLL.Telefono();
        private BLL.Bitacora bitacora = new BLL.Bitacora();
        private BLL.CtrlInscripcion ctrlInscripcion = new BLL.CtrlInscripcion();
        private BLL.AlumnoPostgrado almPost = new BLL.AlumnoPostgrado();
        #endregion

        #region Carga
        public FrmInscripcion()
        {
            InitializeComponent();
        }

        private void FrmInscripcion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            dtPostgrado = postgrado.Listar();
            dtTipoTelefono = tipoTelefono.Listar();

            cmbDocumento.SelectedIndex = 0;

            //Da formato al datagrid
            dgvTelefonos.Columns.Add("numero", "Número");
            dgvTelefonos.Columns.Add("tipo", "Tipo");
            dgvTelefonos.Columns[0].Width = 150;

            cmbTipo.Items.Clear();
            foreach (DataRow dtr in dtTipoTelefono.Rows)
                cmbTipo.Items.Add(dtr.ItemArray[1].ToString());
            cmbTipo.SelectedIndex = 0;

            for (int i = 0; i < dtPostgrado.Rows.Count; ++i)
                cmbPostgrado.Items.Add(dtPostgrado.Rows[i].ItemArray[1].ToString());
            cmbPostgrado.SelectedIndex = 0;

            DeshabilitarOrdenamiento();
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvTelefonos.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion

        #region Operaciones con Telefonos

        private void bQuitar_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.SelectedRows.Count > 0)
                dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows[0].Index);
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            BLL.Controladora ctrl = new Controladora();
            string errores = string.Empty;

            if (!ctrl.CampoVacio(tbNumero.Text))
                errores = "Ingrese un Número de Teléfono";
            if (!ctrl.CampoNumerico(tbNumero.Text))
                errores += "Solo puede ingresar caracteres numéricos";

            if (errores.Equals(string.Empty))
                dgvTelefonos.Rows.Add(tbNumero.Text, cmbTipo.SelectedItem.ToString());
            else
                MessageBox.Show(errores, BLL.Mensajes.capError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            tbNumero.Text = string.Empty;
        }

        #endregion

        #region Otros Métodos
        private void FrmInscripcion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bInscribir_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            byte[] pic = new byte[0];

            ctrlInscripcion.Nombres = tbNombres.Text;
            ctrlInscripcion.Apellidos = tbApellidos.Text;
            ctrlInscripcion.Nacionalidad = tbNacionalidad.Text;
            ctrlInscripcion.NumeroDocumento = tbNumDocumento.Text;
            ctrlInscripcion.Direccion = tbDireccion.Text;
            ctrlInscripcion.Correo = tbCorreo.Text;

            if (ctrlInscripcion.DetectarErrores().Equals(string.Empty))
            {
                //Inserta los campos en la base de datos, empezando por Persona
                prs.Nombres = tbNombres.Text;
                prs.Apellidos = tbApellidos.Text;
                Properties.Resources.imgPerfil.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                pic = stream.ToArray();
                prs.Foto = pic;

                idPersona = prs.Insertar();

                //Inserta el alumno
                alm.IdPersona = idPersona;
                alm.Correo = tbCorreo.Text;
                alm.Direccion = tbDireccion.Text;
                alm.Nacionalidad = tbNacionalidad.Text;
                alm.TipoDocumento = cmbDocumento.SelectedItem.ToString();
                alm.NumeroDocumento = tbNumDocumento.Text;

                idAlumno = alm.Insertar();

                //Inserta la relacion del alumno con el postgrado

                for (int i = 0; i < dtPostgrado.Rows.Count; ++i)
                    if (cmbPostgrado.SelectedItem.ToString().Equals(dtPostgrado.Rows[i].ItemArray[1]))
                        idPostgrado = Convert.ToInt32(dtPostgrado.Rows[i].ItemArray[0].ToString());

                almPost.IdPostgrado = idPostgrado;
                almPost.IdAlumno = idAlumno;
                almPost.Insertar();

                //Inserta los telefonos si se ingresó alguno
                if (dgvTelefonos.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvTelefonos.Rows.Count; ++i)
                    {
                        for (int j = 0; j < dtTipoTelefono.Rows.Count; ++j)
                            if (dgvTelefonos.Rows[i].Cells[1].Value.ToString().Equals(dtTipoTelefono.Rows[j].ItemArray[1]))
                                idTipoTelefono = Convert.ToInt32(dtTipoTelefono.Rows[i].ItemArray[0].ToString());
                        telefono.IdTipoTelefono = idTipoTelefono;
                        telefono.Numero = dgvTelefonos.Rows[i].Cells[0].Value.ToString();

                        telefono.Insertar(idPersona);
                    }
                }

                FrmMenuPrincipal frm = new FrmMenuPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(ctrlInscripcion.DetectarErrores(), Mensajes.capError, MessageBoxButtons.OK);
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    public partial class FrmNotas : Form
    {
        #region Variables

        //Impresion
        System.IO.StreamReader notasImpresion;
        System.Drawing.Font fuenteImpresion;

        private int idAlumno, idPostgrado;
        private BLL.Postgrado postgrado = new BLL.Postgrado();
        private BLL.Alumno alumno = new BLL.Alumno();
        private BLL.Notas notas = new BLL.Notas();
        private BLL.Egresado egresado = new BLL.Egresado();
        private BLL.AlumnoPostgrado alumnoPostgrado = new BLL.AlumnoPostgrado();
        private BLL.Tramite tramite = new BLL.Tramite();
        private BLL.EstadoTramite estadoTramite = new BLL.EstadoTramite();

        private DataTable dtMaterias = new DataTable();
        private DataTable dtAlumno = new DataTable();
        private DataTable dtNotas = new DataTable();
        DataTable dtAux = new DataTable();

        private bool cargado = false;
        private int index;
        private int idMateria = 0;
        private int idEgresado = 0;
        private int idNota = 0;
        private string accionActual = string.Empty;
        #endregion

        #region Carga
        public FrmNotas()
        {
            InitializeComponent();
        }

        public FrmNotas(int idAlumno, int idPostgrado)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;
            this.idPostgrado = idPostgrado;
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Carga la informacion desde la Base de datos
            postgrado.IdPostgrado = idPostgrado;
            dtAlumno = alumno.Listar();
            dtMaterias = postgrado.SeleccionarMaterias();

            //Ingresa los datos al datagrid
            dgvMaterias.DataSource = null;
            dgvMaterias.DataSource = dtMaterias;
            dgvMaterias.Refresh();

            //Da formato al datagrid
            dgvMaterias.Columns.Remove("idMateria");
            dgvMaterias.Columns.Remove("idPostgrado");
            dgvMaterias.Columns.Remove("idMateriaPostgrado");
            dgvMaterias.Columns.Remove("nombre");
            dgvMaterias.Columns[0].HeaderText = "Materia";
            dgvMaterias.Columns[0].Width = 300;

            //Ingresa el nombre del alumno y del Postgrado seleccionados
            alumno.IdAlumno = idAlumno;
            dtAlumno = alumno.Seleccionar();
            lblAlumno.Text = "Alumno: " + dtAlumno.Rows[0].ItemArray[2].ToString() + " " + dtAlumno.Rows[0].ItemArray[3].ToString();
            lblPostgrado.Text = "Postgrado: " + dtMaterias.Rows[0].ItemArray[4].ToString();

            bGuardar.Visible = false;
            tbNota.Value = 0;
            dgvMaterias.ClearSelection();

            DeshabilitarOrdenamiento();

            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvMaterias.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion 

        #region Botones
        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmSeleccionPostgrado frm = new FrmSeleccionPostgrado();
            frm.Show();
            this.Hide();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            switch (accionActual)
            {
                case "agregar":
                    {
                        //Guarda la nota
                        notas.IdMateria = idMateria;
                        notas.IdAlumno = idAlumno;
                        notas.NotaFinal = tbNota.Value;

                        notas.Insertar();
                    }break;
                case "editar":
                    {
                        //Guarda la nota
                        notas.IdNota = idNota;
                        notas.IdMateria = idMateria;
                        notas.IdAlumno = idAlumno;
                        notas.NotaFinal = tbNota.Value;

                        notas.Actualizar();
                    }break;
                default: break;
            }
            
            //Comprueba si aprobó para pasarlo a egresado
            if (ComprobarEgreso())
            {
                //Genera el documento para Imprimir
                notas.GenerarDocumento(dtAux, (dtAlumno.Rows[0].ItemArray[2].ToString() + " " + dtAlumno.Rows[0].ItemArray[3].ToString()), dtMaterias.Rows[0].ItemArray[4].ToString(), Application.StartupPath);

                //Ingresa a la tabla de egresados
                egresado.IdAlumno = idAlumno;
                egresado.IdPostgrado = idPostgrado;
                egresado.FechaEgreso = DateTime.Today;
                idEgresado = egresado.Insertar();

                //Elimina la relacion del alumno con el postgrado, ya que lo venció
                alumnoPostgrado.IdAlumno = idAlumno;
                alumnoPostgrado.IdPostgrado = idPostgrado;
                alumnoPostgrado.Eliminar();

                //Ingresa la informacion del trámite
                tramite.IdEstadoTramite = 1;
                tramite.IdEgresado = idEgresado;
                tramite.Comentario = "Recién Graduado.";
                tramite.Insertar();

                if (MessageBox.Show("Felicidades al Alumno: " + dtAlumno.Rows[0].ItemArray[2].ToString() + " " + dtAlumno.Rows[0].ItemArray[3].ToString() + " Por Aprobar el Postgrado: " + dtMaterias.Rows[0].ItemArray[4].ToString() + "\nDesea imprimir sus notas?", BLL.Mensajes.capCorrecto, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    notasImpresion = new System.IO.StreamReader(Application.StartupPath + "Notas.txt");
                    fuenteImpresion = new System.Drawing.Font("Arial", 12);
                    pdImpresion.Print();
                    notasImpresion.Close();

                    FrmSeleccionPostgrado frm = new FrmSeleccionPostgrado();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    FrmSeleccionPostgrado frm = new FrmSeleccionPostgrado();
                    frm.Show();
                    this.Hide();
                }
            }

            cargado = false;
            Cargar();
        }
        #endregion

        #region Otros Métodos
        private void dgvMaterias_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                index = dgvMaterias.SelectedRows[0].Index;
                idMateria = Convert.ToInt32(dtMaterias.Rows[index].ItemArray[1].ToString());

                //Consulta la nota del alumno en la materia seleccionada
                notas.IdAlumno = idAlumno;
                notas.IdMateria = idMateria;
                dtNotas = notas.Seleccionar();

                //Si ya se ingresó una nota se la pasa al textbox
                if (dtNotas.Rows.Count > 0)
                {
                    idNota = Convert.ToInt32(dtNotas.Rows[0].ItemArray[0].ToString());
                    tbNota.Value = Convert.ToInt32(dtNotas.Rows[0].ItemArray[3]);
                    accionActual = "editar";
                }
                else
                {
                    tbNota.Value = 0;
                    accionActual = "agregar";
                }
                bGuardar.Visible = true;
            }
        }

        private bool ComprobarEgreso()
        {
            bool egreso = true;
            notas.IdAlumno = idAlumno;

            dtAux = postgrado.SeleccionarMaterias();
            dtAux.Clear();

            //Selecciona una por una las notas del alumno en todas las materias del postgrado
            foreach (DataRow dtr in dtMaterias.Rows)
            {
                notas.IdMateria = Convert.ToInt32(dtr.ItemArray[1]);
                if (notas.Seleccionar().Rows.Count > 0)
                    dtAux.Rows.Add(notas.Seleccionar().Rows[0].ItemArray);
            }

            //Comprueba si egresó
            if (dtAux.Rows.Count.Equals(dtMaterias.Rows.Count))
            {
                foreach (DataRow dtr in dtAux.Rows)
                    if (Convert.ToDecimal(dtr.ItemArray[3].ToString()) < 50)
                        egreso = false;
            }
            else
                egreso = false;
                    

            return egreso;
        }
        #endregion

        private void FrmNotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pdImpresion_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / fuenteImpresion.GetHeight(e.Graphics);
            while (count < linesPerPage)
            {
                line = notasImpresion.ReadLine();
                if (line == null)
                {
                    break;
                }
                yPos = topMargin + count * fuenteImpresion.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, fuenteImpresion, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }
        }
    }
}

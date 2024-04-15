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
    public partial class FrmHorarios : Form
    {
        #region Variables
        private BLL.Materias materias = new BLL.Materias();
        private BLL.Postgrado postgrado = new BLL.Postgrado();
        private BLL.Aula aula = new BLL.Aula();
        private BLL.DetalleMateria detalleMateria = new BLL.DetalleMateria();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtMaterias = new DataTable();
        private DataTable dtAula = new DataTable();
        private DataTable dtClases = new DataTable();
        private DataTable dtDetalleMateria = new DataTable();
       

        private int idDetalleMateria = 0;
        private int idPostgrado = 0;
        private int idMateria = 0;
        private int idAula = 0;
        private bool cargado = false;
        private string[] valores = new string[5];
        #endregion

        #region Carga
        public FrmHorarios(int idPostgrado)
        {
            InitializeComponent();
            this.idPostgrado = idPostgrado;
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            postgrado.IdPostgrado = idPostgrado;
            dtMaterias = postgrado.ListarPostMaterias();
            dtAula = aula.Listar();

            dtpEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today;

            cmbAula.Items.Clear();
            for (int i = 0; i < dtAula.Rows.Count; ++i)
                cmbAula.Items.Add(dtAula.Rows[i].ItemArray[2]);
            cmbAula.SelectedIndex = 0;

            cmbMateria.Items.Clear();
            for (int i = 0; i < dtMaterias.Rows.Count; ++i)
                cmbMateria.Items.Add(dtMaterias.Rows[i].ItemArray[1]);
            DeshabilitarOrdenamiento();

            cargado = true;
            cmbMateria.SelectedIndex = 0;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvClases.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void CargarGrid()
        {
            //Cambia el ID al de la materia seleccionada
            idMateria = Convert.ToInt32(dtMaterias.Rows[cmbMateria.SelectedIndex].ItemArray[3].ToString());
            cargado = false;

            //Actualiza el grid
            postgrado.IdPostgrado = idPostgrado;

            dgvClases.DataSource = null;
            dtClases = postgrado.ListarMateriasHorario(idMateria);
            dgvClases.DataSource = dtClases;

            //Da Formato al Datagrid
            dgvClases.Columns.Remove("idPostgrado");
            dgvClases.Columns.Remove("idMateria");
            dgvClases.Columns.Remove("idDetalleMateria");
            dgvClases.Columns.Remove("idAula");

            dgvClases.Columns[0].HeaderText = "Materia";
            dgvClases.Columns[1].HeaderText = "Fecha";
            dgvClases.Columns[2].HeaderText = "Hora Entrada";
            dgvClases.Columns[3].HeaderText = "Hora Salida";
            dgvClases.Columns[4].HeaderText = "Aula";

            dgvClases.Columns[0].Width = 200;
            dgvClases.Columns[1].Width = 100;
            dgvClases.Columns[2].Width = 150;
            dgvClases.Columns[3].Width = 150;
            dgvClases.Columns[4].Width = 50;

            dgvClases.Refresh();
            cargado = true;
        }
        #endregion

        #region Controles
        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargado = false;
            CargarGrid();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            //Primero comprueba todos los valores
            if (dtpEntrada.Value < dtpSalida.Value)
            {
                //Comprueba que no existan choques
                dtDetalleMateria = detalleMateria.Listar();
                bool choque = false;

                foreach (DataRow dtr in dtDetalleMateria.Rows)
                {
                    if(idAula == Convert.ToInt32(dtr.ItemArray[2].ToString()) && dtpFecha.Value.ToShortDateString() == Convert.ToDateTime(dtr.ItemArray[3].ToString()).ToShortDateString())
                    {
                        if (dtpEntrada.Value >= Convert.ToDateTime(dtr.ItemArray[4].ToString()) && dtpEntrada.Value <= Convert.ToDateTime(dtr.ItemArray[5].ToString()))
                            choque = true;
                        if (dtpSalida.Value >= Convert.ToDateTime(dtr.ItemArray[4].ToString()) && dtpSalida.Value <= Convert.ToDateTime(dtr.ItemArray[5].ToString()))
                            choque = true;
                    }
                }
                if (!choque)
                {
                    //inserta a DetalleMateria
                    detalleMateria.IdMateria = idMateria;
                    detalleMateria.IdAula = idAula;
                    detalleMateria.Fecha = dtpFecha.Value;
                    detalleMateria.HoraEntrada = dtpEntrada.Value;
                    detalleMateria.HoraSalida = dtpSalida.Value;

                    detalleMateria.Insertar();
                }
                else
                    MessageBox.Show(BLL.Mensajes.msjChoque, BLL.Mensajes.capError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjHoraEntrada, BLL.Mensajes.capError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cargado = false;
            CargarGrid();
        }

        private void cmbAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            idAula = Convert.ToInt32(dtAula.Rows[cmbAula.SelectedIndex].ItemArray[0].ToString());
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmPostgrados frm = new FrmPostgrados();
            frm.Show();
            this.Hide();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClases.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    detalleMateria.IdDetalleMateria = idDetalleMateria;

                    detalleMateria.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "DetalleMateria", "NombreMateria", 0, "-");
                    InsertarBitacora("Eliminar", "DetalleMateria", "Fecha", 1, "-");
                    InsertarBitacora("Eliminar", "DetalleMateria", "HoraEntrada", 2, "-");
                    InsertarBitacora("Eliminar", "DetalleMateria", "HoraSalida", 3, "-");
                    InsertarBitacora("Eliminar", "DetalleMateria", "Aula", 4, "-");

                    cargado = false;
                    Cargar();
                }
            }
        }

        private void dgvClases_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                idDetalleMateria = Convert.ToInt32(dtClases.Rows[dgvClases.SelectedRows[0].Index].ItemArray[2].ToString());

                //Registra los valores para la bitacora
                valores[0] = dtClases.Rows[dgvClases.SelectedRows[0].Index].ItemArray[4].ToString();
                valores[1] = dtClases.Rows[dgvClases.SelectedRows[0].Index].ItemArray[5].ToString();
                valores[2] = dtClases.Rows[dgvClases.SelectedRows[0].Index].ItemArray[6].ToString();
                valores[3] = dtClases.Rows[dgvClases.SelectedRows[0].Index].ItemArray[7].ToString();
                valores[4] = dtClases.Rows[dgvClases.SelectedRows[0].Index].ItemArray[8].ToString();
            }
        }
        #endregion

        #region Otros Métodos
        private void FrmHorarios_FormClosing(object sender, FormClosingEventArgs e)
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

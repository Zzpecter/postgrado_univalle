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
    public partial class FrmPostgrados : Form
    {
        #region Variables
        private DataTable dtPostgrado = new DataTable();
        private DataTable dtPostgradoMaterias = new DataTable();
        private DataTable dtPostgradoRequisitos = new DataTable();

        private BLL.Postgrado postgrado = new BLL.Postgrado();
        private BLL.MateriaPostgrado postgradoMateria = new BLL.MateriaPostgrado();
        private BLL.PostgradoRequisito postgradoRequisito = new BLL.PostgradoRequisito();

        private int idPostgrado = 0;
        private int index = 0;
        private bool cargado = false;
        #endregion

        #region Carga
        public FrmPostgrados()
        {
            InitializeComponent();
        }

        private void FrmPostgrados_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            dtPostgrado = postgrado.Listar();
            dgvPostgrados.DataSource = dtPostgrado;

            //Se da formato a la tabla
            dgvPostgrados.Columns.Remove("idPostgrado");
            dgvPostgrados.Columns[0].Width = 350;
            dgvPostgrados.Columns[1].Width = 150;
            dgvPostgrados.Columns[0].HeaderText = "Postgrado";
            dgvPostgrados.Columns[1].HeaderText = "Tipo";
            dgvPostgrados.ClearSelection();

            DeshabilitarOrdenamiento();

            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvPostgrados.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion

        #region Botones
        private void bAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarPostgrado frm = new FrmAgregarPostgrado();
            frm.Show();
            this.Hide();
        }

        private void bHorarios_Click(object sender, EventArgs e)
        {
            if (dgvPostgrados.SelectedRows.Count == 1)
            {
                FrmHorarios frm = new FrmHorarios(idPostgrado);
                frm.Show();
                this.Hide();
            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                postgrado.IdPostgrado = idPostgrado;

                //Lista todas las materias vinculadas al postgrado para eliminarlas
                dtPostgradoMaterias = postgrado.ListarPostMaterias();

                foreach (DataRow dtr in dtPostgradoMaterias.Rows)
                {
                    postgradoMateria.IdPostgrado = Convert.ToInt32(dtr.ItemArray[0].ToString());
                    postgradoMateria.IdMateria = Convert.ToInt32(dtr.ItemArray[3].ToString());
                    postgradoMateria.Eliminar();
                }

                //Lista todos los requisitos vinculados para eliminarlos
                postgradoRequisito.IdPostgrado = idPostgrado;
                dtPostgradoRequisitos = postgradoRequisito.Seleccionar();

                foreach (DataRow dtr in dtPostgradoRequisitos.Rows)
                {
                    postgradoRequisito.IdPostgradoRequisito = Convert.ToInt32(dtr.ItemArray[0].ToString());
                    postgradoRequisito.EliminarSimple();
                }
                
                //Elimina el Postgrado en si
                postgrado.Eliminar();

                cargado = false;
                Cargar();
            }
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (dgvPostgrados.SelectedRows.Count == 1)
            {
                FrmEditarPostgrados frm = new FrmEditarPostgrados(idPostgrado);
                frm.Show();
                this.Hide();
            }
        }

        private void dgvPostgrados_SelectionChanged(object sender, EventArgs e)
        {
            if(cargado)
            {
                index = dgvPostgrados.SelectedRows[0].Index;
                idPostgrado = Convert.ToInt32(dtPostgrado.Rows[index].ItemArray[0].ToString());
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Otros Métodos
        private void FrmPostgrados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}

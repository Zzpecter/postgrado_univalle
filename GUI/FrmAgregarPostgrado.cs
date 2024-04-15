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
    public partial class FrmAgregarPostgrado : Form
    {
        #region Variables
        private DataTable dtMateriasD = new DataTable();
        private DataTable dtMateriasC = new DataTable();

        private DataTable dtRequisitosD = new DataTable();
        private DataTable dtRequisitosC = new DataTable();

        private DataTable dtAuxiliar = new DataTable();
        private DataTable dtArea = new DataTable();

        private BLL.Materias materias = new BLL.Materias();
        private BLL.Requisitos requisitos = new BLL.Requisitos();
        private BLL.AreaPostgrado areaPostgrado = new BLL.AreaPostgrado();
        private BLL.Area area = new BLL.Area();
        private BLL.Controladora ctrl = new BLL.Controladora();
        private BLL.Postgrado postgrado = new BLL.Postgrado();
        private BLL.MateriaPostgrado matPos = new BLL.MateriaPostgrado();
        private BLL.PostgradoRequisito posReq = new BLL.PostgradoRequisito();

        private int idArea = 0;
        private int idPostgrado = 0;
        private int idMateria = 0;
        private bool cargado = false;
        #endregion

        #region carga
        public FrmAgregarPostgrado()
        {
            InitializeComponent();
        }

        private void FrmAgregarPostgrado_Load(object sender, EventArgs e)
        {
            PrimeraCarga();
            CargarGrids();
        }

        private void PrimeraCarga()
        {
            //Resetea los datagrids y datatables
            dtMateriasD = materias.Listar();
            dtMateriasC = materias.Listar();
            dtMateriasC.Clear();
            dtRequisitosD = requisitos.Listar();
            dtRequisitosC = requisitos.Listar();
            dtRequisitosC.Clear();

            //Resetea los combobox
            cmbArea.Items.Clear();
            cmbTipo.Items.Clear();

            cmbTipo.Items.Add("Diplomado");
            cmbTipo.Items.Add("Maestria");

            dtArea = area.Listar();
            foreach (DataRow dtr in dtArea.Rows)
                cmbArea.Items.Add(dtr.ItemArray[1].ToString());

            cargado = true;
            cmbArea.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;
        }

        private void CargarGrids()
        {
            cargado = false;
            dgvMateriasDisponibles.DataSource = null;
            dgvMateriasACursar.DataSource = null;
            dgvRequisitosDisponibles.DataSource = null;
            dgvRequisitosNecesarios.DataSource = null;

            dgvMateriasDisponibles.DataSource = dtMateriasD;
            dgvMateriasACursar.DataSource = dtMateriasC;
            dgvRequisitosDisponibles.DataSource = dtRequisitosD;
            dgvRequisitosNecesarios.DataSource = dtRequisitosC;

            //Da formato a los dataGrids
            dgvMateriasDisponibles.Columns.Remove("idMateria");
            dgvMateriasDisponibles.Columns.Remove("horasTotales");
            dgvMateriasDisponibles.Columns[0].HeaderText = "Materia";
            dgvMateriasDisponibles.Columns[0].Width = 450;

            dgvMateriasACursar.Columns.Remove("idMateria");
            dgvMateriasACursar.Columns.Remove("horasTotales");
            dgvMateriasACursar.Columns[0].HeaderText = "Materia";
            dgvMateriasACursar.Columns[0].Width = 450;

            dgvRequisitosDisponibles.Columns.Remove("idRequisito");
            dgvRequisitosDisponibles.Columns.Remove("idDocumento");
            dgvRequisitosDisponibles.Columns[0].HeaderText = "Tipo";
            dgvRequisitosDisponibles.Columns[1].HeaderText = "Documento";
            dgvRequisitosDisponibles.Columns[2].HeaderText = "Cantidad";
            dgvRequisitosDisponibles.Columns[3].HeaderText = "Requisito";
            dgvRequisitosDisponibles.Columns[1].Width = 150;
            dgvRequisitosDisponibles.Columns[2].Width = 50;
            dgvRequisitosDisponibles.Columns[3].Width = 150;
            dgvRequisitosNecesarios.Columns.Remove("idRequisito");
            dgvRequisitosNecesarios.Columns.Remove("idDocumento");
            dgvRequisitosNecesarios.Columns[0].HeaderText = "Tipo";
            dgvRequisitosNecesarios.Columns[1].HeaderText = "Documento";
            dgvRequisitosNecesarios.Columns[2].HeaderText = "Cantidad";
            dgvRequisitosNecesarios.Columns[3].HeaderText = "Requisito";
            dgvRequisitosNecesarios.Columns[1].Width = 150;
            dgvRequisitosNecesarios.Columns[2].Width = 50;
            dgvRequisitosNecesarios.Columns[3].Width = 150;

            //Actualiza los grids
            dgvMateriasDisponibles.Refresh();
            dgvMateriasACursar.Refresh();
            dgvRequisitosDisponibles.Refresh();
            dgvRequisitosNecesarios.Refresh();
            dgvMateriasDisponibles.ClearSelection();
            dgvMateriasACursar.ClearSelection();
            dgvRequisitosDisponibles.ClearSelection();
            dgvRequisitosNecesarios.ClearSelection();

            DeshabilitarOrdenamiento();
            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvMateriasACursar.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvMateriasDisponibles.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvRequisitosDisponibles.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (DataGridViewColumn dgvc in dgvRequisitosNecesarios.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion

        #region Botones
        private void bGuardar_Click(object sender, EventArgs e)
        {
            string errores = string.Empty;

            //Controla el nombre del postgrado
            postgrado.Nombre = tbNombre.Text;
            errores = postgrado.ControlCampos();

            if (dtMateriasC.Rows.Count < 1)
                errores += "Se debe cursar al menos una materia\n";
            if (dtRequisitosC.Rows.Count < 1)
                errores += "Debe existir al menos un requisito\n";

            if (errores.Equals(string.Empty))
            {
                //Ingresa el postgrado
                postgrado.TipoPostgrado = cmbTipo.SelectedItem.ToString();
                idPostgrado = postgrado.Insertar();

                //Ingresa el Area
                areaPostgrado.IdArea = idArea;
                areaPostgrado.IdPostgrado = idPostgrado;
                areaPostgrado.Insertar();

                //Ingresa las materias
                matPos.IdDocente = 0;
                matPos.IdPostgrado = idPostgrado;
                foreach (DataRow dtr in dtMateriasC.Rows)
                {
                    idMateria = Convert.ToInt32(dtr.ItemArray[0].ToString());
                    matPos.IdMateria = idMateria;
                    matPos.Insertar();
                }

                //Ingresa los Requisitos
                posReq.IdPostgrado = idPostgrado;
                foreach (DataRow dtr in dtRequisitosC.Rows)
                {
                    posReq.IdRequisito = Convert.ToInt32(dtr.ItemArray[1].ToString()); 
                    posReq.Insertar();
                }

                //Vuelve al formulario de postgrados
                FrmPostgrados frm = new FrmPostgrados();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show(errores, BLL.Mensajes.capError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void bMateriaNueva_Click(object sender, EventArgs e)
        {
            FrmAgregarMateria frm = new FrmAgregarMateria();
            frm.ShowDialog();

            if(frm.guardo)
            {
                dtAuxiliar = materias.ListarSinOrdenar();
                DataRow dtrUltimaMateria = dtAuxiliar.Rows[dtAuxiliar.Rows.Count - 1];
                dtMateriasD.Rows.Add(dtrUltimaMateria.ItemArray);
                CargarGrids();
            }
        }

        private void bAgregarMateria_Click(object sender, EventArgs e)
        {
            if (dgvMateriasDisponibles.SelectedRows.Count == 1)
            {
                int index = dgvMateriasDisponibles.SelectedRows[0].Index;
                //Agarra todo el Datarow y lo mueve a la otra tabla
                DataRow dtr = dtMateriasD.Rows[index];
                dtMateriasC.Rows.Add(dtr.ItemArray);
                dtMateriasD.Rows.Remove(dtr);
                CargarGrids();
            }
        }

        private void bQuitarMateria_Click(object sender, EventArgs e)
        {
            if (dgvMateriasACursar.SelectedRows.Count == 1)
            {
                int index = dgvMateriasACursar.SelectedRows[0].Index;
                //Agarra todo el Datarow y lo mueve a la otra tabla
                DataRow dtr = dtMateriasC.Rows[index];
                dtMateriasD.Rows.Add(dtr.ItemArray);
                dtMateriasC.Rows.Remove(dtr);
                CargarGrids();
            }
        }

        private void bRequisitoNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarRequisito frm = new FrmAgregarRequisito();
            frm.ShowDialog();

            if (frm.guardo)
            {
                dtAuxiliar = requisitos.Listar();
                DataRow dtrUltimoRequisito = dtAuxiliar.Rows[dtAuxiliar.Rows.Count - 1];
                dtRequisitosD.Rows.Add(dtrUltimoRequisito.ItemArray);
                CargarGrids();
            }
        }

        private void bAgregarRequisito_Click(object sender, EventArgs e)
        {
            if (dgvRequisitosDisponibles.SelectedRows.Count == 1)
            {
                int index = dgvRequisitosDisponibles.SelectedRows[0].Index;
                //Agarra todo el Datarow y lo mueve a la otra tabla
                DataRow dtr = dtRequisitosD.Rows[index];
                dtRequisitosC.Rows.Add(dtr.ItemArray);
                dtRequisitosD.Rows.Remove(dtr);
                CargarGrids();
            }
        }

        private void bQuitarRequisito_Click(object sender, EventArgs e)
        {
            if (dgvRequisitosNecesarios.SelectedRows.Count == 1)
            {
                int index = dgvRequisitosNecesarios.SelectedRows[0].Index;
                //Agarra todo el Datarow y lo mueve a la otra tabla
                DataRow dtr = dtRequisitosC.Rows[index];
                dtRequisitosD.Rows.Add(dtr.ItemArray);
                dtRequisitosC.Rows.Remove(dtr);
                CargarGrids();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            FrmPostgrados frm = new FrmPostgrados();
            frm.Show();
            this.Hide();
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cargado)
                idArea = Convert.ToInt32(dtArea.Rows[cmbArea.SelectedIndex].ItemArray[0].ToString());
        }
        #endregion

        #region Otros Métodos
        private void FrmAgregarPostgrado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
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
    public partial class FrmEditarPostgrados : Form
    {
        #region Variables
        private DataTable dtPostgrado = new DataTable();
        private DataTable dtPostgradoActual = new DataTable();
        private DataTable dtMateriasD = new DataTable();
        private DataTable dtMateriasC = new DataTable();

        private DataTable dtRequisitosD = new DataTable();
        private DataTable dtRequisitosC = new DataTable();

        private DataTable dtAuxiliar = new DataTable();
        private DataTable dtArea = new DataTable();
        private DataTable dtAreaPostgrado = new DataTable();

        private BLL.Materias materias = new BLL.Materias();
        private BLL.Requisitos requisitos = new BLL.Requisitos();
        private BLL.AreaPostgrado areaPostgrado = new BLL.AreaPostgrado();
        private BLL.Area area = new BLL.Area();
        private BLL.Controladora ctrl = new BLL.Controladora();
        private BLL.Postgrado postgrado = new BLL.Postgrado();
        private BLL.MateriaPostgrado matPos = new BLL.MateriaPostgrado();
        private BLL.PostgradoRequisito posReq = new BLL.PostgradoRequisito();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private int idArea = 0;
        private int idPostgrado = 0;
        private int idAreaPostgrado = 0;
        private bool cargado = false;
        private string[] valores = new string[3];
        private List<int> idsMat = new List<int>();
        private List<int> idsReq = new List<int>();
        #endregion

        #region Carga
        public FrmEditarPostgrados(int idPostgrado)
        {
            InitializeComponent();
            this.idPostgrado = idPostgrado;
        }

        private void FrmEditarPostgrados_Load(object sender, EventArgs e)
        {
            PrimeraCarga();
            CargarDatos();
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

            //Selecciona el id del area del postgrado
            areaPostgrado.IdPostgrado = idPostgrado;
            dtAreaPostgrado = areaPostgrado.Seleccionar();
            idAreaPostgrado = Convert.ToInt32(dtAreaPostgrado.Rows[0].ItemArray[0].ToString());
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
            dgvMateriasACursar.Columns.Remove("idMateria");
            dgvMateriasACursar.Columns.Remove("horasTotales");
            dgvMateriasDisponibles.Columns[0].HeaderText = "Materia";
            dgvMateriasDisponibles.Columns[0].Width = 450;
            dgvMateriasACursar.Columns[0].HeaderText = "Materia";
            dgvMateriasACursar.Columns[0].Width = 450;

            dgvRequisitosDisponibles.Columns.Remove("idRequisito");
            dgvRequisitosDisponibles.Columns.Remove("idDocumento");
            dgvRequisitosNecesarios.Columns.Remove("idRequisito");
            dgvRequisitosNecesarios.Columns.Remove("idDocumento");
            dgvRequisitosDisponibles.Columns[0].HeaderText = "Tipo";
            dgvRequisitosDisponibles.Columns[1].HeaderText = "Documento";
            dgvRequisitosDisponibles.Columns[2].HeaderText = "Cantidad";
            dgvRequisitosDisponibles.Columns[3].HeaderText = "Requisito";
            dgvRequisitosNecesarios.Columns[0].HeaderText = "Tipo";
            dgvRequisitosNecesarios.Columns[1].HeaderText = "Documento";
            dgvRequisitosNecesarios.Columns[2].HeaderText = "Cantidad";
            dgvRequisitosNecesarios.Columns[3].HeaderText = "Requisito";
            dgvRequisitosDisponibles.Columns[1].Width = 150;
            dgvRequisitosDisponibles.Columns[2].Width = 50;
            dgvRequisitosDisponibles.Columns[3].Width = 150;
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

        private void CargarDatos()
        {
            //Carga los datos del id seleccionado
            matPos.IdPostgrado = idPostgrado;
            dtAuxiliar = matPos.Seleccionar();
            idsMat.Clear();

            //Carga todos los ids en una lista
            foreach (DataRow dtr in dtAuxiliar.Rows)
                idsMat.Add(Convert.ToInt32(dtr.ItemArray[1].ToString()));

            //Ahora Revisa todos los ids, los que coinciden los cambia de DTT
            foreach (int id in idsMat)
            {
                foreach (DataRow dtr in dtMateriasD.Rows)
                {
                    if (Convert.ToInt32(dtr.ItemArray[0].ToString()).Equals(id))
                    {
                        dtMateriasC.Rows.Add(dtr.ItemArray);
                        dtMateriasD.Rows.Remove(dtr);
                        break;
                    }
                }
            }

            //Carga Los requisitos del postgrado
            posReq.IdPostgrado = idPostgrado;
            dtAuxiliar = posReq.Seleccionar();
            idsReq.Clear();

            //Carga todos los ids en una lista
            foreach (DataRow dtr in dtAuxiliar.Rows)
                idsReq.Add(Convert.ToInt32(dtr.ItemArray[2].ToString()));

            //Ahora Revisa todos los ids, los que coinciden los cambia de DTT
            foreach (int id in idsReq)
            {
                foreach (DataRow dtr in dtRequisitosD.Rows)
                {
                    if (Convert.ToInt32(dtr.ItemArray[1].ToString()).Equals(id))
                    {
                        dtRequisitosC.Rows.Add(dtr.ItemArray);
                        dtRequisitosD.Rows.Remove(dtr);
                        break;
                    }
                }
            }

            //Carga el nombre
            areaPostgrado.IdPostgrado = idPostgrado;
            dtPostgradoActual = areaPostgrado.Seleccionar();

            tbNombre.Text = dtPostgradoActual.Rows[0].ItemArray[3].ToString();
            for (int i = 0; i < cmbArea.Items.Count; ++i)
                if (cmbArea.Items[i].ToString().Equals(dtPostgradoActual.Rows[0].ItemArray[4].ToString()))
                    cmbArea.SelectedIndex = i;

            cmbTipo.SelectedItem = dtPostgradoActual.Rows[0].ItemArray[5].ToString();

            //Registra los valores para la bitacora
            valores[0] = tbNombre.Text;
            valores[1] = cmbArea.SelectedItem.ToString();
            valores[2] = cmbTipo.SelectedItem.ToString();
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

        private void bMateriaNueva_Click(object sender, EventArgs e)
        {
            FrmAgregarMateria frm = new FrmAgregarMateria();
            frm.ShowDialog();

            if (frm.guardo)
            {
                dtAuxiliar = materias.ListarSinOrdenar();
                DataRow dtrUltimaMateria = dtAuxiliar.Rows[dtAuxiliar.Rows.Count - 1];
                dtMateriasD.Rows.Add(dtrUltimaMateria.ItemArray);
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

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string errores = string.Empty;

            //Controla el nombre del postgrado
            postgrado.Nombre = tbNombre.Text;
            errores = postgrado.ControlCamposActualizar();

            if (dtMateriasC.Rows.Count < 1)
                errores += "Se debe cursar al menos una materia\n";
            if (dtRequisitosC.Rows.Count < 1)
                errores += "Debe existir al menos un requisito\n";

            if (errores.Equals(string.Empty))
            {
                //Actualiza el postgrado
                postgrado.TipoPostgrado = cmbTipo.SelectedItem.ToString();
                postgrado.IdPostgrado = idPostgrado;
                postgrado.Actualizar();

                //inserta en la bitácora
                InsertarBitacora("Editar", "Postgrado", "Nombre", 0, tbNombre.Text);
                InsertarBitacora("Editar", "Postgrado", "Area", 1, cmbArea.SelectedItem.ToString());
                InsertarBitacora("Editar", "Postgrado", "Tipo", 2, cmbTipo.SelectedItem.ToString());

                //Actualiza el Area
                areaPostgrado.IdAreaPostgrado = idAreaPostgrado;
                areaPostgrado.IdArea = idArea;
                areaPostgrado.IdPostgrado = idPostgrado;
                areaPostgrado.Actualizar();

                //Actualiza las materias
                matPos.IdDocente = 0;
                matPos.IdPostgrado = idPostgrado;
                ActualizarMaterias();

                //Actualiza los Requisitos
                posReq.IdPostgrado = idPostgrado;
                ActualizarRequisitos();
                

                //Vuelve al formulario de postgrados
                FrmPostgrados frm = new FrmPostgrados();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show(errores, BLL.Mensajes.capError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
        #endregion

        #region Métodos
        private void ActualizarMaterias()
        {
            //Esta lista auxiliar guarda todos los ids nuevos y la segunda guarda los que ya no estan
            List<int> idAgregar = new List<int>();
            List<int> idEliminar = new List<int>();
            bool encontrado = false;

            //Busca si el id ya esta en la BDD, caso contrario se lo agrega
            //A la lista para agregar
            foreach (DataRow dtr in dtMateriasC.Rows)
            {
                encontrado = false;
                foreach (int id in idsMat)
                {
                    if (id.Equals(Convert.ToInt32(dtr.ItemArray[0].ToString())))
                        encontrado = true;
                }
                if (!encontrado)
                    idAgregar.Add(Convert.ToInt32(dtr.ItemArray[0].ToString()));
            }

            //Busca si el id ya no esta en el DTT, si no o encuentra lo agrega 
            //A la lista para eliminar
            foreach (int id in idsMat)
            {
                encontrado = false;
                foreach (DataRow dtr in dtMateriasC.Rows)
                {
                    if (id.Equals(Convert.ToInt32(dtr.ItemArray[0].ToString())))
                        encontrado = true;
                }
                if (!encontrado)
                    idEliminar.Add(id);
            }

            //Agrega las materias
            foreach (int id in idAgregar)
            {
                matPos.IdMateria = id;
                matPos.Insertar();
            }

            //Elimina las materias
            foreach (int id in idEliminar)
            {
                matPos.IdMateria = id;
                matPos.Eliminar();
            }
        }

        private void ActualizarRequisitos()
        {
            //Esta lista auxiliar guarda todos los ids nuevos y la segunda guarda los que ya no estan
            List<int> idAgregar = new List<int>();
            List<int> idEliminar = new List<int>();
            bool encontrado = false;

            //Busca si el id ya esta en la BDD, caso contrario se lo agrega
            //A la lista para agregar
            foreach (DataRow dtr in dtRequisitosC.Rows)
            {
                encontrado = false;
                foreach (int id in idsReq)
                {
                    if (id.Equals(Convert.ToInt32(dtr.ItemArray[1].ToString())))
                        encontrado = true;
                }
                if (!encontrado)
                    idAgregar.Add(Convert.ToInt32(dtr.ItemArray[1].ToString()));
            }

            //Busca si el id ya no esta en el DTT, si no o encuentra lo agrega 
            //A la lista para eliminar
            foreach (int id in idsReq)
            {
                encontrado = false;
                foreach (DataRow dtr in dtRequisitosC.Rows)
                {
                    if (id.Equals(Convert.ToInt32(dtr.ItemArray[1].ToString())))
                        encontrado = true;
                }
                if (!encontrado)
                    idEliminar.Add(id);
            }

            //Agrega los Requisitos
            foreach (int id in idAgregar)
            {
                posReq.IdRequisito = id;
                posReq.Insertar();
            }

            //Elimina los Requisitos
            foreach (int id in idEliminar)
            {
                posReq.IdRequisito = id;
                posReq.Eliminar();
            }
        }

        private void FrmEditarPostgrados_FormClosing(object sender, FormClosingEventArgs e)
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

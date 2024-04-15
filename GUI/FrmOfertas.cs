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
    public partial class FrmOfertas : Form
    {
        #region Variables
        private BLL.Area area = new BLL.Area();
        private BLL.Interesado interesado = new BLL.Interesado();
        private BLL.AreaInteresado areaInteresado = new BLL.AreaInteresado();

        private DataTable dtArea = new DataTable();
        private DataTable dtAuxiliar = new DataTable();
        private DataTable dtInteresado = new DataTable();

        private List<int> areas = new List<int>();
        #endregion
        public FrmOfertas()
        {
            InitializeComponent();
        }

        private void FrmOfertas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Llena el grid
            dtArea = area.Listar();
            dgvAreas.DataSource = null;
            dgvAreas.DataSource = dtArea;

            dgvAreas.Columns.Remove("idArea");
            dgvAreas.Columns[0].Width = 25;
            dgvAreas.Columns[1].Width = 270;
            dtInteresado = interesado.ListarOferta();
            dtAuxiliar = interesado.ListarOferta();
            dtAuxiliar.Clear();
            dgvAreas.ReadOnly = false;

            foreach (DataGridViewRow d in dgvAreas.Rows)
            {
                d.Cells[0].Value = false;
            }

            dgvAreas.ClearSelection();
            DeshabilitarOrdenamiento();

        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvAreas.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void LlenarInteresados()
        {
            int id = 0;
            dtAuxiliar.Clear();
            foreach (DataRow dtr in dtInteresado.Rows)
            {
                //Copia todas las filas que tengan un id seleccionado
                id = Convert.ToInt32(dtr.ItemArray[2].ToString());
                if(areas.Contains(id))
                    dtAuxiliar.Rows.Add(dtr.ItemArray);
            }

            string Correos = string.Empty;
            List<string> l = new List<string>();

            //Da formato correcto para que se pueda copiar y pegar directamente al campo de destinatarios
            foreach (DataRow dtr in dtAuxiliar.Rows)
                l.Add(dtr.ItemArray[6].ToString());
            Correos = string.Join("; ", l);

            tbDestinatarios.Text = Correos;
        }

        private void FrmOfertas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bCorreos_Click(object sender, EventArgs e)
        {
            //Consigue los IDs de todas las areas seleccionadas
            areas.Clear();
            for (int i = 0; i < dgvAreas.Rows.Count; ++i)
                if (Convert.ToBoolean(dgvAreas.Rows[i].Cells[0].Value) == true)
                    areas.Add(Convert.ToInt32(dtArea.Rows[i].ItemArray[0].ToString()));

            LlenarInteresados();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }
    }
}


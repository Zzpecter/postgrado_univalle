using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Terminar este form que guarde, luego volverlo al estilo wizard el agregar postgrado :/
namespace GUI
{
    public partial class FrmAgregarRequisito : Form
    {
        #region Variables - Constructor

        private DataTable dtDocumentos = new DataTable();

        private BLL.Requisitos requisitos = new BLL.Requisitos();
        private BLL.Documento documento = new BLL.Documento();
        private BLL.Controladora ctrl = new BLL.Controladora();
        private int idDocumento = 0;
        public bool guardo;

        public FrmAgregarRequisito()
        {
            InitializeComponent();
        }
        #endregion

        #region Carga
        private void FrmAgregarRequisito_Load(object sender, EventArgs e)
        {
            guardo = false;
            Carga();
        }

        private void Carga()
        {
            //Llena los combobox
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Ingreso");
            cmbTipo.Items.Add("Egreso");

            rbOriginal.Checked = true;
            tbCopias.Value = 1;
            cmbDocumento.Items.Clear();
            dtDocumentos = documento.Listar();
            foreach (DataRow r in dtDocumentos.Rows)
                cmbDocumento.Items.Add(r.ItemArray[1].ToString());
            cmbDocumento.SelectedIndex = 0;
        }
        #endregion

        #region Botones
        private void bGuardar_Click(object sender, EventArgs e)
        {
            requisitos.IdDocumento = idDocumento;
            requisitos.TipoRequisito = cmbTipo.SelectedItem.ToString();
            requisitos.Cantidad = Convert.ToInt32(tbCopias.Value);
            if(rbOriginal.Checked)
                requisitos.Requisito = "Original";
            else
                requisitos.Requisito = "Copia";

            guardo = true;
            requisitos.Insertar();
            this.Hide();
        }
    
        private void bCancelar_Click(object sender, EventArgs e)
        {
                this.Hide();
        }
        #endregion

        private void cmbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Saca el index del elemento seleccionado
            idDocumento = Convert.ToInt32(dtDocumentos.Rows[cmbDocumento.SelectedIndex].ItemArray[0].ToString());
        }
    }
}

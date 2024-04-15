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
    public partial class FrmAgregarMateria : Form
    {
        private DataTable dtMaterias = new DataTable();
        private BLL.Materias mat = new BLL.Materias();
        private BLL.Controladora ctrl = new BLL.Controladora();
        public bool guardo;

        public FrmAgregarMateria()
        {
            InitializeComponent();
        }

        private void FrmAgregarMateria_Load(object sender, EventArgs e)
        {
            dtMaterias = mat.Listar();
            guardo = false;
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            dtMaterias.Clear();
            dtMaterias = mat.Listar();
            bool puede = true;

            if (ctrl.CampoVacio(tbMateria.Text))
            {
                //Comprueba que no haya una materia con el mismo nombre
                for (int i = 0; i < dtMaterias.Rows.Count; ++i)
                    if (tbMateria.Text.Equals(dtMaterias.Rows[i].ItemArray[1].ToString()))
                        puede = false;

                //Ingresa en la base de datos
                if (puede)
                {
                    mat.NombreMateria = tbMateria.Text;
                    mat.HorasTotales = Convert.ToInt32(tbHoras.Value);
                    mat.Insertar();

                    guardo = true;

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(BLL.Mensajes.msjMateriaRepetida, BLL.Mensajes.capError, MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show(BLL.Mensajes.msjCampoVacio, BLL.Mensajes.capError, MessageBoxButtons.OK);

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

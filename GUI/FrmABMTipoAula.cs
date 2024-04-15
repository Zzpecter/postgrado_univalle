﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmABMTipoAula : Form
    {
        #region Variables
        private BLL.TipoAula tipoAula = new BLL.TipoAula();
        private BLL.Bitacora bitacora = new BLL.Bitacora();

        private DataTable dtAula = new DataTable();

        private int idTipoAula = 0;
        private bool cargado = false;
        private string accionActual = string.Empty;
        private int index = 0;
        private string[] valores = new string[1];
        #endregion

        #region Carga
        public FrmABMTipoAula()
        {
            InitializeComponent();
        }

        private void FrmABMTipoAula_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            //Carga el datagrid
            dtAula = tipoAula.Listar();
            dgvAula.DataSource = null;
            dgvAula.DataSource = dtAula;

            //Da formato al datagrid
            dgvAula.Columns.Remove("idTipoAula");
            dgvAula.Columns[0].Width = 234;
            dgvAula.Columns[0].HeaderText = "Tipo de Aula";

            dgvAula.ClearSelection();

            DeshabilitarOrdenamiento();
            cargado = true;
        }

        private void DeshabilitarOrdenamiento()
        {
            foreach (DataGridViewColumn dgvc in dgvAula.Columns)
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void HabilitarControles(bool editando)
        {
            dgvAula.Enabled = !editando;

            tbAula.ReadOnly = !editando;
            bGuardar.Visible = editando;
            bCancelar.Visible = editando;

            bAgregar.Enabled = !editando;
            bEditar.Enabled = !editando;
            bEliminar.Enabled = !editando;
            bVolver.Enabled = !editando;

            if (accionActual.Equals("agregar"))
            {
                cargado = false;
                tbAula.Text = string.Empty;
                dgvAula.ClearSelection();
                cargado = true;
            }
        }
        #endregion

        #region Botones
        private void dgvAreas_SelectionChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                //Selecciona el id
                index = dgvAula.SelectedRows[0].Index;
                idTipoAula = Convert.ToInt32(dtAula.Rows[index].ItemArray[0].ToString());

                //Llena el textbox
                tbAula.Text = dtAula.Rows[index].ItemArray[1].ToString();

                //Registra los valores para la bitacora
                valores[0] = tbAula.Text;
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            accionActual = "agregar";
            HabilitarControles(true);
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (dgvAula.SelectedRows.Count.Equals(1))
            {
            accionActual = "editar";
            HabilitarControles(true);
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAula.SelectedRows.Count.Equals(1))
            {
                if (MessageBox.Show(BLL.Mensajes.msjEliminarRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tipoAula.IdTipoAula = idTipoAula;

                    tipoAula.Eliminar();

                    //inserta en la bitácora
                    InsertarBitacora("Eliminar", "TipoAula", "NombreTipo", 0, "-");

                    tbAula.Text = string.Empty;

                    cargado = false;
                    Cargar();
                }
            }
            else
                MessageBox.Show(BLL.Mensajes.msjSeleccioneRegistro, BLL.Mensajes.capWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            switch (accionActual)
            {
                case "agregar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        tipoAula.NombreTipo = tbAula.Text;

                        string error = tipoAula.ControlCampos();

                        if (error == string.Empty)
                        {
                            //inserta en la base de datos
                            tipoAula.Insertar();
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
                        }
                    } break;

                case "editar":
                    {

                        //Manda variables a la capa de negocio para controlarlas
                        tipoAula.NombreTipo = tbAula.Text;

                        string error = tipoAula.ControlCampos();

                        if (error == string.Empty)
                        {
                            //actualiza la base de datos
                            tipoAula.IdTipoAula = idTipoAula;

                            tipoAula.Actualizar();

                            //inserta en la bitácora
                            InsertarBitacora("Editar", "TipoAula", "NombreTipo", 0, tbAula.Text);
                        }
                        else
                        {
                            MessageBox.Show(error, BLL.Mensajes.capError, MessageBoxButtons.OK);
                        }

                    } break;

                default: break;
            }
            cargado = false;
            Cargar();
            HabilitarControles(false);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            accionActual = string.Empty;
            HabilitarControles(false);
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Otros Métodos
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

        private void FrmABMTipoAula_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}

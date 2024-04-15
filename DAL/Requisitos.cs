using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Requisitos
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strRequisitos req = new strRequisitos();

        #region Estructura, Gets, Sets.
        private struct strRequisitos
        {
            public int idRequisito;
            public int idDocumento;
            public string tipoRequisito;
            public int cantidad;
            public string requisito;
        }

        public int IdRequisito
        {
            get { return (req.idRequisito); }
            set { req.idRequisito = value; }
        }

        public int IdDocumento
        {
            get { return (req.idDocumento); }
            set { req.idDocumento = value; }
        }

        public string TipoRequisito
        {
            get { return (req.tipoRequisito); }
            set { req.tipoRequisito = value; }
        }

        public int Cantidad
        {
            get { return (req.cantidad); }
            set { req.cantidad = value; }
        }

        public string Requisito
        {
            get { return (req.requisito); }
            set { req.requisito = value; }
        }
        #endregion

        public Requisitos()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtRequisitos = new DataTable();
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.Connection = conexion;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Clear();

                    sqlCmd.CommandText = "PaDocumentoRequisitoListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtRequisitos);
                }
            }
            return dtRequisitos;
        }

        public int Insertar(string usuario)
        {
            int valores = 0;
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Connection = conexion;

                    sqlCmd.Parameters.Clear();

                    sqlCmd.Parameters.AddWithValue("@idDocumento", IdDocumento);
                    sqlCmd.Parameters.AddWithValue("@tipoRequisito", TipoRequisito);
                    sqlCmd.Parameters.AddWithValue("@cantidad", Cantidad);
                    sqlCmd.Parameters.AddWithValue("@requisito", Requisito);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaRequisitosInsertar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteScalar());
                }
            }
            return valores;
        }
    }
}

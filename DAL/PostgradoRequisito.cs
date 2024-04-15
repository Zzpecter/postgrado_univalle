using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PostgradoRequisito
    {
         private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strPostReq posReq = new strPostReq();

        #region gets sets struct
        private struct strPostReq
        {
            public int idPostgradoRequisito;
            public int idPostgrado;
            public int idRequisito;
        }

        public int IdPostgradoRequisito
        {
            get { return (posReq.idPostgradoRequisito); }
            set { posReq.idPostgradoRequisito = value; }
        }

        public int IdPostgrado
        {
            get { return (posReq.idPostgrado); }
            set { posReq.idPostgrado = value; }
        }

        public int IdRequisito
        {
            get { return (posReq.idRequisito); }
            set { posReq.idRequisito = value; }
        }
        #endregion

        public PostgradoRequisito()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
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

                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.Parameters.AddWithValue("@idRequisito", IdRequisito);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaPostgradoRequisitoInstertar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public DataTable Seleccionar()
        {
            DataTable dtPermisos = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);

                    sqlCmd.CommandText = "PaPostgradoRequisitoSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPermisos);
                }
            }
            return dtPermisos;
        }

        public int Eliminar()
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
                    sqlCmd.Connection = conexion;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.Clear();

                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.Parameters.AddWithValue("@idRequisito", IdRequisito);

                    sqlCmd.CommandText = "PaPostgradoRequisitoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public int EliminarSimple()
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
                    sqlCmd.Connection = conexion;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.Clear();

                    sqlCmd.Parameters.AddWithValue("@idPostgradoRequisito", IdPostgradoRequisito);

                    sqlCmd.CommandText = "PaPostgradoRequisitoEliminarSimple";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

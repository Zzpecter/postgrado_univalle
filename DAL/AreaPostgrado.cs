using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AreaPostgrado
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strArea are = new strArea();

        #region gets sets struct
        private struct strArea
        {
            public int idAreaPostgrado;
            public int idArea;
            public int idPostgrado;
        }

        public int IdAreaPostgrado
        {
            get { return (are.idAreaPostgrado); }
            set { are.idAreaPostgrado = value; }
        }

        public int IdArea
        {
            get { return (are.idArea); }
            set { are.idArea = value; }
        }

        public int IdPostgrado
        {
            get { return (are.idPostgrado); }
            set { are.idPostgrado = value; }
        }
        #endregion

        public AreaPostgrado()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtArea = new DataTable();
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

                    sqlCmd.CommandText = "PaAreaPostgradoListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtArea);
                }
            }
            return dtArea;
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

                    sqlCmd.Parameters.AddWithValue("@idArea", IdArea);
                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaAreaPostgradoInsertar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
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

                    sqlCmd.Parameters.AddWithValue("@idAreaPostgrado", IdAreaPostgrado);

                    sqlCmd.CommandText = "PaAreaPostgradoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public int Actualizar()
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

                    sqlCmd.Parameters.AddWithValue("@idAreaPostgrado", IdAreaPostgrado);
                    sqlCmd.Parameters.AddWithValue("@idArea", IdArea);
                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);

                    sqlCmd.CommandText = "PaAreaPostgradoActualizar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteNonQuery());
                }
            }
            return valores;
        }

        public DataTable Seleccionar()
        {
            DataTable dtArea = new DataTable();
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

                    sqlCmd.CommandText = "PaABMAreaPostgradoSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtArea);
                }
            }
            return dtArea;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Area
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strArea are = new strArea();

        #region gets sets struct
        private struct strArea
        {
            public int idArea;
            public string nombreArea;
        }

        public int IdArea
        {
            get { return (are.idArea); }
            set { are.idArea = value; }
        }

        public string NombreArea
        {
            get { return (are.nombreArea); }
            set { are.nombreArea = value; }
        }
        #endregion

        public Area()
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

                    sqlCmd.CommandText = "PaAreaListar";
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

                    sqlCmd.Parameters.AddWithValue("@nombreArea", NombreArea);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaAreaInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idArea", IdArea);

                    sqlCmd.CommandText = "PaAreaEliminar";

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

                    sqlCmd.Parameters.AddWithValue("@idArea", IdArea);
                    sqlCmd.Parameters.AddWithValue("@nombreArea", NombreArea);

                    sqlCmd.CommandText = "PaAreaActualizar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteNonQuery());
                }
            }
            return valores;
        }
    }
}

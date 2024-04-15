using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AreaInteresado
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strAreaInteresado areaInt = new strAreaInteresado();

        #region gets sets struct
        private struct strAreaInteresado
        {
            public int idAreaInteresado;
            public int idArea;
            public int idInteresado;
        }

        public int IdAreaInteresado
        {
            get { return (areaInt.idAreaInteresado); }
            set { areaInt.idAreaInteresado = value; }
        }

        public int IdArea
        {
            get { return (areaInt.idArea); }
            set { areaInt.idArea = value; }
        }

        public int IdInteresado
        {
            get { return (areaInt.idInteresado); }
            set { areaInt.idInteresado = value; }
        }
        #endregion

        public AreaInteresado()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtAreaInteresado = new DataTable();
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

                    sqlCmd.CommandText = "PaAreaInteresadoListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtAreaInteresado);
                }
            }
            return dtAreaInteresado;
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
                    sqlCmd.Parameters.AddWithValue("@idInteresado", IdInteresado);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaAreaInteresadoInsertar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteScalar());
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

                    sqlCmd.Parameters.AddWithValue("@idAreaInteresado", IdAreaInteresado);
                    sqlCmd.Parameters.AddWithValue("@idArea", IdArea);
                    sqlCmd.Parameters.AddWithValue("@idInteresado", IdInteresado);

                    sqlCmd.CommandText = "PaAreaInteresadoActualizar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteNonQuery());
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

                    sqlCmd.Parameters.AddWithValue("@idAreaInteresado", IdAreaInteresado);

                    sqlCmd.CommandText = "PaAreaInteresadoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public int Eliminar2()
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
                    sqlCmd.Parameters.AddWithValue("@idInteresado", IdInteresado);

                    sqlCmd.CommandText = "PaAreaInteresadoEliminar2";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public DataTable Seleccionar()
        {
            DataTable dtAreaInteresado = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idInteresado", IdInteresado);

                    sqlCmd.CommandText = "PaAreaInteresadoSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtAreaInteresado);
                }
            }
            return dtAreaInteresado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Tramite
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strTramite trm = new strTramite();


        #region gets sets struct
        private struct strTramite
        {
            public int idTramite;
            public int idEgresado;
            public int idEstadoTramite;
            public string comentario;
        }

        public int IdTramite
        {
            get { return (trm.idTramite); }
            set { trm.idTramite = value; }
        }

        public int IdEgresado
        {
            get { return (trm.idEgresado); }
            set { trm.idEgresado = value; }
        }

        public int IdEstadoTramite
        {
            get { return (trm.idEstadoTramite); }
            set { trm.idEstadoTramite = value; }
        }

        public string Comentario
        {
            get { return (trm.comentario); }
            set { trm.comentario = value; }
        }
        #endregion 

        public Tramite()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtTramite = new DataTable();
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

                    sqlCmd.CommandText = "PaABMTramiteListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtTramite);
                }
            }
            return dtTramite;
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

                    sqlCmd.Parameters.AddWithValue("@idTramite", IdTramite);
                    sqlCmd.Parameters.AddWithValue("@idEgresado", IdEgresado);
                    sqlCmd.Parameters.AddWithValue("@idEstadoTramite", IdEstadoTramite);
                    sqlCmd.Parameters.AddWithValue("@comentario", Comentario);

                    sqlCmd.CommandText = "PaTramiteActualizar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteNonQuery());
                }
            }
            return valores;
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

                    sqlCmd.Parameters.AddWithValue("@idEgresado", IdEgresado);
                    sqlCmd.Parameters.AddWithValue("@idEstadoTramite", IdEstadoTramite);
                    sqlCmd.Parameters.AddWithValue("@comentario", Comentario);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaTramiteInsertar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteNonQuery());
                }
            }
            return valores;
        }
    }
}

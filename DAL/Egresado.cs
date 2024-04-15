using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Egresado
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strEgresado egr = new strEgresado();

        #region gets sets struct
        private struct strEgresado
        {
            public int idEgresado;
            public int idAlumno;
            public int idPostgrado;
            public DateTime fechaEgreso;
        }

        public int IdEgresado
        {
            get { return (egr.idEgresado); }
            set { egr.idEgresado = value; }
        }

        public int IdAlumno
        {
            get { return (egr.idAlumno); }
            set { egr.idAlumno = value; }
        }

        public int IdPostgrado
        {
            get { return (egr.idPostgrado); }
            set { egr.idPostgrado = value; }
        }

        public DateTime FechaEgreso
        {
            get { return (egr.fechaEgreso); }
            set { egr.fechaEgreso = value; }
        }
        #endregion

        public Egresado()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtEgresado = new DataTable();
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

                    sqlCmd.CommandText = "PaEgresadoListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtEgresado);
                }
            }
            return dtEgresado;
        }

        public DataTable ListarABM()
        {
            DataTable dtEgresado = new DataTable();
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

                    sqlCmd.CommandText = "PaABMEgresadoListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtEgresado);
                }
            }
            return dtEgresado;
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

                    sqlCmd.Parameters.AddWithValue("@idAlumno", IdAlumno);
                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.Parameters.AddWithValue("@fechaEgreso", FechaEgreso);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaEgresadoInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idEgresado", IdEgresado);
                    sqlCmd.Parameters.AddWithValue("@idAlumno", IdAlumno);
                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.Parameters.AddWithValue("@fechaEgreso", FechaEgreso);

                    sqlCmd.CommandText = "PaEgresadoActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idEgresado", IdEgresado);

                    sqlCmd.CommandText = "PaEgresadoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

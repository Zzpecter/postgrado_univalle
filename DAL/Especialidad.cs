using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Especialidad
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strEspecialidad esp = new strEspecialidad();

        #region gets sets struct
        private struct strEspecialidad
        {
            public int idEspecialidad;
            public int idDocente;
            public int idAreaEspecialidad;
            public string nombre;
        }

        public int IdEspecialidad
        {
            get { return (esp.idEspecialidad); }
            set {esp.idEspecialidad = value;}
        }

        public int IdDocente
        {
            get { return (esp.idDocente); }
            set {esp.idDocente = value;}
        }

        public int IdAreaEspecialidad
        {
            get { return (esp.idAreaEspecialidad); }
            set {esp.idAreaEspecialidad = value;}
        }

        public string Nombre
        {
            get { return (esp.nombre); }
            set { esp.nombre = value; }
        }
        #endregion 

        public Especialidad()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtEspecialidad = new DataTable();
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

                    sqlCmd.CommandText = "PaEspecialidadListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtEspecialidad);
                }
            }
            return dtEspecialidad;
        }

        public DataTable ListarABM()
        {
            DataTable dtEspecialidad = new DataTable();
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

                    sqlCmd.CommandText = "PaABMAreaEspecialidadListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtEspecialidad);
                }
            }
            return dtEspecialidad;
        }

        public DataTable Seleccionar()
        {
            DataTable dtEspecialidad = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idDocente", IdDocente);

                    sqlCmd.CommandText = "PaEspecialidadSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtEspecialidad);
                }
            }
            return dtEspecialidad;
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

                    sqlCmd.Parameters.AddWithValue("@idAreaEspecialidad", IdAreaEspecialidad);
                    sqlCmd.Parameters.AddWithValue("@nombre", Nombre);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaEspecialidadInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idEspecialidad", IdEspecialidad);
                    sqlCmd.Parameters.AddWithValue("@idAreaEspecialidad", IdAreaEspecialidad);
                    sqlCmd.Parameters.AddWithValue("@nombre", Nombre);

                    sqlCmd.CommandText = "PaEspecialidadActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idEspecialidad", IdEspecialidad);

                    sqlCmd.CommandText = "PaEspecialidadEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

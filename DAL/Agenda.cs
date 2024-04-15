using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Agenda
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strAgenda age = new strAgenda();
        
        #region gets sets struct
        private struct strAgenda
        {
            public int idAgenda;
            public string anotacion;
            public DateTime fecha;
            public string nombre;
        }

        public int IdAgenda
        {
            get { return (age.idAgenda); }
            set { age.idAgenda = value; }
        }

        public string Anotacion
        {
            get { return (age.anotacion); }
            set { age.anotacion = value; }
        }

        public DateTime Fecha
        {
            get { return (age.fecha); }
            set { age.fecha = value; }
        }

        public string Nombre
        {
            get { return (age.nombre); }
            set { age.nombre = value; }
        }
        #endregion

        public Agenda()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtAgenda = new DataTable();
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

                    sqlCmd.CommandText = "PaAgendaListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtAgenda);
                }
            }
            return dtAgenda;
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

                    sqlCmd.Parameters.AddWithValue("@anotacion", Anotacion);
                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.Parameters.AddWithValue("@nombre", Nombre);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaAgendaInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idAgenda", IdAgenda);
                    sqlCmd.Parameters.AddWithValue("@anotacion", Anotacion);
                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.Parameters.AddWithValue("@nombre", Nombre);

                    sqlCmd.CommandText = "PaAgendaActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idAgenda", IdAgenda);

                    sqlCmd.CommandText = "PaAgendaEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DocenteEspecialidad
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strDocenteEspecialidad docEsp = new strDocenteEspecialidad();

        #region gets sets struct
        private struct strDocenteEspecialidad
        {
            public int idDocenteEspecialidad;
            public int idDocente;
            public int idEspecialidad;
        }

        public int IdDocenteEspecialidad
        {
            get { return (docEsp.idDocenteEspecialidad); }
            set { docEsp.idDocenteEspecialidad = value; }
        }

        public int IdDocente
        {
            get { return (docEsp.idDocente); }
            set { docEsp.idDocente = value; }
        }

        public int IdEspecialidad
        {
            get { return (docEsp.idEspecialidad); }
            set { docEsp.idEspecialidad = value; }
        }
        #endregion

        public DocenteEspecialidad()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtDocEspecialidad = new DataTable();
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

                    sqlCmd.CommandText = "PaDocenteEspecialidadListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtDocEspecialidad);
                }
            }
            return dtDocEspecialidad;
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

                    sqlCmd.Parameters.AddWithValue("@idDocente", IdDocente);
                    sqlCmd.Parameters.AddWithValue("@idEspecialidad", IdEspecialidad);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaDocenteEspecialidadInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idDocenteEspecialidad", IdDocenteEspecialidad);
                    sqlCmd.Parameters.AddWithValue("@idDocente", IdDocente);
                    sqlCmd.Parameters.AddWithValue("@idEspecialidad", IdEspecialidad);

                    sqlCmd.CommandText = "PaDocenteEspecialidadActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idDocente", IdDocente);
                    sqlCmd.Parameters.AddWithValue("@idEspecialidad", IdEspecialidad);

                    sqlCmd.CommandText = "PaDocenteEspecialidadEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

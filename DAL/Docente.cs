using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Docente
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strDocente doc = new strDocente();

        #region gets sets struct
        private struct strDocente
        {
            public int idDocente;
            public int idPersona;
            public string numDocumento;
            public string tipoDocumento;
            public string correo;
            public string direccion;
            public string nacionalidad;
        }

        public int IdDocente
        {
            get { return (doc.idDocente); }
            set { doc.idDocente = value; }
        }

        public int IdPersona
        {
            get { return (doc.idPersona); }
            set { doc.idPersona = value; }
        }

        public string Correo
        {
            get { return (doc.correo); }
            set { doc.correo = value; }
        }

        public string Direccion
        {
            get { return (doc.direccion); }
            set { doc.direccion = value; }
        }

        public string TipoDocumento
        {
            get { return (doc.tipoDocumento); }
            set { doc.tipoDocumento = value; }
        }

        public string NumDocumento
        {
            get { return (doc.numDocumento); }
            set { doc.numDocumento = value; }
        }

        public string Nacionalidad
        {
            get { return (doc.nacionalidad); }
            set { doc.nacionalidad = value; }
        }
        
        #endregion

        public Docente()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtDocente = new DataTable();
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

                    sqlCmd.CommandText = "PaABMDocenteListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtDocente);
                }
            }
            return dtDocente;
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

                    sqlCmd.Parameters.AddWithValue("@idPersona", IdPersona);
                    sqlCmd.Parameters.AddWithValue("@numDocumento", NumDocumento);
                    sqlCmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);
                    sqlCmd.Parameters.AddWithValue("@correo", Correo);
                    sqlCmd.Parameters.AddWithValue("@direccion", Direccion);
                    sqlCmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaDocenteInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idDocente", IdDocente);
                    sqlCmd.Parameters.AddWithValue("@idPersona", IdPersona);
                    sqlCmd.Parameters.AddWithValue("@numDocumento", NumDocumento);
                    sqlCmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);
                    sqlCmd.Parameters.AddWithValue("@correo", Correo);
                    sqlCmd.Parameters.AddWithValue("@direccion", Direccion);
                    sqlCmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);

                    sqlCmd.CommandText = "PaDocenteActualizar";

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

                    sqlCmd.CommandText = "PaDocenteEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

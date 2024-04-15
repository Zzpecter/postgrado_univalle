using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Alumno
    {

        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strAlumno alm = new strAlumno();

        #region gets sets struct
        private struct strAlumno
        {
            public int idAlumno;
            public int idPersona;
            public string correo;
            public string direccion;
            public string tipoDocumento;
            public string numeroDocumento;
            public string nacionalidad;
        }

        public int IdAlumno
        {
            get { return (alm.idAlumno); }
            set { alm.idAlumno = value; }
        }

        public int IdPersona
        {
            get { return (alm.idPersona); }
            set { alm.idPersona = value; }
        }

        public string Correo
        {
            get { return (alm.correo); }
            set { alm.correo = value; }
        }

        public string Direccion
        {
            get { return (alm.direccion); }
            set { alm.direccion = value; }
        }

        public string TipoDocumento
        {
            get { return (alm.tipoDocumento); }
            set { alm.tipoDocumento = value; }
        }

        public string NumeroDocumento
        {
            get { return (alm.numeroDocumento); }
            set { alm.numeroDocumento = value; }
        }
        public string Nacionalidad
        {
            get { return (alm.nacionalidad); }
            set { alm.nacionalidad = value; }
        }
        #endregion

        public Alumno()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtAlumno = new DataTable();
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

                    sqlCmd.CommandText = "PaABMAlumnoListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtAlumno);
                }
            }
            return dtAlumno;
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
                    sqlCmd.Parameters.AddWithValue("@correo", Correo);
                    sqlCmd.Parameters.AddWithValue("@direccion", Direccion);
                    sqlCmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);
                    sqlCmd.Parameters.AddWithValue("@numeroDocumento", NumeroDocumento);
                    sqlCmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaAlumnoInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idAlumno", IdAlumno);
                    sqlCmd.Parameters.AddWithValue("@idPersona", IdPersona);
                    sqlCmd.Parameters.AddWithValue("@correo", Correo);
                    sqlCmd.Parameters.AddWithValue("@direccion", Direccion);
                    sqlCmd.Parameters.AddWithValue("@tipoDocumento", TipoDocumento);
                    sqlCmd.Parameters.AddWithValue("@numeroDocumento", NumeroDocumento);
                    sqlCmd.Parameters.AddWithValue("@nacionalidad", Nacionalidad);

                    sqlCmd.CommandText = "PaAlumnoActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idAlumno", IdAlumno);

                    sqlCmd.CommandText = "PaAlumnoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public DataTable Seleccionar()
        {
            DataTable dtAlumno = new DataTable();
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

                    sqlCmd.CommandText = "PaABMAlumnoSeleccionar";

                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtAlumno);
                }
            }
            return dtAlumno;
        }
    }
}

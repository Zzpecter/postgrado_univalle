using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AlumnoPostgrado
    {

        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strAlumnoPostgrado alm = new strAlumnoPostgrado();

        #region gets sets struct
        private struct strAlumnoPostgrado
        {
            public int idAlumnoPostgrado;
            public int idAlumno;
            public int idPostgrado;
        }

        public int IdAlumnoPostgrado
        {
            get { return (alm.idAlumnoPostgrado); }
            set { alm.idAlumnoPostgrado = value; }
        }

        public int IdAlumno
        {
            get { return (alm.idAlumno); }
            set { alm.idAlumno = value; }
        }

        public int IdPostgrado
        {
            get { return (alm.idPostgrado); }
            set { alm.idPostgrado = value; }
        }
        #endregion

        public AlumnoPostgrado()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
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
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaAlumnoPostgradoInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idAlumno", IdAlumno);
                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);

                    sqlCmd.CommandText = "PaAlumnoPostgradoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

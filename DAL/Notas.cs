using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Notas
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strNotas notas = new strNotas();

        #region gets sets struct
        private struct strNotas
        {
            public int idNota;
            public int idAlumno;
            public int idMateria;
            public decimal notaFinal;
        }

        public int IdNota
        {
            get { return (notas.idNota); }
            set { notas.idNota = value; }
        }

        public int IdAlumno
        {
            get { return (notas.idAlumno); }
            set { notas.idAlumno = value; }
        }

        public int IdMateria
        {
            get { return (notas.idMateria); }
            set { notas.idMateria = value; }
        }

        public decimal NotaFinal
        {
            get { return (notas.notaFinal); }
            set { notas.notaFinal = value; }
        }
        #endregion

        public Notas()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtNotas = new DataTable();
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

                    sqlCmd.CommandText = "PaNotasListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtNotas);
                }
            }
            return dtNotas;
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
                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);
                    sqlCmd.Parameters.AddWithValue("@notaFinal", NotaFinal);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaNotasInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idNota", IdNota);
                    sqlCmd.Parameters.AddWithValue("@idAlumno", IdAlumno);
                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);
                    sqlCmd.Parameters.AddWithValue("@notaFinal", NotaFinal);

                    sqlCmd.CommandText = "PaNotasActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idNota", IdNota);

                    sqlCmd.CommandText = "PaNotasEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public DataTable Seleccionar()
        {
            DataTable dtNota = new DataTable();
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
                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);

                    sqlCmd.CommandText = "PaABMNotaSeleccionar";

                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtNota);
                }
            }
            return dtNota;
        }

        public DataTable SeleccionarMat()
        {
            DataTable dtNota = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);

                    sqlCmd.CommandText = "PaMateriaNotaSeleccionar";

                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtNota);
                }
            }
            return dtNota;
        }
    }
}

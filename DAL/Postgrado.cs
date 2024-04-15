using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Postgrado
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strPostgrado post = new strPostgrado();

        #region Estructura, Gets, Sets.
        private struct strPostgrado
        {
            public int idPostgrado;
            public string tipoPostgrado;
            public string nombre;
        }

        public int IdPostgrado
        {
            get { return (post.idPostgrado); }
            set { post.idPostgrado = value; }
        }

        public string TipoPostgrado
        {
            get { return (post.tipoPostgrado); }
            set { post.tipoPostgrado = value; }
        }

        public string Nombre
        {
            get { return (post.nombre); }
            set { post.nombre = value; }
        }
        #endregion

        public Postgrado()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtPostgrado = new DataTable();
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

                    sqlCmd.CommandText = "PaPostgradoListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPostgrado);
                }
            }
            return dtPostgrado;
        }

        public DataTable ListarPostMaterias()
        {
            DataTable dtPostgrado = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.CommandText = "PaMateriaDePostgradoSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPostgrado);
                }
            }
            return dtPostgrado;
        }

        public DataTable ListarMateriasHorario(int idMateria)
        {
            DataTable dtPostgrado = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.Parameters.AddWithValue("@idMateria", idMateria);

                    sqlCmd.CommandText = "PaMateriasHorarioSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPostgrado);
                }
            }
            return dtPostgrado;
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

                    sqlCmd.Parameters.AddWithValue("@tipoPostgrado", TipoPostgrado);
                    sqlCmd.Parameters.AddWithValue("@nombre", Nombre);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaPostgradoInsertar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteScalar());
                }
            }
            return valores;
        }

        public DataTable Seleccionar(int idAlumno)
        {
            DataTable dtPostgrado = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idAlumno", idAlumno);

                    sqlCmd.CommandText = "PaABMAlumnoPostgradoSeleccionar";

                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPostgrado);
                }
            }
            return dtPostgrado;
        }

        public DataTable SeleccionarPostgrado()
        {
            DataTable dtPostgrado = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);

                    sqlCmd.CommandText = "PaPostgradoSeleccionar";

                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPostgrado);
                }
            }
            return dtPostgrado;
        }

        public DataTable SeleccionarMaterias()
        {
            DataTable dtPostgrado = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);

                    sqlCmd.CommandText = "PaABMMateriaPostgradoSeleccionar";

                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPostgrado);
                }
            }
            return dtPostgrado;
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

                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.Parameters.AddWithValue("@tipoPostgrado", TipoPostgrado);
                    sqlCmd.Parameters.AddWithValue("@nombre", Nombre);

                    sqlCmd.CommandText = "PaPostgradoActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);

                    sqlCmd.CommandText = "PaPostgradoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

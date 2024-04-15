using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Materias
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strMateria mat = new strMateria();
        

        #region gets sets struct
        private struct strMateria
        {
            public int idMateria;
            public string nombreMateria;
            public int horasTotales;
        }

        public int IdMateria
        {
            get { return (mat.idMateria); }
            set { mat.idMateria = value; }
        }

        public string NombreMateria
        {
            get { return (mat.nombreMateria); }
            set { mat.nombreMateria = value; }
        }

        public int HorasTotales
        {
            get { return (mat.horasTotales); }
            set { mat.horasTotales = value; }
        }
        #endregion 

        public Materias()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();
            DataTable dtMaterias = new DataTable();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.Connection = conexion;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Clear();

                    sqlCmd.CommandText = "PaMateriaListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtMaterias);
                }
            }
            return dtMaterias;
        }

        public DataTable ListarSinDocente()
        {
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();
            DataTable dtMaterias = new DataTable();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.Connection = conexion;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Clear();

                    sqlCmd.CommandText = "PaMateriaSinDocenteListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtMaterias);
                }
            }
            return dtMaterias;
        }

        public DataTable ListarHorario()
        {
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();
            DataTable dtMaterias = new DataTable();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.Connection = conexion;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Clear();

                    sqlCmd.CommandText = "PaMateriasHorarioListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtMaterias);
                }
            }
            return dtMaterias;
        }

        public DataTable ListarSinOrdenar()
        {
            Conexion con = new Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();
            DataTable dtMaterias = new DataTable();

            if (error.Equals(string.Empty))
            {
                using (conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    sqlCmd.Connection = conexion;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Clear();

                    sqlCmd.CommandText = "PaMateriaListarSinOrdenar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtMaterias);
                }
            }
            return dtMaterias;
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

                    sqlCmd.Parameters.AddWithValue("@nombreMateria", NombreMateria);
                    sqlCmd.Parameters.AddWithValue("@horasTotales", HorasTotales);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaMateriaInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);
                    sqlCmd.Parameters.AddWithValue("@nombreMateria", NombreMateria);
                    sqlCmd.Parameters.AddWithValue("@horasTotales", HorasTotales);

                    sqlCmd.CommandText = "PaMateriaActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);

                    sqlCmd.CommandText = "PaMateriaEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public DataTable Seleccionar()
        {
            DataTable dtMaterias = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);

                    sqlCmd.CommandText = "PaMateriaPostgradoSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtMaterias);
                }
            }
            return dtMaterias;
        }
    }
}

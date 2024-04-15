using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MateriaPostgrado
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strMatPost matPos = new strMatPost();

        #region gets sets struct
        private struct strMatPost
        {
            public int idMateriaPostgrado;
            public int idMateria;
            public int idPostgrado;
            public int idDocente;
        }

        public int IdMateriaPostgrado
        {
            get { return (matPos.idMateriaPostgrado); }
            set { matPos.idMateriaPostgrado = value; }
        }

        public int IdMateria
        {
            get { return (matPos.idMateria); }
            set { matPos.idMateria = value; }
        }

        public int IdPostgrado
        {
            get { return (matPos.idPostgrado); }
            set { matPos.idPostgrado = value; }
        }

        public int IdDocente
        {
            get { return (matPos.idDocente); }
            set { matPos.idDocente = value; }
        }
        #endregion

        public MateriaPostgrado()
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

                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);
                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.Parameters.AddWithValue("@idDocente", IdDocente);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaMateriaPostgradoInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idMateriaPostgrado", IdMateriaPostgrado);
                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);
                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);
                    sqlCmd.Parameters.AddWithValue("@idDocente", IdDocente);

                    sqlCmd.CommandText = "PaMateriaPostgradoActualizar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteNonQuery());
                }
            }
            return valores;
        }

        public DataTable Seleccionar()
        {
            DataTable dtPermisos = new DataTable();
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

                    sqlCmd.CommandText = "PaABMMateriaPostgradoSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPermisos);
                }
            }
            return dtPermisos;
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
                    sqlCmd.Parameters.AddWithValue("@idPostgrado", IdPostgrado);

                    sqlCmd.CommandText = "PaMateriaPostgradoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public int EliminarSimple()
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

                    sqlCmd.Parameters.AddWithValue("@idMateriaPostgrado", IdMateriaPostgrado);

                    sqlCmd.CommandText = "PaMateriaPostgradoEliminarSimple";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

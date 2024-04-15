using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Permisos
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strPermiso perm = new strPermiso();

        #region gets sets struct
        private struct strPermiso
        {
            public bool abms;
            public bool postgrados;
            public bool personas;
            public bool ofertas;
            public bool inscripciones;
            public bool tramites;
            public bool horarios;
        }

        public bool Abms
        {
            get { return (perm.abms); }
            set { perm.abms = value; }
        }

        public bool Postgrados
        {
            get { return (perm.postgrados); }
            set { perm.postgrados = value; }
        }

        public bool Personas
        {
            get { return (perm.personas); }
            set { perm.personas = value; }
        }

        public bool Ofertas
        {
            get { return (perm.ofertas); }
            set { perm.ofertas = value; }
        }

        public bool Inscripciones
        {
            get { return (perm.inscripciones); }
            set { perm.inscripciones = value; }
        }

        public bool Tramites
        {
            get { return (perm.tramites); }
            set { perm.tramites = value; }
        }

        public bool Horarios
        {
            get { return (perm.horarios); }
            set { perm.horarios = value; }
        }
        #endregion

        public Permisos()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
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

                    sqlCmd.CommandText = "PaPermisosListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPermisos);
                }
            }
            return dtPermisos;
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

                    sqlCmd.Parameters.AddWithValue("@abms", Abms);
                    sqlCmd.Parameters.AddWithValue("@postgrados", Postgrados);
                    sqlCmd.Parameters.AddWithValue("@personas", Personas);
                    sqlCmd.Parameters.AddWithValue("@ofertas", Ofertas);
                    sqlCmd.Parameters.AddWithValue("@inscripciones", Inscripciones);
                    sqlCmd.Parameters.AddWithValue("@tramites", Tramites);
                    sqlCmd.Parameters.AddWithValue("@horarios", Horarios);

                    sqlCmd.CommandText = "PaPermisosActualizar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteNonQuery());
                }
            }
            return valores;
        }
    }
}

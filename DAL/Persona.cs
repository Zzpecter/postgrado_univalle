using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public class Persona
    {

        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strPersona per = new strPersona();

        public Persona()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        private struct strPersona
        {
            public int idPersona;
            public string nombres;
            public string apellidos;
            public byte[] foto;
        }

        public int IdPersona
        {
            get { return (per.idPersona); }
            set { per.idPersona = value; }
        }

        public string Nombres
        {
            get { return (per.nombres); }
            set { per.nombres = value; }
        }

        public string Apellidos
        {
            get { return (per.apellidos); }
            set { per.apellidos = value; }
        }

        public byte[] Foto
        {
            get { return (per.foto); }
            set { per.foto = value; }
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

                    sqlCmd.Parameters.AddWithValue("@nombres", Nombres);
                    sqlCmd.Parameters.AddWithValue("@apellidos", Apellidos);
                    sqlCmd.Parameters.AddWithValue("@foto", Foto);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaPersonaInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idPersona", IdPersona);
                    sqlCmd.Parameters.AddWithValue("@nombres", Nombres);
                    sqlCmd.Parameters.AddWithValue("@apellidos", Apellidos);
                    sqlCmd.Parameters.AddWithValue("@foto", Foto);

                    sqlCmd.CommandText = "PaPersonaActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idPersona", IdPersona);

                    sqlCmd.CommandText = "PaPersonaEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public void Seleccionar()
        {
            DataTable dtPersona = new DataTable();
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

                    sqlCmd.CommandText = "PaPersonaSeleccionar";

                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtPersona);
                }

                IdPersona = Convert.ToInt32(dtPersona.Rows[0].ItemArray[0]);
                Nombres = dtPersona.Rows[0].ItemArray[1].ToString();
                Apellidos = dtPersona.Rows[0].ItemArray[2].ToString();
                Foto = (byte[])dtPersona.Rows[0].ItemArray[3];
            }
        }
    }
}

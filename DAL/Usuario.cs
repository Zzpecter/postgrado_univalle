using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Usuario
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strUsuario usr = new strUsuario();
        private Persona prs = new Persona();


        #region gets sets struct
        private struct strUsuario
        {
            public int idUsuario;
            public int idPersona;
            public int idNivel;
            public string correo;
            public string login;
            public string password;
        }

        public int IdPersona
        {
            get { return (usr.idPersona); }
            set {
                usr.idPersona = value;
                prs.IdPersona = usr.idPersona;
                prs.Seleccionar();
                }
        }

        public string Nombre
        {
            get { return (prs.Nombres); }
        }

        public string Apellido
        {
            get { return (prs.Apellidos); }
        }

        public byte[] Foto
        {
            get { return (prs.Foto); }
        }

        public int IdUsuario
        {
            get { return (usr.idUsuario); }
            set { usr.idUsuario = value; }
        }

        public int IdNivel
        {
            get { return (usr.idNivel); }
            set { usr.idNivel = value; }
        }

        public string Correo
        {
            get { return (usr.correo); }
            set { usr.correo = value; }
        }

        public string Login
        {
            get { return (usr.login); }
            set { usr.login = value; }
        }

        public string Password
        {
            get { return (usr.password); }
            set { usr.password = value; }
        }

        #endregion 
        public Usuario()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtUsuario = new DataTable();
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

                    sqlCmd.CommandText = "PaUsuarioListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtUsuario);
                }
            }
            return dtUsuario;
        }

        public DataTable ListarUsuarioPersona()
        {
            DataTable dtUsuario = new DataTable();
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

                    sqlCmd.CommandText = "PaABMUsuarioListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtUsuario);
                }
            }
            return dtUsuario;
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
                    sqlCmd.Parameters.AddWithValue("@idNivel", IdNivel);
                    sqlCmd.Parameters.AddWithValue("@correo", Correo);
                    sqlCmd.Parameters.AddWithValue("@login", Login);
                    sqlCmd.Parameters.AddWithValue("@password", Password);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);
                    
                    sqlCmd.CommandText = "PaUsuarioInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idUsuario", IdUsuario);
                    sqlCmd.Parameters.AddWithValue("@idPersona", IdPersona);
                    sqlCmd.Parameters.AddWithValue("@idNivel", IdNivel);
                    sqlCmd.Parameters.AddWithValue("@correo", Correo);
                    sqlCmd.Parameters.AddWithValue("@login", Login);
                    sqlCmd.Parameters.AddWithValue("@password", Password);

                    sqlCmd.CommandText = "PaUsuarioActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idUsuario", IdUsuario);

                    sqlCmd.CommandText = "PaUsuarioEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

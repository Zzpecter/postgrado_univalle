using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Interesado
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strInteresado inter = new strInteresado();

        #region gets sets struct
        private struct strInteresado
        {
            public int idInteresado;
            public int idPersona;
            public string tipoInteresado;
            public string direccion;
            public string correo;
        }

        public int IdInteresado
        {
            get { return (inter.idInteresado); }
            set { inter.idInteresado = value; }
        }

        public int IdPersona
        {
            get { return (inter.idPersona); }
            set { inter.idPersona = value; }
        }

        public string TipoInteresado
        {
            get { return (inter.tipoInteresado); }
            set { inter.tipoInteresado = value; }
        }

        public string Direccion
        {
            get { return (inter.direccion); }
            set { inter.direccion = value; }
        }

        public string Correo
        {
            get { return (inter.correo); }
            set { inter.correo = value; }
        }
        #endregion

        public Interesado()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtInteresado = new DataTable();
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

                    sqlCmd.CommandText = "PaABMInteresadoListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtInteresado);
                }
            }
            return dtInteresado;
        }

        public DataTable ListarOferta()
        {
            DataTable dtInteresado = new DataTable();
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

                    sqlCmd.CommandText = "PaOfertaListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtInteresado);
                }
            }
            return dtInteresado;
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
                    sqlCmd.Parameters.AddWithValue("@tipoInteresado", TipoInteresado);
                    sqlCmd.Parameters.AddWithValue("@correo", Correo);
                    sqlCmd.Parameters.AddWithValue("@direccion", Direccion);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaInteresadoInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idInteresado", IdInteresado);
                    sqlCmd.Parameters.AddWithValue("@idPersona", IdPersona);
                    sqlCmd.Parameters.AddWithValue("@tipoInteresado", TipoInteresado);
                    sqlCmd.Parameters.AddWithValue("@correo", Correo);
                    sqlCmd.Parameters.AddWithValue("@direccion", Direccion);

                    sqlCmd.CommandText = "PaInteresadoActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idInteresado", IdInteresado);

                    sqlCmd.CommandText = "PaInteresadoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

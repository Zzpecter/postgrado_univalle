using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Telefono
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strTelefono tel = new strTelefono();


        #region gets sets struct
        private struct strTelefono
        {
            public int idTelefono;
            public int idTipoTelefono;
            public string numero;
        }

        public int IdTelefono
        {
            get { return (tel.idTelefono); }
            set { tel.idTelefono = value; }
        }

        public int IdTipoTelefono
        {
            get { return (tel.idTipoTelefono); }
            set { tel.idTipoTelefono = value; }
        }

        public string Numero
        {
            get { return (tel.numero); }
            set { tel.numero = value; }
        }
        #endregion 

        public Telefono()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar(int idPersona)
        {
            DataTable dtTelefono = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@idPersona", idPersona);

                    sqlCmd.CommandText = "PaABMTelefonoSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtTelefono);
                }
            }
            return dtTelefono;
        }

        public int Insertar(int idPersona, string usuario)
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

                    sqlCmd.Parameters.AddWithValue("@idPersona", idPersona);
                    sqlCmd.Parameters.AddWithValue("@idTipoTelefono", IdTipoTelefono);
                    sqlCmd.Parameters.AddWithValue("@numero", Numero);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaTelefonoInsertar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteScalar());
                }
            }
            return valores;
        }

        public int Actualizar(int idPersona)
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

                    sqlCmd.Parameters.AddWithValue("@idTelefono", IdTelefono);
                    sqlCmd.Parameters.AddWithValue("@idPersona", idPersona);
                    sqlCmd.Parameters.AddWithValue("@idTipoTelefono", IdTipoTelefono);
                    sqlCmd.Parameters.AddWithValue("@numero", Numero);

                    sqlCmd.CommandText = "PaTelefonoActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idTelefono", IdTelefono);

                    sqlCmd.CommandText = "PaTelefonoEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

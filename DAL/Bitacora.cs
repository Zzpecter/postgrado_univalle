using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Bitacora
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strBitacora bit = new strBitacora();

        public Bitacora()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        private struct strBitacora
        {
            public DateTime fecha;
            public string usuario;
            public string accion;
            public string tabla;
            public string campo;
            public string valorNuevo;
            public string valorAntiguo;
        }

        public DateTime Fecha
        {
            get { return bit.fecha; }
            set { bit.fecha = value; }
        }

        public string Usuario
        {
            get { return bit.usuario; }
            set { bit.usuario = value; }
        }

        public string Accion
        {
            get { return bit.accion; }
            set { bit.accion = value; }
        }

        public string Tabla
        {
            get { return bit.tabla; }
            set { bit.tabla = value; }
        }

        public string Campo
        {
            get { return bit.campo; }
            set { bit.campo = value; }
        }

        public string ValorNuevo
        {
            get { return bit.valorNuevo; }
            set { bit.valorNuevo = value; }
        }

        public string ValorAntiguo
        {
            get { return bit.valorAntiguo; }
            set { bit.valorAntiguo = value; }
        }

        public DataTable ListarCompleto()
        {
            DataTable dtBitacora = new DataTable();
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

                    sqlCmd.CommandText = "PaBitacoraListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtBitacora);
                }
            }
            return dtBitacora;
        }

        public int Insertar()
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

                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.Parameters.AddWithValue("@usuario", Usuario);
                    sqlCmd.Parameters.AddWithValue("@accion", Accion);
                    sqlCmd.Parameters.AddWithValue("@tabla", Tabla);
                    sqlCmd.Parameters.AddWithValue("@campo", Campo);
                    sqlCmd.Parameters.AddWithValue("@valorNuevo", ValorNuevo);
                    sqlCmd.Parameters.AddWithValue("@valorAntiguo", ValorAntiguo);

                    sqlCmd.CommandText = "PaBitacoraInsertar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public DataTable ListarFecha(DateTime fechaI, DateTime fechaS)
        {
            DataTable dtBitacora = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@fechaI", fechaI);
                    sqlCmd.Parameters.AddWithValue("@fechaS", fechaS);
                    sqlCmd.CommandText = "PaBitacoraListarFecha";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtBitacora);
                }
            }
            return dtBitacora;
        }

        public DataTable ListarFechaUP()
        {
            DataTable dtBitacora = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.CommandText = "PaBitacoraListarFechaUP";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtBitacora);
                }
            }
            return dtBitacora;
        }

        public DataTable ListarFechaDN()
        {
            DataTable dtBitacora = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.CommandText = "PaBitacoraListarFechaDN";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtBitacora);
                }
            }
            return dtBitacora;
        }

        public DataTable ListarUsuario()
        {
            DataTable dtBitacora = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@usuario", Usuario);
                    sqlCmd.CommandText = "PaBitacoraListarUsuario";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtBitacora);
                }
            }
            return dtBitacora;
        }

        public DataTable ListarTabla()
        {
            DataTable dtBitacora = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@tabla", Tabla);
                    sqlCmd.CommandText = "PaBitacoraListarTabla";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtBitacora);
                }
            }
            return dtBitacora;
        }

        public DataTable ListarTablaCampo()
        {
            DataTable dtBitacora = new DataTable();
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

                    sqlCmd.Parameters.AddWithValue("@tabla", Tabla);
                    sqlCmd.Parameters.AddWithValue("@campo", Campo);
                    sqlCmd.CommandText = "PaBitacoraListarTablaCampo";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtBitacora);
                }
            }
            return dtBitacora;
        }

    }
}

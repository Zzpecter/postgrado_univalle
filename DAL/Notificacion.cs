using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Notificacion
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strNotificacion noti = new strNotificacion();

        #region gets sets struct
        private struct strNotificacion
        {
            public int idNotificacion;
            public string descripcion;
            public DateTime fecha;
            public string tipo;
        }

        public int IdNotificacion
        {
            get { return (noti.idNotificacion); }
            set { noti.idNotificacion = value; }
        }

        public string Descripcion
        {
            get { return (noti.descripcion); }
            set { noti.descripcion = value; }
        }

        public DateTime Fecha
        {
            get { return (noti.fecha); }
            set { noti.fecha = value; }
        }

        public string Tipo
        {
            get { return (noti.tipo); }
            set { noti.tipo = value; }
        }
        #endregion

        public Notificacion()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtNotificacion = new DataTable();
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

                    sqlCmd.CommandText = "PaNotificacionListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtNotificacion);
                }
            }
            return dtNotificacion;
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

                    sqlCmd.Parameters.AddWithValue("@descripcion", Descripcion);
                    sqlCmd.Parameters.AddWithValue("@tipo", Tipo);
                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaNotificacionInsertar";

                    valores = Convert.ToInt32(sqlCmd.ExecuteScalar());
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

                    sqlCmd.Parameters.AddWithValue("@idNotificacion", IdNotificacion);

                    sqlCmd.CommandText = "PaNotificacionEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }
    }
}

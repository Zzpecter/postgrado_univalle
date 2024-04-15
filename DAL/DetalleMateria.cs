using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DetalleMateria
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;
        private strDetalleMateria det = new strDetalleMateria();

        #region gets sets struct
        private struct strDetalleMateria
        {
            public int idDetalleMateria;
            public int idMateria;
            public int idAula;
            public DateTime fecha;
            public DateTime horaEntrada;
            public DateTime horaSalida;
        }

        public int IdDetalleMateria
        {
            get { return (det.idDetalleMateria); }
            set { det.idDetalleMateria = value; }
        }

        public int IdMateria
        {
            get { return (det.idMateria); }
            set { det.idMateria = value; }
        }

        public int IdAula
        {
            get { return (det.idAula); }
            set { det.idAula = value; }
        }

        public DateTime Fecha
        {
            get { return (det.fecha); }
            set { det.fecha = value; }
        }

        public DateTime HoraEntrada
        {
            get { return (det.horaEntrada); }
            set { det.horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get { return (det.horaSalida); }
            set { det.horaSalida = value; }
        }
        #endregion 

        public DetalleMateria()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable Listar()
        {
            DataTable dtDetalleMateria = new DataTable();
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

                    sqlCmd.CommandText = "PaDetalleMateriaListar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtDetalleMateria);
                }
            }
            return dtDetalleMateria;
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
                    sqlCmd.Parameters.AddWithValue("@idAula", IdAula);
                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.Parameters.AddWithValue("@horaEntrada", HoraEntrada);
                    sqlCmd.Parameters.AddWithValue("@horaSalida", HoraSalida);
                    sqlCmd.Parameters.AddWithValue("@horasPasadas", 0);
                    sqlCmd.Parameters.AddWithValue("@usuarioRegistro", usuario);

                    sqlCmd.CommandText = "PaDetalleMateriaInsertar";

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

                    sqlCmd.Parameters.AddWithValue("@idDetalleMateria", IdDetalleMateria);
                    sqlCmd.Parameters.AddWithValue("@idMateria", IdMateria);
                    sqlCmd.Parameters.AddWithValue("@idAula", IdAula);
                    sqlCmd.Parameters.AddWithValue("@fecha", Fecha);
                    sqlCmd.Parameters.AddWithValue("@horaEntrada", HoraEntrada);
                    sqlCmd.Parameters.AddWithValue("@horaSalida", HoraSalida);
                    sqlCmd.Parameters.AddWithValue("@horasPasadas", 0);

                    sqlCmd.CommandText = "PaDetalleMateriaActualizar";

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

                    sqlCmd.Parameters.AddWithValue("@idDetalleMateria", IdDetalleMateria);

                    sqlCmd.CommandText = "PaDetalleMateriaEliminar";

                    valores = sqlCmd.ExecuteNonQuery();
                }
            }
            return valores;
        }

        public DataTable Seleccionar()
        {
            DataTable dtDetalleMateria = new DataTable();
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

                    sqlCmd.CommandText = "PaDetalleMateriaSeleccionar";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtDetalleMateria);
                }
            }
            return dtDetalleMateria;
        }
    }
}

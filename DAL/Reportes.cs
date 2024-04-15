using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Reportes
    {
        private SqlConnection conexion;
        private SqlCommand sqlCmd;

        public Reportes()
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = conexion;
        }

        public DataTable ListarAlumnos(DateTime fechaInferior, DateTime fechaSuperior)
        {
            DataTable dtAgenda = new DataTable();
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


                    sqlCmd.Parameters.AddWithValue("@fechaInferior", fechaInferior);
                    sqlCmd.Parameters.AddWithValue("@fechaSuperior", fechaSuperior);

                    sqlCmd.CommandText = "PaReporteAlumnos";
                    SqlDataAdapter sqlAdr = new SqlDataAdapter();
                    sqlAdr.SelectCommand = sqlCmd;
                    sqlAdr.Fill(dtAgenda);
                }
            }
            return dtAgenda;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using DAL;
using System.Data;


namespace BLL
{
    public class Autenticacion
    {
        private DAL.Usuario usuario = new DAL.Usuario();
        private DataTable dtUsuario = new DataTable();

        public string HashPassword(string pass)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));
            return sb.ToString();
        }

        public string ComprobarPass(int index, string pass)
        {
            string correcto = "incorrecto";

            if (dtUsuario.Rows[index].ItemArray[6].ToString().Equals(pass))
                correcto = "correcto";

            return correcto;
        }

        public string BuscarUsuario(string login, string pass)
        {
            dtUsuario = usuario.ListarUsuarioPersona();
            string error = string.Empty;
            bool existe = false;

            for (int i = 0; i < dtUsuario.Rows.Count; ++i)
                if (dtUsuario.Rows[i].ItemArray[5].ToString().Equals(login))
                {
                    error = ComprobarPass(i, pass);
                    if (error != "incorrecto")
                    {
                        CargarSesionActual(i);
                        error = string.Empty;
                    }
                    existe = true;
                    break;
                }

            if (!existe)
                error = Mensajes.msjUsuarioInexistente;
            else if (error.Equals("incorrecto"))
                error = Mensajes.msjPassIncorrecto;

            return error;
        }

        public void CargarSesionActual(int index)
        {
            SesionActual.Nombres = dtUsuario.Rows[index].ItemArray[0].ToString();
            SesionActual.Apellidos = dtUsuario.Rows[index].ItemArray[1].ToString();
            SesionActual.foto = (byte[])dtUsuario.Rows[index].ItemArray[2];
            SesionActual.Correo = dtUsuario.Rows[index].ItemArray[3].ToString();
            SesionActual.IdNivel = Convert.ToInt32(dtUsuario.Rows[index].ItemArray[4].ToString());
            SesionActual.Login = dtUsuario.Rows[index].ItemArray[5].ToString();
            SesionActual.Password = dtUsuario.Rows[index].ItemArray[6].ToString();
            SesionActual.IdPersona = Convert.ToInt32(dtUsuario.Rows[index].ItemArray[7].ToString());
            SesionActual.IdUsuario = Convert.ToInt32(dtUsuario.Rows[index].ItemArray[8].ToString());
        }

        public string ConexionActual()
        {
            DAL.Conexion con = new DAL.Conexion();
            string cadena = con.getConexion();
            string error = con.probarConexion();
            if (error.Equals(string.Empty))
                return ("Conectado Correctamente a la base de datos");
            else
                return (error);
        }
    }
}

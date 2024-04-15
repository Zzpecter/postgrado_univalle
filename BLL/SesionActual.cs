using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public static class SesionActual
    {

        private static strUsuario usr = new strUsuario();
        public static byte[] foto = new byte[0];

        private struct strUsuario
        {
            public int idUsuario;
            public int idPersona;
            public int idNivel;
            public string correo;
            public string login;
            public string password;
            public string nombres;
            public string apellidos;
        }

        public static int IdUsuario
        {
            get { return (usr.idUsuario); }
            set { usr.idUsuario = value; }
        }

        public static int IdPersona
        {
            get { return (usr.idPersona); }
            set { usr.idPersona = value; }
        }

        public static int IdNivel
        {
            get { return (usr.idNivel); }
            set { usr.idNivel = value; }
        }

        public static string Correo
        {
            get { return (usr.correo); }
            set { usr.correo = value; }
        }

        public static string Login
        {
            get { return (usr.login); }
            set { usr.login = value; }
        }

        public static string Password
        {
            get { return (usr.password); }
            set { usr.password = value; }
        }

        public static string Nombres
        {
            get { return (usr.nombres); }
            set { usr.nombres = value; }
        }

        public static string Apellidos
        {
            get { return (usr.apellidos); }
            set { usr.apellidos = value; }
        }
    }
}

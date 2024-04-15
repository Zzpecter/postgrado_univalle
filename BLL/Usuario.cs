using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Usuario
    {
        private DataTable dtUsuario = new DataTable();
        private DAL.Usuario usr = new DAL.Usuario();
        private Controladora ctrl = new Controladora();
        private strUsuario usuario = new strUsuario();
        private Persona persona = new Persona();
        private DAL.Persona prs = new DAL.Persona();

        private struct strUsuario
        {
            public int idUsuario;
            public int idPersona;
            public int idNivel;
            public string correo;
            public string login;
            public string password;
        }

        public int IdUsuario
        {
            get { return (usuario.idUsuario); }
            set { usuario.idUsuario = value; }
        }

        public int IdPersona
        {
            get { return (usuario.idPersona); }
            set {
                usuario.idPersona = value;
                prs.IdPersona = usuario.idPersona;
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

        public int IdNivel
        {
            get { return (usuario.idNivel); }
            set { usuario.idNivel = value; }
        }

        public string Correo
        {
            get { return (usuario.correo); }
            set { usuario.correo = value; }
        }

        public string Login
        {
            get { return (usuario.login); }
            set { usuario.login = value; }
        }

        public string Password
        {
            get { return (usuario.password); }
            set { usuario.password = value; }
        }

        public DataTable TablaVisualUsuario()
        {
            dtUsuario = usr.ListarUsuarioPersona();
            dtUsuario.Columns.Remove("foto");
            dtUsuario.Columns.Remove("idNivel");
            dtUsuario.Columns.Remove("password");
            dtUsuario.Columns.Remove("idPersona");
            dtUsuario.Columns.Remove("idUsuario");
            return (dtUsuario);
        }

        public DataTable TablaCompletaUsuario()
        {
            dtUsuario = usr.ListarUsuarioPersona();
            return (dtUsuario);
        }

        public int Insertar()
        {
            usr.IdPersona = IdPersona;
            usr.IdNivel = IdNivel;
            usr.Correo = Correo;
            usr.Login = Login;
            usr.Password = Password;

            return (usr.Insertar(SesionActual.Login));
        }

        public int Actualizar()
        {
            usr.IdUsuario = IdUsuario;
            usr.IdPersona = IdPersona;
            usr.IdNivel = IdNivel;
            usr.Correo = Correo;
            usr.Login = Login;
            usr.Password = Password;

            return (usr.Actualizar());
        }

        public int Eliminar()
        {
            usr.IdUsuario = IdUsuario;

            return (usr.Eliminar());
        }

        public string ControlPass(string pass2)
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Password))
                errores += "Ingrese una Contraseña Válida\n";

            //Verificar que no contenga letras
            if (!ctrl.CampoContraseña(Password))
                errores += "Su contraseña es demasiado Débil, Ingrese una mas fuerte\n";

            //Verificar que se hayan ingresado ambos campos
            if (!ctrl.CamposIguales(Password, pass2))
                errores += "Las contraseñas no coinciden\n";
            return errores;
        }
        
    }
}

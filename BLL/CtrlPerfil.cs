using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CtrlPerfil
    {
        private Controladora ctrl = new Controladora();

        #region gets sets struct
        private strCtrl control = new strCtrl();
        private struct strCtrl
        {
            public string nombres;
            public string apellidos;
            public string correo;
            public string login;
            public string passActual;
            public string pass1;
            public string pass2;
        }

        public string Nombres
        {
            get { return (control.nombres); }
            set { control.nombres = value; }
        }

        public string Apellidos
        {
            get { return (control.apellidos); }
            set { control.apellidos = value; }
        }

        public string Correo
        {
            get { return (control.correo); }
            set { control.correo = value; }
        }

        public string Login
        {
            get { return (control.login); }
            set { control.login = value; }
        }

        public string PassActual
        {
            get { return (control.passActual); }
            set { control.passActual = value; }
        }

        public string Pass1
        {
            get { return (control.pass1); }
            set { control.pass1 = value; }
        }

        public string Pass2
        {
            get { return (control.pass2); }
            set { control.pass2 = value; }
        }
        #endregion

        public string DetectarErroresPersona()
        {
            string errores = string.Empty;

            if (!ctrl.CampoVacio(Nombres) || !ctrl.CampoVacio(Apellidos))
                errores = Mensajes.msjCampoVacio;
            else
            {
                if (!ctrl.CampoSinNumeros(Nombres))
                    errores += Mensajes.msjNombreIncorrecto + "\n";
                if (!ctrl.CampoSinNumeros(Apellidos))
                    errores += Mensajes.msjApellidoIncorrecto + "\n";
            }

            return errores;
        }

        public string DetectarErroresUsuario()
        {
            string errores = string.Empty;

            if (!ctrl.CampoVacio(Correo) || !ctrl.CampoVacio(Login))
                errores = Mensajes.msjCampoVacio;
            else
            {
                if (!ctrl.CampoCorreo(Correo))
                    errores += Mensajes.msjCorreoIncorrecto + "\n";
            }

            return errores;
        }

        public string DetectarErroresPass()
        {
            string errores = string.Empty;

            if (!ctrl.CampoVacio(PassActual) || !ctrl.CampoVacio(Pass1) || !ctrl.CampoVacio(Pass2))
                errores = Mensajes.msjCampoVacio;
            else
            {
                if (!ctrl.CamposIguales(PassActual, SesionActual.Password))
                    errores += Mensajes.msjPassIncorrecto + "\n";
                if (!ctrl.CamposIguales(Pass1, Pass2))
                    errores += Mensajes.msjPassNoCoinciden + "\n";
            }

            return errores;
        }

    }
}

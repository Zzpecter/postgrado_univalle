using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CtrlDocente
    {

        private Controladora ctrl = new Controladora();

        #region gets sets struct
        private strCtrl control = new strCtrl();
        private struct strCtrl
        {
            public string nombres;
            public string apellidos;
            public string numeroDocumento;
            public string nacionalidad;
            public string direccion;
            public string correo;
            public int cantidadTelefonos;
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

        public string NumeroDocumento
        {
            get { return (control.numeroDocumento); }
            set { control.numeroDocumento = value; }
        }

        public string Nacionalidad
        {
            get { return (control.nacionalidad); }
            set { control.nacionalidad = value; }
        }

        public string Direccion
        {
            get { return (control.direccion); }
            set { control.direccion = value; }
        }

        public string Correo
        {
            get { return (control.correo); }
            set { control.correo = value; }
        }

        public int CantidadTelefonos
        {
            get { return (control.cantidadTelefonos); }
            set { control.cantidadTelefonos = value; }
        }
        #endregion

        public string DetectarErrores()
        {
            string errores = string.Empty;

            if (!ctrl.CampoVacio(Nombres) || !ctrl.CampoVacio(Apellidos) || !ctrl.CampoVacio(NumeroDocumento) || !ctrl.CampoVacio(Nacionalidad) || !ctrl.CampoVacio(Direccion) || !ctrl.CampoVacio(Correo))
                errores = Mensajes.msjCampoVacio;
            else
            {
                if (!ctrl.CampoSinNumeros(Nombres))
                    errores += Mensajes.msjNombreIncorrecto + "\n";
                if (!ctrl.CampoSinNumeros(Apellidos))
                    errores += Mensajes.msjApellidoIncorrecto + "\n";
                if (!ctrl.CampoSinNumeros(Nacionalidad))
                    errores += Mensajes.msjNacionalidadIncorrecta + "\n";
                if (!ctrl.CampoCorreo(Correo))
                    errores += Mensajes.msjCorreoIncorrecto + "\n";
            }

            return errores;
        }
    }
}

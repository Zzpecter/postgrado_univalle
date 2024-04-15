using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Interesado
    {
        private Controladora ctrl = new Controladora();
        private DAL.Interesado interesado = new DAL.Interesado();
        private strInteresado inter = new strInteresado();

        #region gets sets struct
        private struct strInteresado
        {
            public int idInteresado;
            public int idPersona;
            public string tipoInteresado;
            public string direccion;
            public string correo;
        }

        public int IdInteresado
        {
            get { return (inter.idInteresado); }
            set { inter.idInteresado = value; }
        }

        public int IdPersona
        {
            get { return (inter.idPersona); }
            set { inter.idPersona = value; }
        }

        public string TipoInteresado
        {
            get { return (inter.tipoInteresado); }
            set { inter.tipoInteresado = value; }
        }

        public string Direccion
        {
            get { return (inter.direccion); }
            set { inter.direccion = value; }
        }

        public string Correo
        {
            get { return (inter.correo); }
            set { inter.correo = value; }
        }
        #endregion

        public int Insertar()
        {
            interesado.IdPersona = IdPersona;
            interesado.Correo = Correo;
            interesado.Direccion = Direccion;
            interesado.TipoInteresado = TipoInteresado;

            return (interesado.Insertar(SesionActual.Login));
        }

        public DataTable Listar()
        {
            return interesado.Listar();
        }

        public DataTable ListarOferta()
        {
            return interesado.ListarOferta();
        }
        public int Actualizar()
        {
            interesado.IdInteresado = IdInteresado;
            interesado.IdPersona = IdPersona;
            interesado.Correo = Correo;
            interesado.Direccion = Direccion;
            interesado.TipoInteresado = TipoInteresado;

            return (interesado.Actualizar());
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Correo))
                errores += "Ingrese su correo\n";
            if (!ctrl.CampoVacio(Direccion))
                errores += "Ingrese su direccion\n";

            //Verifica que el correo sea valido
            if (!ctrl.CampoCorreo(Correo))
                errores += "Ingrese un Correo Válido\n";

            return errores;
        }

        public int Eliminar()
        {
            interesado.IdInteresado = IdInteresado;

            return (interesado.Eliminar());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Alumno
    {
        private DataTable dtAlumno = new DataTable();
        private DAL.Alumno alumno = new DAL.Alumno();
        private strAlumno alm = new strAlumno();
        private Controladora ctrl = new Controladora();

        #region gets sets struct
        private struct strAlumno
        {
            public int idAlumno;
            public int idPersona;
            public string correo;
            public string direccion;
            public string tipoDocumento;
            public string numeroDocumento;
            public string nacionalidad;
        }

        public int IdAlumno
        {
            get { return (alm.idAlumno); }
            set { alm.idAlumno = value; }
        }

        public int IdPersona
        {
            get { return (alm.idPersona); }
            set { alm.idPersona = value; }
        }

        public string Correo
        {
            get { return (alm.correo); }
            set { alm.correo = value; }
        }

        public string Direccion
        {
            get { return (alm.direccion); }
            set { alm.direccion = value; }
        }

        public string TipoDocumento
        {
            get { return (alm.tipoDocumento); }
            set { alm.tipoDocumento = value; }
        }

        public string NumeroDocumento
        {
            get { return (alm.numeroDocumento); }
            set { alm.numeroDocumento = value; }
        }

        public string Nacionalidad
        {
            get { return (alm.nacionalidad); }
            set { alm.nacionalidad = value; }
        }
        #endregion

        public int Insertar()
        {
            alumno.IdPersona = IdPersona;
            alumno.Correo = Correo;
            alumno.Direccion = Direccion;
            alumno.TipoDocumento = TipoDocumento;
            alumno.NumeroDocumento = NumeroDocumento;
            alumno.Nacionalidad = Nacionalidad;

            return (alumno.Insertar(SesionActual.Login));
        }

        public DataTable Listar()
        {
            return alumno.Listar();
        }

        public int Actualizar()
        {
            alumno.IdAlumno = IdAlumno;
            alumno.IdPersona = IdPersona;
            alumno.Correo = Correo;
            alumno.Direccion = Direccion;
            alumno.TipoDocumento = TipoDocumento;
            alumno.NumeroDocumento = NumeroDocumento;
            alumno.Nacionalidad = Nacionalidad;

            return (alumno.Actualizar());
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Correo))
                errores += "Ingrese su correo\n";
            if (!ctrl.CampoVacio(Direccion))
                errores += "Ingrese su direccion\n";
            if (!ctrl.CampoVacio(NumeroDocumento))
                errores += "Ingrese su documento\n";
            if (!ctrl.CampoVacio(Nacionalidad))
                errores += "Ingrese su nacionalidad\n";

            return errores;
        }

        public int Eliminar()
        {
            alumno.IdAlumno = IdAlumno;

            return (alumno.Eliminar());
        }

        public DataTable Seleccionar()
        {
            alumno.IdAlumno = IdAlumno;
            return alumno.Seleccionar();
        }
    }
}

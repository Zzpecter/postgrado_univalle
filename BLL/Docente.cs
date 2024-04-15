using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Docente
    {
        private DataTable dtDocente = new DataTable();
        private DAL.Docente docente = new DAL.Docente();
        private strDocente doc = new strDocente();

        #region gets sets struct
        private struct strDocente
        {
            public int idDocente;
            public int idPersona;
            public string numDocumento;
            public string tipoDocumento;
            public string correo;
            public string direccion;
            public string nacionalidad;
        }

        public int IdDocente
        {
            get { return (doc.idDocente); }
            set { doc.idDocente = value; }
        }

        public int IdPersona
        {
            get { return (doc.idPersona); }
            set { doc.idPersona = value; }
        }

        public string Correo
        {
            get { return (doc.correo); }
            set { doc.correo = value; }
        }

        public string Direccion
        {
            get { return (doc.direccion); }
            set { doc.direccion = value; }
        }

        public string TipoDocumento
        {
            get { return (doc.tipoDocumento); }
            set { doc.tipoDocumento = value; }
        }

        public string NumDocumento
        {
            get { return (doc.numDocumento); }
            set { doc.numDocumento = value; }
        }

        public string Nacionalidad
        {
            get { return (doc.nacionalidad); }
            set { doc.nacionalidad = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return docente.Listar();
        }

        public int Insertar()
        {
            docente.IdPersona = IdPersona;
            docente.NumDocumento = NumDocumento;
            docente.TipoDocumento = TipoDocumento;
            docente.Correo = Correo;
            docente.Direccion = Direccion;
            docente.Nacionalidad = Nacionalidad;

            return docente.Insertar(SesionActual.Login);
        }

        public int Actualizar()
        {
            docente.IdDocente = IdDocente;
            docente.IdPersona = IdPersona;
            docente.NumDocumento = NumDocumento;
            docente.TipoDocumento = TipoDocumento;
            docente.Correo = Correo;
            docente.Direccion = Direccion;
            docente.Nacionalidad = Nacionalidad;

            return docente.Actualizar();
        }

        public int Eliminar()
        {
            docente.IdDocente = IdDocente;
            return docente.Eliminar();
        }
    }
}

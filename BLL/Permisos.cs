using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Permisos
    {
        private strPermiso perm = new strPermiso();
        private DAL.Permisos permisos = new DAL.Permisos();

        #region gets sets struct
        private struct strPermiso
        {
            public bool abms;
            public bool postgrados;
            public bool personas;
            public bool ofertas;
            public bool inscripciones;
            public bool tramites;
            public bool horarios;
        }

        public bool Abms
        {
            get { return (perm.abms); }
            set { perm.abms = value; }
        }

        public bool Postgrados
        {
            get { return (perm.postgrados); }
            set { perm.postgrados = value; }
        }

        public bool Personas
        {
            get { return (perm.personas); }
            set { perm.personas = value; }
        }

        public bool Ofertas
        {
            get { return (perm.ofertas); }
            set { perm.ofertas = value; }
        }

        public bool Inscripciones
        {
            get { return (perm.inscripciones); }
            set { perm.inscripciones = value; }
        }

        public bool Tramites
        {
            get { return (perm.tramites); }
            set { perm.tramites = value; }
        }

        public bool Horarios
        {
            get { return (perm.horarios); }
            set { perm.horarios = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return permisos.Listar();
        }

        public int Actualizar()
        {
            permisos.Abms = Abms;
            permisos.Postgrados = Postgrados;
            permisos.Horarios = Horarios;
            permisos.Inscripciones = Inscripciones;
            permisos.Ofertas = Ofertas;
            permisos.Personas = Personas;
            permisos.Tramites = Tramites;

            return permisos.Actualizar();
        }
    }
}

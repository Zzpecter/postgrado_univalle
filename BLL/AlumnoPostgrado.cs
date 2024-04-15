using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class AlumnoPostgrado
    {
        private strAlumnoPostgrado alm = new strAlumnoPostgrado();
        private DAL.AlumnoPostgrado alumno = new DAL.AlumnoPostgrado();

        #region gets sets struct
        private struct strAlumnoPostgrado
        {
            public int idAlumnoPostgrado;
            public int idAlumno;
            public int idPostgrado;
        }

        public int IdAlumnoPostgrado
        {
            get { return (alm.idAlumnoPostgrado); }
            set { alm.idAlumnoPostgrado = value; }
        }

        public int IdAlumno
        {
            get { return (alm.idAlumno); }
            set { alm.idAlumno = value; }
        }

        public int IdPostgrado
        {
            get { return (alm.idPostgrado); }
            set { alm.idPostgrado = value; }
        }
        #endregion

        public int Insertar()
        {
            alumno.IdAlumno = IdAlumno;
            alumno.IdPostgrado = IdPostgrado;

            return alumno.Insertar(SesionActual.Login);
        }

        public int Eliminar()
        {
            alumno.IdAlumno = IdAlumno;
            alumno.IdPostgrado = IdPostgrado;

            return alumno.Eliminar();
        }
    }
}

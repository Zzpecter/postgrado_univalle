using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class DocenteEspecialidad
    {
        private DAL.DocenteEspecialidad docenteEspecialidad = new DAL.DocenteEspecialidad();
        private strDocenteEspecialidad docEsp = new strDocenteEspecialidad();

        #region gets sets struct
        private struct strDocenteEspecialidad
        {
            public int idDocenteEspecialidad;
            public int idDocente;
            public int idEspecialidad;
        }

        public int IdDocenteEspecialidad
        {
            get { return (docEsp.idDocenteEspecialidad); }
            set { docEsp.idDocenteEspecialidad = value; }
        }

        public int IdDocente
        {
            get { return (docEsp.idDocente); }
            set { docEsp.idDocente = value; }
        }

        public int IdEspecialidad
        {
            get { return (docEsp.idEspecialidad); }
            set { docEsp.idEspecialidad = value; }
        }
        #endregion

        public int Insertar()
        {
            docenteEspecialidad.IdDocente = IdDocente;
            docenteEspecialidad.IdEspecialidad = IdEspecialidad;

            return (docenteEspecialidad.Insertar(SesionActual.Login));
        }

        public DataTable Listar()
        {
            return docenteEspecialidad.Listar();
        }

        public int Actualizar()
        {
            docenteEspecialidad.IdDocenteEspecialidad = IdDocenteEspecialidad;
            docenteEspecialidad.IdDocente = IdDocente;
            docenteEspecialidad.IdEspecialidad = IdEspecialidad;
            return (docenteEspecialidad.Actualizar());
        }

        public int Eliminar()
        {
            docenteEspecialidad.IdDocente = IdDocente;
            docenteEspecialidad.IdEspecialidad = IdEspecialidad;

            return (docenteEspecialidad.Eliminar());
        }
    }
}

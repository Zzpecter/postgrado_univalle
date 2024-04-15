using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class AreaEspecialidad
    {
        private strAreaEsp areaEsp = new strAreaEsp();
        private DAL.AreaEspecialidad areaEspecialidad = new DAL.AreaEspecialidad();

        #region gets sets struct
        private struct strAreaEsp
        {
            public int idAreaEspecialidad;
            public string nombre;
        }

        public int IdAreaEspecialidad
        {
            get { return (areaEsp.idAreaEspecialidad); }
            set { areaEsp.idAreaEspecialidad = value; }
        }

        public string Nombre
        {
            get { return (areaEsp.nombre); }
            set { areaEsp.nombre = value; }
        }
        #endregion 

        public DataTable Listar()
        {
            return areaEspecialidad.Listar();
        }

        public int Insertar()
        {
            areaEspecialidad.Nombre = Nombre;

            return (areaEspecialidad.Insertar(SesionActual.Login));
        }

        public int Eliminar()
        {
            areaEspecialidad.IdAreaEspecialidad = IdAreaEspecialidad;

            return areaEspecialidad.Eliminar();
        }

        public int Actualizar()
        {
            areaEspecialidad.IdAreaEspecialidad = IdAreaEspecialidad;
            areaEspecialidad.Nombre = Nombre;

            return areaEspecialidad.Actualizar();
        }
    }
}

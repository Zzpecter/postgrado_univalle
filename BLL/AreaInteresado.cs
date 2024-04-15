using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class AreaInteresado
    {
        private Controladora ctrl = new Controladora();
        private DAL.AreaInteresado areaInteresado = new DAL.AreaInteresado();
        private strAreaInteresado areaInt = new strAreaInteresado();

        #region gets sets struct
        private struct strAreaInteresado
        {
            public int idAreaInteresado;
            public int idArea;
            public int idInteresado;
        }

        public int IdAreaInteresado
        {
            get { return (areaInt.idAreaInteresado); }
            set { areaInt.idAreaInteresado = value; }
        }

        public int IdArea
        {
            get { return (areaInt.idArea); }
            set { areaInt.idArea = value; }
        }

        public int IdInteresado
        {
            get { return (areaInt.idInteresado); }
            set { areaInt.idInteresado = value; }
        }
        #endregion

        public int Insertar()
        {
            areaInteresado.IdArea = IdArea;
            areaInteresado.IdInteresado = IdInteresado;

            return (areaInteresado.Insertar(SesionActual.Login));
        }

        public DataTable Listar()
        {
            return areaInteresado.Listar();
        }

        public int Actualizar()
        {
            areaInteresado.IdAreaInteresado = IdAreaInteresado;
            areaInteresado.IdArea = IdArea;
            areaInteresado.IdInteresado = IdInteresado;

            return (areaInteresado.Actualizar());
        }

        public int Eliminar()
        {
            areaInteresado.IdAreaInteresado = IdAreaInteresado;

            return (areaInteresado.Eliminar());
        }

        public int Eliminar2()
        {
            areaInteresado.IdArea = IdArea;
            areaInteresado.IdInteresado = IdInteresado;

            return (areaInteresado.Eliminar2());
        }

        public DataTable Seleccionar()
        {
            areaInteresado.IdInteresado = IdInteresado;
            return areaInteresado.Seleccionar();
        }
    }
}

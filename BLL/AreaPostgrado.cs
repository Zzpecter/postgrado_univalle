using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class AreaPostgrado
    {
        private DAL.AreaPostgrado areaPost = new DAL.AreaPostgrado();
        private strArea are = new strArea();

        #region gets sets struct
        private struct strArea
        {
            public int idAreaPostgrado;
            public int idArea;
            public int idPostgrado;
        }

        public int IdAreaPostgrado
        {
            get { return (are.idAreaPostgrado); }
            set { are.idAreaPostgrado = value; }
        }

        public int IdArea
        {
            get { return (are.idArea); }
            set { are.idArea = value; }
        }

        public int IdPostgrado
        {
            get { return (are.idPostgrado); }
            set { are.idPostgrado = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return areaPost.Listar();
        }

        public int Insertar()
        {
            areaPost.IdArea = IdArea;
            areaPost.IdPostgrado = IdPostgrado;

            return (areaPost.Insertar(SesionActual.Login));
        }

        public int Eliminar()
        {
            areaPost.IdAreaPostgrado = IdAreaPostgrado;

            return areaPost.Eliminar();
        }

        public int Actualizar()
        {
            areaPost.IdAreaPostgrado = IdAreaPostgrado;
            areaPost.IdArea = IdArea;
            areaPost.IdPostgrado = IdPostgrado;

            return areaPost.Actualizar();
        }

        public DataTable Seleccionar()
        {
            areaPost.IdPostgrado = IdPostgrado;
            return areaPost.Seleccionar();
        }
    }
}

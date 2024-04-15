using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class MateriaPostgrado
    {
        private DataTable dtMatPos = new DataTable();
        private DAL.MateriaPostgrado materiaPostgrado = new DAL.MateriaPostgrado();
        private strMatPost matPos = new strMatPost();

        #region gets sets struct
        private struct strMatPost
        {
            public int idMateriaPostgrado;
            public int idMateria;
            public int idPostgrado;
            public int idDocente;
        }

        public int IdMateriaPostgrado
        {
            get { return (matPos.idMateriaPostgrado); }
            set { matPos.idMateriaPostgrado = value; }
        }

        public int IdMateria
        {
            get { return (matPos.idMateria); }
            set { matPos.idMateria = value; }
        }

        public int IdPostgrado
        {
            get { return (matPos.idPostgrado); }
            set { matPos.idPostgrado = value; }
        }

        public int IdDocente
        {
            get { return (matPos.idDocente); }
            set { matPos.idDocente = value; }
        }
        #endregion

        public int Insertar()
        {
            materiaPostgrado.IdMateriaPostgrado = IdMateriaPostgrado;
            materiaPostgrado.IdMateria = IdMateria;
            materiaPostgrado.IdPostgrado = IdPostgrado;
            materiaPostgrado.IdDocente = IdDocente;

            return (materiaPostgrado.Insertar(SesionActual.Login));
        }

        public int Actualizar()
        {
            materiaPostgrado.IdMateriaPostgrado = IdMateriaPostgrado;
            materiaPostgrado.IdMateria = IdMateria;
            materiaPostgrado.IdPostgrado = IdPostgrado;
            materiaPostgrado.IdDocente = IdDocente;

            return (materiaPostgrado.Actualizar());
        }

        public DataTable Seleccionar()
        {
            materiaPostgrado.IdPostgrado = IdPostgrado;

            return materiaPostgrado.Seleccionar();
        }

        public int Eliminar()
        {
            materiaPostgrado.IdMateria = IdMateria;
            materiaPostgrado.IdPostgrado = IdPostgrado;

            return (materiaPostgrado.Eliminar());
        }

        public int EliminarSimple()
        {
            materiaPostgrado.IdMateriaPostgrado = IdMateriaPostgrado;

            return (materiaPostgrado.EliminarSimple());
        }
    }
}

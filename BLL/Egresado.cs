using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Egresado
    {
        private DAL.Egresado egresado = new DAL.Egresado();
        private strEgresado egr = new strEgresado();

        #region gets sets struct
        private struct strEgresado
        {
            public int idEgresado;
            public int idAlumno;
            public int idPostgrado;
            public DateTime fechaEgreso;
        }

        public int IdEgresado
        {
            get { return (egr.idEgresado); }
            set { egr.idEgresado = value; }
        }

        public int IdAlumno
        {
            get { return (egr.idAlumno); }
            set { egr.idAlumno = value; }
        }

        public int IdPostgrado
        {
            get { return (egr.idPostgrado); }
            set { egr.idPostgrado = value; }
        }

        public DateTime FechaEgreso
        {
            get { return (egr.fechaEgreso); }
            set { egr.fechaEgreso = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return egresado.Listar();
        }

        public DataTable ListarABM()
        {
            return egresado.ListarABM();
        }

        public int Insertar()
        {
            egresado.IdAlumno = IdAlumno;
            egresado.IdPostgrado = IdPostgrado;
            egresado.FechaEgreso = FechaEgreso;

            return (egresado.Insertar(SesionActual.Login));
        }

        public int Eliminar()
        {
            egresado.IdEgresado = IdEgresado;

            return egresado.Eliminar();
        }

        public int Actualizar()
        {
            egresado.IdEgresado = IdEgresado;
            egresado.IdAlumno = IdAlumno;
            egresado.IdPostgrado = IdPostgrado;
            egresado.FechaEgreso = FechaEgreso;

            return egresado.Actualizar();
        }
    }
}

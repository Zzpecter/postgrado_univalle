using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class DetalleMateria
    {
        private strDetalleMateria det = new strDetalleMateria();
        private DAL.DetalleMateria detalleMateria = new DAL.DetalleMateria();
        private Controladora ctrl = new Controladora();

        #region gets sets struct
        private struct strDetalleMateria
        {
            public int idDetalleMateria;
            public int idMateria;
            public int idAula;
            public DateTime fecha;
            public DateTime horaEntrada;
            public DateTime horaSalida;
        }

        public int IdDetalleMateria
        {
            get { return (det.idDetalleMateria); }
            set { det.idDetalleMateria = value; }
        }

        public int IdMateria
        {
            get { return (det.idMateria); }
            set { det.idMateria = value; }
        }

        public int IdAula
        {
            get { return (det.idAula); }
            set { det.idAula = value; }
        }

        public DateTime Fecha
        {
            get { return (det.fecha); }
            set { det.fecha = value; }
        }

        public DateTime HoraEntrada
        {
            get { return (det.horaEntrada); }
            set { det.horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get { return (det.horaSalida); }
            set { det.horaSalida = value; }
        }
        #endregion 

        public DataTable Listar()
        {
            return detalleMateria.Listar();
        }

        public int Actualizar()
        {
            detalleMateria.IdDetalleMateria = IdDetalleMateria;
            detalleMateria.IdMateria = IdMateria;
            detalleMateria.IdAula = IdAula;
            detalleMateria.Fecha = Fecha;
            detalleMateria.HoraEntrada = HoraEntrada;
            detalleMateria.HoraSalida = HoraSalida;

            return (detalleMateria.Actualizar());
        }

        public int Insertar()
        {
            detalleMateria.IdMateria = IdMateria;
            detalleMateria.IdAula = IdAula;
            detalleMateria.Fecha = Fecha;
            detalleMateria.HoraEntrada = HoraEntrada;
            detalleMateria.HoraSalida = HoraSalida;

            return (detalleMateria.Insertar(SesionActual.Login));
        }

        public int Eliminar()
        {
            detalleMateria.IdDetalleMateria = IdDetalleMateria;

            return (detalleMateria.Eliminar());
        }


        private bool ComprobarChoque()
        {
            bool existeChoque = false;

            detalleMateria.Fecha = Fecha;
            DataTable dtChoque = detalleMateria.Seleccionar();

            return existeChoque;
        }
    }
}

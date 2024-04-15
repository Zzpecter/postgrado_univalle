using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Notificacion
    {
        private strNotificacion noti = new strNotificacion();
        private DAL.Notificacion notificacion = new DAL.Notificacion();
        private DAL.Agenda agenda = new DAL.Agenda();
        private DAL.Materias materias = new DAL.Materias();
        
        #region gets sets struct
        private struct strNotificacion
        {
            public int idNotificacion;
            public string descripcion;
            public DateTime fecha;
            public string tipo;
        }

        public int IdNotificacion
        {
            get { return (noti.idNotificacion); }
            set { noti.idNotificacion = value; }
        }

        public string Descripcion
        {
            get { return (noti.descripcion); }
            set { noti.descripcion = value; }
        }

        public DateTime Fecha
        {
            get { return (noti.fecha); }
            set { noti.fecha = value; }
        }

        public string Tipo
        {
            get { return (noti.tipo); }
            set { noti.tipo = value; }
        }
        #endregion

        public int Insertar()
        {
            notificacion.Descripcion = Descripcion;
            notificacion.Tipo = Tipo;
            notificacion.Fecha = Fecha;

            return (notificacion.Insertar(SesionActual.Login));
        }

        public DataTable Listar()
        {
            return notificacion.Listar();
        }

        public int Eliminar()
        {
            notificacion.IdNotificacion = IdNotificacion;

            return (notificacion.Eliminar());
        }

        //Controla Agenda, Recordatorios y Materias sin docentes

        /// <summary>
        /// Aqui controla la agenda
        /// </summary>
        /// <returns>Datatable con todas las notificaciones de la agenda</returns>
        public DataTable VerificarAgenda()
        {
            //Aqui se carga la agenda para revisar las fechas
            DataTable dtAgenda = new DataTable();

            //Aqui se cargaran las notifiaciones
            DataTable dtTemporal = new DataTable();

            dtTemporal.Columns.Add("descripcion");
            dtTemporal.Columns.Add("tipo");
            dtTemporal.Columns.Add("fecha");

            dtAgenda = agenda.Listar();

            foreach (DataRow dtr in dtAgenda.Rows)
                if (Convert.ToDateTime(dtr.ItemArray[2]) == DateTime.Today)
                {
                    DataRow dtrTemporal = dtTemporal.NewRow();
                    dtrTemporal["descripcion"] = "Asunto pendiente para " + dtr.ItemArray[3] + " en la Agenda";
                    dtrTemporal["tipo"] = "Agenda";
                    dtrTemporal["fecha"] = DateTime.Now;
                    dtTemporal.Rows.Add(dtrTemporal);
                }

            return dtTemporal;
        }

        /// <summary>
        /// Aqui controla materias que no tengan un docente asignado
        /// </summary>
        /// <returns>Datatable con todas las materias sin docente</returns>
        public DataTable VerificarMaterias()
        {
            //Aqui se carga las materias que no tienen docente
            DataTable dtMaterias = new DataTable();

            dtMaterias = materias.ListarSinDocente();

            //Aqui se cargaran las notifiaciones
            DataTable dtTemporal = new DataTable();

            dtTemporal.Columns.Add("descripcion");
            dtTemporal.Columns.Add("tipo");
            dtTemporal.Columns.Add("fecha");

            foreach (DataRow dtr in dtMaterias.Rows)
            {
                DataRow dtrTemporal = dtTemporal.NewRow();
                dtrTemporal["descripcion"] = "La Materia " + dtr.ItemArray[3] + " no tiene un docente asignado";
                dtrTemporal["tipo"] = "Materia Sin Docente";
                dtrTemporal["fecha"] = DateTime.Now;
                dtTemporal.Rows.Add(dtrTemporal);
            }

            return dtTemporal;
        }

        /// <summary>
        /// Aqui agrega los recordatorios
        /// </summary>
        /// <returns>Datatable con los recordatorios</returns>
        public DataTable VerificarRecordatorios()
        {
            int antes = 0;
            int despues = 0;
            //Aqui se carga las materias que no tienen docente
            DataTable dtRecordatorios = new DataTable();

            dtRecordatorios = materias.ListarHorario();

            //Dos variables auxiliares para hacer el cálculos de las fechas
            DateTime fechaLim = new DateTime();
            DateTime hoy = new DateTime();

            //La fecha limite en la cual se muestra el recordatorio son 5 dias
            fechaLim = DateTime.Today.AddDays(5);
            hoy = DateTime.Today;

            //Aqui se cargaran las notifiaciones
            DataTable dtTemporal = new DataTable();

            dtTemporal.Columns.Add("descripcion");
            dtTemporal.Columns.Add("tipo");
            dtTemporal.Columns.Add("fecha");

            foreach (DataRow dtr in dtRecordatorios.Rows)
            {
                //Antes o igual a la fecha límite y mayor a la fecha de hoy dia
                DateTime fechaAux = Convert.ToDateTime(dtr.ItemArray[5]);
                antes = fechaLim.CompareTo(fechaAux);
                despues = hoy.CompareTo(fechaAux);
                if (antes >= 0 && despues < 0)
                {
                    DataRow dtrTemporal = dtTemporal.NewRow();
                    dtrTemporal["descripcion"] = "La Materia " + dtr.ItemArray[4] + " tiene clases el " + fechaAux.ToShortDateString();
                    dtrTemporal["tipo"] = "Recordatorio de clases";
                    dtrTemporal["fecha"] = DateTime.Now;
                    dtTemporal.Rows.Add(dtrTemporal);
                }
            }

            return dtTemporal;
        }
    }
}

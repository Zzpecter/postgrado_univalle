using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class EstadoTramite
    {
        private strEstadoTramite est = new strEstadoTramite();
        private DAL.EstadoTramite estado = new DAL.EstadoTramite();

        #region gets sets struct
        private struct strEstadoTramite
        {
            public int idEstadoTramite;
            public string estado;
        }

        public int IdEstadoTramite
        {
            get { return (est.idEstadoTramite); }
            set { est.idEstadoTramite = value; }
        }

        public string Estado
        {
            get { return (est.estado); }
            set { est.estado = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return estado.Listar();
        }

        public int Actualizar()
        {
            estado.IdEstadoTramite = IdEstadoTramite;
            estado.Estado = Estado;

            return estado.Actualizar();
        }

        public int Insertar()
        {
            estado.Estado = Estado;

            return estado.Insertar(SesionActual.Login);
        }
    }
}

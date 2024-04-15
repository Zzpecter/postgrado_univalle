using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Tramite
    {
        private DAL.Tramite tramite = new DAL.Tramite();
        private strTramite trm = new strTramite();
        #region gets sets struct
        private struct strTramite
        {
            public int idTramite;
            public int idEgresado;
            public int idEstadoTramite;
            public string comentario;
        }

        public int IdTramite
        {
            get { return (trm.idTramite); }
            set { trm.idTramite = value; }
        }

        public int IdEgresado
        {
            get { return (trm.idEgresado); }
            set { trm.idEgresado = value; }
        }

        public int IdEstadoTramite
        {
            get { return (trm.idEstadoTramite); }
            set { trm.idEstadoTramite = value; }
        }

        public string Comentario
        {
            get { return (trm.comentario); }
            set { trm.comentario = value; }
        }
        #endregion 

        public DataTable Listar()
        {
            return tramite.Listar();
        }

        public int Actualizar()
        {
            tramite.IdTramite = IdTramite;
            tramite.IdEgresado = IdEgresado;
            tramite.IdEstadoTramite = IdEstadoTramite;
            tramite.Comentario = Comentario;

            return tramite.Actualizar();
        }

        public int Insertar()
        {
            tramite.IdEgresado = IdEgresado;
            tramite.IdEstadoTramite = IdEstadoTramite;
            tramite.Comentario = Comentario;

            return tramite.Insertar(SesionActual.Login);
        }

    }
}

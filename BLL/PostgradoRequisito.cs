using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class PostgradoRequisito
    {
        private DataTable dtPosReq = new DataTable();
        private DAL.PostgradoRequisito postgradoRequisito = new DAL.PostgradoRequisito();
        private strPostReq posReq = new strPostReq();

        #region gets sets struct
        private struct strPostReq
        {
            public int idPostgradoRequisito;
            public int idPostgrado;
            public int idRequisito;
        }

        public int IdPostgradoRequisito
        {
            get { return (posReq.idPostgradoRequisito); }
            set { posReq.idPostgradoRequisito = value; }
        }

        public int IdPostgrado
        {
            get { return (posReq.idPostgrado); }
            set { posReq.idPostgrado = value; }
        }

        public int IdRequisito
        {
            get { return (posReq.idRequisito); }
            set { posReq.idRequisito = value; }
        }
        #endregion

        public int Insertar()
        {
            postgradoRequisito.IdPostgrado = IdPostgrado;
            postgradoRequisito.IdRequisito = IdRequisito;

            return (postgradoRequisito.Insertar(SesionActual.Login));
        }

        public DataTable Seleccionar()
        {
            postgradoRequisito.IdPostgrado = IdPostgrado;
            return postgradoRequisito.Seleccionar();
        }

        public int Eliminar()
        {
            postgradoRequisito.IdPostgrado = IdPostgrado;
            postgradoRequisito.IdRequisito = IdRequisito;
            return postgradoRequisito.Eliminar();
        }

        public int EliminarSimple()
        {
            postgradoRequisito.IdPostgradoRequisito = IdPostgradoRequisito;
            return postgradoRequisito.EliminarSimple();
        }
    }
}

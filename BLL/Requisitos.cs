using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;


namespace BLL
{
    public class Requisitos
    {
        private strRequisitos req = new strRequisitos();
        private DataTable dtRequisito = new DataTable();
        private DAL.Requisitos requisitos = new DAL.Requisitos();

        #region Estructura, Gets, Sets.
        private struct strRequisitos
        {
            public int idRequisito;
            public int idDocumento;
            public string tipoRequisito;
            public int cantidad;
            public string requisito;
        }

        public int IdRequisito
        {
            get { return (req.idRequisito); }
            set { req.idRequisito = value; }
        }

        public int IdDocumento
        {
            get { return (req.idDocumento); }
            set { req.idDocumento = value; }
        }

        public string TipoRequisito
        {
            get { return (req.tipoRequisito); }
            set { req.tipoRequisito = value; }
        }

        public int Cantidad
        {
            get { return (req.cantidad); }
            set { req.cantidad = value; }
        }

        public string Requisito
        {
            get { return (req.requisito); }
            set { req.requisito = value; }
        }

        #endregion

        public DataTable Listar()
        {
            return requisitos.Listar();
        }

        public int Insertar()
        {
            requisitos.TipoRequisito = TipoRequisito;
            requisitos.Requisito = Requisito;
            requisitos.IdDocumento = IdDocumento;
            requisitos.Cantidad = Cantidad;
            return requisitos.Insertar(SesionActual.Login);
        }
    }
}

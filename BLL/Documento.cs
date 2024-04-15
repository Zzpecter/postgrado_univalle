using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Documento
    {
        private strDocumento doc = new strDocumento();
        private Controladora ctrl = new Controladora();
        private DAL.Documento documento = new DAL.Documento();

        #region gets sets struct
        private struct strDocumento
        {
            public int idDocumento;
            public string nombreDocumento;
        }

        public int IdDocumento
        {
            get { return (doc.idDocumento); }
            set { doc.idDocumento = value; }
        }

        public string NombreDocumento
        {
            get { return (doc.nombreDocumento); }
            set { doc.nombreDocumento = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return documento.Listar();
        }

        public int Insertar()
        {
            documento.NombreDocumento = NombreDocumento;

            return (documento.Insertar(SesionActual.Login));
        }

        public int Eliminar()
        {
            documento.IdDocumento = IdDocumento;

            return documento.Eliminar();
        }

        public int Actualizar()
        {
            documento.IdDocumento = IdDocumento;
            documento.NombreDocumento = NombreDocumento;

            return documento.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(NombreDocumento))
                errores += "Ingrese el nombre del documento\n";

            return errores;
        }
    }
}

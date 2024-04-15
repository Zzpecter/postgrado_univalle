using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Aula
    {
        private strAula aula = new strAula();
        private Controladora ctrl = new Controladora();
        private DAL.Aula aul = new DAL.Aula();

        #region gets sets struct
        private struct strAula
        {
            public int idAula;
            public int idTipoAula;
            public int numAula;
        }

        public int IdAula
        {
            get { return (aula.idAula); }
            set { aula.idAula = value; }
        }

        public int IdTipoAula
        {
            get { return (aula.idTipoAula); }
            set { aula.idTipoAula = value; }
        }

        public int NumAula
        {
            get { return (aula.numAula); }
            set { aula.numAula = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return (aul.Listar());
        }

        public DataTable ListarABM()
        {
            return (aul.ListarABM());
        }

        public int Insertar()
        {
            aul.NumAula = NumAula;
            aul.IdTipoAula = IdTipoAula;

            return (aul.Insertar(SesionActual.Login));
        }

        public int Eliminar()
        {
            aul.IdAula = IdAula;

            return aul.Eliminar();
        }

        public int Actualizar()
        {
            aul.IdAula = IdAula;
            aul.NumAula = NumAula;
            aul.IdTipoAula = IdTipoAula;

            return aul.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(NumAula.ToString()))
                errores += "Ingrese el número del aula\n";

            return errores;
        }
    }
}

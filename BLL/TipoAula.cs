using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class TipoAula
    {
        private strTipoAula tAula = new strTipoAula();
        private DAL.TipoAula tipoAula = new DAL.TipoAula();
        private Controladora ctrl = new Controladora();

        #region Estructura, Gets, Sets.
        private struct strTipoAula
        {
            public int idTipoAula;
            public string nombreTipo;
        }

        public int IdTipoAula
        {
            get { return (tAula.idTipoAula); }
            set { tAula.idTipoAula = value; }
        }

        public string NombreTipo
        {
            get { return (tAula.nombreTipo); }
            set { tAula.nombreTipo = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return tipoAula.Listar();
        }

        public int Insertar()
        {
            tipoAula.NombreTipo = NombreTipo;

            return (tipoAula.Insertar(SesionActual.Login));
        }

        public int Eliminar()
        {
            tipoAula.IdTipoAula = IdTipoAula;

            return tipoAula.Eliminar();
        }

        public int Actualizar()
        {
            tipoAula.IdTipoAula = IdTipoAula;
            tipoAula.NombreTipo = NombreTipo;

            return tipoAula.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(NombreTipo))
                errores += "Ingrese el tipo de aula\n";

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoSinNumeros(NombreTipo))
                errores += "El tipo de aula no puede contener Números\n";

            return errores;
        }
    }
}

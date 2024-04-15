using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Area
    {
        private DataTable dtArea = new DataTable();
        private DAL.Area area = new DAL.Area();
        private Controladora ctrl = new Controladora();

        private strArea are = new strArea();

        #region gets sets struct
        private struct strArea
        {
            public int idArea;
            public string nombreArea;
        }

        public int IdArea
        {
            get { return (are.idArea); }
            set { are.idArea = value; }
        }

        public string NombreArea
        {
            get { return (are.nombreArea); }
            set { are.nombreArea = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return area.Listar();
        }

        public int Insertar()
        {
            area.NombreArea = NombreArea;

            return (area.Insertar(SesionActual.Login));
        }

        public int Eliminar()
        {
            area.IdArea = IdArea;

            return area.Eliminar();
        }

        public int Actualizar()
        {
            area.IdArea = IdArea;
            area.NombreArea = NombreArea;

            return area.Actualizar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(NombreArea))
                errores += "Ingrese el nombre del area\n";

            //Verifica que no contenga números
            if (!ctrl.CampoSinNumeros(NombreArea))
                errores += "El nombre del area no debe contener números\n";

            return errores;
        }
    }
}

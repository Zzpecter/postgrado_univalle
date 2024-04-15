using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class TipoTelefono
    {
        private DataTable dtTipoTelefono = new DataTable();
        private DAL.TipoTelefono tipoTelefono = new DAL.TipoTelefono();
        private strTipoTelefono tipoTel = new strTipoTelefono();
        private Controladora ctrl = new Controladora();

        #region Estructura, Gets, Sets.
        private struct strTipoTelefono
        {
            public int idTipoTelefono;
            public string tipoTelf;
        }

        public int IdTipoTelefono
        {
            get { return (tipoTel.idTipoTelefono); }
            set { tipoTel.idTipoTelefono = value; }
        }

        //Tener cuidado al ingresar a la base de datos, tuve que cambiar el nombre de la variable porque se rayaba con la clase
        public string TipoTelf
        {
            get { return (tipoTel.tipoTelf); }
            set { tipoTel.tipoTelf = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return tipoTelefono.Listar();
        }

        public int Insertar()
        {
            tipoTelefono.TipoTelf = TipoTelf;

            return tipoTelefono.Insertar(SesionActual.Login);
        }

        public int Actualizar()
        {
            tipoTelefono.IdTipoTelefono = IdTipoTelefono;
            tipoTelefono.TipoTelf = TipoTelf;

            return tipoTelefono.Actualizar();
        }

        public int Eliminar()
        {
            tipoTelefono.IdTipoTelefono = IdTipoTelefono;

            return tipoTelefono.Eliminar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(TipoTelf))
                errores += "Ingrese el tipo de Telefono\n";

            //Verificar que los campos no contengan numeros
            if (!ctrl.CampoSinNumeros(TipoTelf))
                errores += "El tipo de Telefono no puede contener Números\n";

            return errores;
        }
    }
}

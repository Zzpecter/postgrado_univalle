using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Telefono
    {
        private strTelefono tel = new strTelefono();
        private DataTable dtTelefono = new DataTable();
        private DAL.Telefono telefono = new DAL.Telefono();
        private Controladora ctrl = new Controladora();

        #region gets sets struct
        private struct strTelefono
        {
            public int idTelefono;
            public int idTipoTelefono;
            public string numero;
        }

        public int IdTelefono
        {
            get { return (tel.idTelefono); }
            set { tel.idTelefono = value; }
        }

        public int IdTipoTelefono
        {
            get { return (tel.idTipoTelefono); }
            set { tel.idTipoTelefono = value; }
        }

        public string Numero
        {
            get { return (tel.numero); }
            set { tel.numero = value; }
        }
        #endregion 

        public DataTable Listar(int idPersona)
        {
            return telefono.Listar(idPersona);
        }

        public int Insertar(int idPersona)
        {
            telefono.IdTipoTelefono = IdTipoTelefono;
            telefono.Numero = Numero;

            return (telefono.Insertar(idPersona, SesionActual.Login));
        }

        public int Actualizar(int idPersona)
        {
            telefono.IdTelefono = IdTelefono;
            telefono.IdTipoTelefono = IdTipoTelefono;
            telefono.Numero = Numero;

            return (telefono.Actualizar(idPersona));
        }

        public int Eliminar()
        {
            telefono.IdTelefono = IdTelefono;

            return telefono.Eliminar();
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Numero))
                errores += "Ingrese el número de teléfono\n";

            //Verificar que no contenga letras
            if (!ctrl.CampoSinLetras(Numero))
                errores += "El campo Numero no debe contener letras\n";

            return errores;
        }
    }
}

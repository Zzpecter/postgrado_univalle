using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Agenda
    {
        private strAgenda age = new strAgenda();
        private DAL.Agenda agenda = new DAL.Agenda();
        private Controladora ctrl = new Controladora();

        #region gets sets struct
        private struct strAgenda
        {
            public int idAgenda;
            public string anotacion;
            public DateTime fecha;
            public string nombre;
        }

        public int IdAgenda
        {
            get { return (age.idAgenda); }
            set { age.idAgenda = value; }
        }

        public string Anotacion
        {
            get { return (age.anotacion); }
            set { age.anotacion = value; }
        }

        public DateTime Fecha
        {
            get { return (age.fecha); }
            set { age.fecha = value; }
        }

        public string Nombre
        {
            get { return (age.nombre); }
            set { age.nombre = value; }
        }
        #endregion

        public int Insertar()
        {
            agenda.Anotacion = Anotacion;
            agenda.Fecha = Fecha;
            agenda.Nombre = Nombre;

            return (agenda.Insertar(SesionActual.Login));
        }

        public DataTable Listar()
        {
            return agenda.Listar();
        }

        public int Actualizar()
        {
            agenda.IdAgenda = IdAgenda;
            agenda.Anotacion = Anotacion;
            agenda.Fecha = Fecha;
            agenda.Nombre = Nombre;

            return (agenda.Actualizar());
        }

        public int Eliminar()
        {
            agenda.IdAgenda = IdAgenda;

            return (agenda.Eliminar());
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Nombre))
                errores += "Ingrese el nombre\n";
            if (!ctrl.CampoSinNumeros(Nombre))
                errores += "El nombre no debe contener Números\n";
            if (!ctrl.CampoVacio(Anotacion))
                errores += "Ingrese la Anotación\n";

            return errores;
        }
    }
}

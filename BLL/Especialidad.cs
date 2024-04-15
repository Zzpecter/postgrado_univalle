using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Especialidad
    {
        private strEspecialidad esp = new strEspecialidad();
        private DAL.Especialidad especialidad = new DAL.Especialidad();
        private Controladora ctrl = new Controladora();

        #region gets sets struct
        private struct strEspecialidad
        {
            public int idEspecialidad;
            public int idDocente;
            public int idAreaEspecialidad;
            public string nombre;
        }

        public int IdEspecialidad
        {
            get { return (esp.idEspecialidad); }
            set { esp.idEspecialidad = value; }
        }

        public int IdDocente
        {
            get { return (esp.idDocente); }
            set { esp.idDocente = value; }
        }

        public int IdAreaEspecialidad
        {
            get { return (esp.idAreaEspecialidad); }
            set { esp.idAreaEspecialidad = value; }
        }

        public string Nombre
        {
            get { return (esp.nombre); }
            set { esp.nombre = value; }
        }
        #endregion 

        public DataTable Listar()
        {
            return especialidad.Listar();;
        }

        public DataTable ListarABM()
        {
            return especialidad.ListarABM(); ;
        }

        public int Insertar()
        {
            especialidad.IdAreaEspecialidad = IdAreaEspecialidad;
            especialidad.Nombre = Nombre;

            return (especialidad.Insertar(SesionActual.Login));
        }

        public int Actualizar()
        {
            especialidad.IdEspecialidad = IdEspecialidad;
            especialidad.IdAreaEspecialidad = IdAreaEspecialidad;
            especialidad.Nombre = Nombre;

            return (especialidad.Actualizar());
        }

        public int Eliminar()
        {
            especialidad.IdEspecialidad = IdEspecialidad;

            return (especialidad.Eliminar());
        }

        public DataTable Seleccionar()
        {
            especialidad.IdDocente = IdDocente;

            return (especialidad.Seleccionar());
        }

        public string ComprobarCampos()
        {
            string error = string.Empty;

            if (!ctrl.CampoVacio(Nombre))
                error += "Ingrese el nombre de la especialidad";

            if (!ctrl.CampoSinNumeros(Nombre))
                error += "El nombre de la especialidad no puede contener números";

            return error;
        }
    }
}

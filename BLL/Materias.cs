using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Materias
    {

        private DataTable dtMaterias = new DataTable();
        private DAL.Materias materias = new DAL.Materias();
        private Controladora ctrl = new Controladora();
        private strMaterias mat = new strMaterias();

        #region gets sets struct
        private struct strMaterias
        {
            public int idMateria;
            public string nombreMateria;
            public int horasTotales;
        }

        public int IdMateria
        {
            get { return (mat.idMateria); }
            set { mat.idMateria = value; }
        }

        public string NombreMateria
        {
            get { return (mat.nombreMateria); }
            set { mat.nombreMateria = value; }
        }

        public int HorasTotales
        {
            get { return (mat.horasTotales); }
            set { mat.horasTotales = value; }
        }
        #endregion

        public DataTable Listar()
        {
            return materias.Listar();
        }

        public DataTable ListarSinDocente()
        {
            return materias.ListarSinDocente();
        }

        public DataTable ListarHorario()
        {
            return materias.ListarHorario();
        }

        public DataTable ListarSinOrdenar()
        {
            return materias.ListarSinOrdenar();
        }

        public DataTable Seleccionar()
        {
            materias.IdMateria = IdMateria;
            return materias.Seleccionar();
        }

        public int Insertar()
        {
            materias.NombreMateria = NombreMateria;
            materias.HorasTotales = HorasTotales;

            return (materias.Insertar(SesionActual.Login));
        }

        public int Actualizar()
        {
            materias.IdMateria = IdMateria;
            materias.NombreMateria = NombreMateria;
            materias.HorasTotales = HorasTotales;

            return (materias.Actualizar());
        }

        public int Eliminar()
        {
            materias.IdMateria = IdMateria;

            return (materias.Eliminar());
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(NombreMateria))
                errores += "Ingrese el Nombre de la Materia\n";

            if (!ctrl.CampoSinNumeros(NombreMateria))
                errores += "El Nombre de la Materia no debe contener Números\n";

            return errores;
        }

    }
}

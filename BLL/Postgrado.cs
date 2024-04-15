using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Postgrado
    {

        private DataTable dtPostgrado = new DataTable();
        private DAL.Postgrado postgrado = new DAL.Postgrado();
        private Controladora ctrl = new Controladora();
        private strPostgrado post = new strPostgrado();

        #region Estructura, Gets, Sets.
        private struct strPostgrado
        {
            public int idPostgrado;
            public string tipoPostgrado;
            public string nombre;
        }

        public int IdPostgrado
        {
            get { return (post.idPostgrado); }
            set { post.idPostgrado = value; }
        }

        public string TipoPostgrado
        {
            get { return (post.tipoPostgrado); }
            set { post.tipoPostgrado = value; }
        }

        public string Nombre
        {
            get { return (post.nombre); }
            set { post.nombre = value; }
        }
        #endregion

        public DataTable Listar()
        {
            
            return postgrado.Listar();
        }

        public DataTable ListarPostMaterias()
        {
            postgrado.IdPostgrado = IdPostgrado;
            return postgrado.ListarPostMaterias();
        }

        public DataTable ListarMateriasHorario(int idMateria)
        {
            postgrado.IdPostgrado = IdPostgrado;
            return postgrado.ListarMateriasHorario(idMateria);
        }

        public int Insertar()
        {
            postgrado.TipoPostgrado = TipoPostgrado;
            postgrado.Nombre = Nombre;
            return (postgrado.Insertar(SesionActual.Login));
        }

        public DataTable Seleccionar(int idAlumno)
        {
            return postgrado.Seleccionar(idAlumno);
        }

        public DataTable SeleccionarPostgrado()
        {
            postgrado.IdPostgrado = IdPostgrado;
            return postgrado.SeleccionarPostgrado();
        }

        public DataTable SeleccionarMaterias()
        {
            postgrado.IdPostgrado = IdPostgrado;
            return postgrado.SeleccionarMaterias();
        }

        public int Actualizar()
        {
            postgrado.IdPostgrado = IdPostgrado;
            postgrado.Nombre = Nombre;
            postgrado.TipoPostgrado = TipoPostgrado;

            return postgrado.Actualizar();
        }

        public int Eliminar()
        {
            postgrado.IdPostgrado = IdPostgrado;
            return postgrado.Eliminar();
        }
        public string ControlCampos()
        {
            string errores = string.Empty;
            DataTable dtpostgrado = new DataTable();
            bool repete = false;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Nombre))
                errores += "Ingrese el nombre del Postgrado\n";

            //Verificar que no contengan numeros
            if (!ctrl.CampoSinNumeros(Nombre))
                errores += "El nombre no puede contener números";

            //Verifica que no exista postgrado con el mismo nombre
            dtpostgrado = Listar();
            foreach(DataRow dtr in dtpostgrado.Rows)
                if(Nombre.Equals(dtr.ItemArray[1].ToString()))
                    repete = true;

            if(repete)
                errores += "Nombre de Postgrado Repetido";

            return errores;
        }

        public string ControlCamposActualizar()
        {
            string errores = string.Empty;
            DataTable dtpostgrado = new DataTable();

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Nombre))
                errores += "Ingrese el nombre del Postgrado\n";

            //Verificar que no contengan numeros
            if (!ctrl.CampoSinNumeros(Nombre))
                errores += "El nombre no puede contener números";

            return errores;
        }

    }
}

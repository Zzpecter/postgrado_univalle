using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Persona
    {
        private DataTable dtPersona = new DataTable();
        private DAL.Persona prs = new DAL.Persona();
        private Controladora ctrl = new Controladora();

        private strPersona per = new strPersona();

        private struct strPersona
        {
            public int idPersona;
            public string nombres;
            public string apellidos;
            public byte[] foto;
        }

        public int IdPersona
        {
            get { return (per.idPersona); }
            set { per.idPersona = value; }
        }

        public string Nombres
        {
            get { return (per.nombres); }
            set { per.nombres = value; }
        }

        public string Apellidos
        {
            get { return (per.apellidos); }
            set { per.apellidos = value; }
        }

        public byte[] Foto
        {
            get { return (per.foto); }
            set { per.foto = value; }
        }

        public int Insertar()
        {
            prs.IdPersona = IdPersona;
            prs.Nombres = Nombres;
            prs.Apellidos = Apellidos;
            prs.Foto = Foto;

            return (prs.Insertar(SesionActual.Login));
        }

        public int Actualizar()
        {
            prs.IdPersona = IdPersona;
            prs.Nombres = Nombres;
            prs.Apellidos = Apellidos;
            prs.Foto = Foto;

            return (prs.Actualizar());
        }

        public int Eliminar()
        {
            prs.IdPersona = IdPersona;

            return (prs.Eliminar());
        }

        public string ControlCampos()
        {
            string errores = string.Empty;

            //Verificar que los campos no esten vacios
            if (!ctrl.CampoVacio(Nombres))
                errores += "Ingrese su nombre\n";
            if (!ctrl.CampoVacio(Apellidos))
                errores += "Ingrese su apellido\n";

            //Verificar que no contengan numeros
            if (!ctrl.CampoSinNumeros(Nombres))
                errores += "El nombre no puede contener números";
            if(!ctrl.CampoSinNumeros(Apellidos))
                errores += "El apellido no puede contener números";

            return errores;
        }
    }
}

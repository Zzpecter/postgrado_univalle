using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Reportes
    {
        private DAL.Reportes reportes = new DAL.Reportes();

        public DataTable ListarAlumnos(DateTime fechaInferior, DateTime fechaSuperior)
        {
            return reportes.ListarAlumnos(fechaInferior, fechaSuperior);
        }
    }
}

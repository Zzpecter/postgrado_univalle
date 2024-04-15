using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace BLL
{
    public class Notas
    {
        private strNotas nota = new strNotas();
        private DAL.Notas notas = new DAL.Notas();

        #region gets sets struct
        private struct strNotas
        {
            public int idNota;
            public int idAlumno;
            public int idMateria;
            public decimal notaFinal;
        }

        public int IdNota
        {
            get { return (nota.idNota); }
            set { nota.idNota = value; }
        }

        public int IdAlumno
        {
            get { return (nota.idAlumno); }
            set { nota.idAlumno = value; }
        }

        public int IdMateria
        {
            get { return (nota.idMateria); }
            set { nota.idMateria = value; }
        }

        public decimal NotaFinal
        {
            get { return (nota.notaFinal); }
            set { nota.notaFinal = value; }
        }
        #endregion

        public int Insertar()
        {
            notas.IdAlumno = IdAlumno;
            notas.IdMateria = IdMateria;
            notas.NotaFinal = NotaFinal;

            return (notas.Insertar(SesionActual.Login));
        }

        public DataTable Listar()
        {
            return notas.Listar();
        }

        public int Actualizar()
        {
            notas.IdNota = IdNota;
            notas.IdAlumno = IdAlumno;
            notas.IdMateria = IdMateria;
            notas.NotaFinal = NotaFinal;

            return (notas.Actualizar());
        }

        public int Eliminar()
        {
            notas.IdNota = IdNota;

            return (notas.Eliminar());
        }

        public DataTable Seleccionar()
        {
            notas.IdAlumno = IdAlumno;
            notas.IdMateria = IdMateria;

            return notas.Seleccionar();
        }

        public void GenerarDocumento(DataTable dtNotas, string nombre, string postgrado, string directorio)
        {
            //Se crea y se guarda el .txt
            directorio += "Notas.txt";
            string materia = string.Empty;
            System.IO.File.WriteAllText(directorio, string.Empty);
            using (StreamWriter file = new StreamWriter(directorio, true))
            {
                file.WriteLine("NOMBRE: " + nombre);
                file.WriteLine("POSTGRADO: " + postgrado);
                file.WriteLine("FECHA: " + DateTime.Now.ToShortDateString());
                file.WriteLine();
                file.WriteLine();
                file.WriteLine();
                file.WriteLine("Nota      Materia");
                foreach (DataRow dtr in dtNotas.Rows)
                { 
                    notas.IdMateria = Convert.ToInt32(dtr.ItemArray[2].ToString());
                    materia = notas.SeleccionarMat().Rows[0].ItemArray[1].ToString();
                    file.WriteLine(dtr.ItemArray[3].ToString() + "    "  + materia);
                }
            }
        }
    }
}

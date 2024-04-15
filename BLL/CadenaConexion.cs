using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public static class CadenaConexion
    {
        public static void Setear(string direccion)
        {
            string cadena = string.Empty;
            cadena = "Data Source=" + direccion + "; Network Library=DBMSSOCN; Initial Catalog=PostgradoUnivalle; User ID=sa; Password=201191";
            DAL.CadenaConexion.cadena = cadena;
        }

        public static void SetearLocal()
        {
            DAL.CadenaConexion.cadena = "server=(local);DataBase=PostgradoUnivalle;Trusted_Connection=True";
        }
    }
}

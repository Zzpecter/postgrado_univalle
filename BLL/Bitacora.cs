using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Bitacora
    {

        private DataTable dtBitacora = new DataTable();
        private strBitacora bit = new strBitacora();
        private DAL.Bitacora bitacora = new DAL.Bitacora();

        private struct strBitacora
        {
            public DateTime fecha;
            public string usuario;
            public string accion;
            public string tabla;
            public string campo;
            public string valorNuevo;
            public string valorAntiguo;
        }

        public DateTime Fecha
        {
            get { return bit.fecha; }
            set { bit.fecha = value; }
        }

        public string Usuario
        {
            get { return bit.usuario; }
            set { bit.usuario = value; }
        }

        public string Accion
        {
            get { return bit.accion; }
            set { bit.accion = value; }
        }

        public string Tabla
        {
            get { return bit.tabla; }
            set { bit.tabla = value; }
        }

        public string Campo
        {
            get { return bit.campo; }
            set { bit.campo = value; }
        }

        public string ValorNuevo
        {
            get { return bit.valorNuevo; }
            set { bit.valorNuevo = value; }
        }

        public string ValorAntiguo
        {
            get { return bit.valorAntiguo; }
            set { bit.valorAntiguo = value; }
        }

        public DataTable ListarCompleto()
        {
            dtBitacora = bitacora.ListarCompleto();
            return (dtBitacora);
        }

        public int Insertar()
        {
            bitacora.Fecha = Fecha;
            bitacora.Usuario = Usuario;
            bitacora.Accion = Accion;
            bitacora.Tabla = Tabla;
            bitacora.Campo = Campo;
            bitacora.ValorNuevo = ValorNuevo;
            bitacora.ValorAntiguo = ValorAntiguo;

            return (bitacora.Insertar());
        }

        public DataTable ListarFecha(DateTime fechaI, DateTime fechaS)
        {
            bitacora.Fecha = Fecha;

            return (bitacora.ListarFecha(fechaI, fechaS));
        }

        public DataTable ListarFechaUP()
        {
            bitacora.Fecha = Fecha;

            return (bitacora.ListarFechaUP());
        }

        public DataTable ListarFechaDN()
        {
            bitacora.Fecha = Fecha;

            return (bitacora.ListarFechaDN());
        }

        public DataTable ListarUsuario()
        {
            bitacora.Usuario = Usuario;

            return (bitacora.ListarUsuario());
        }

        public DataTable ListarTabla()
        {
            bitacora.Tabla = Tabla;

            return (bitacora.ListarTabla());
        }

        public DataTable ListarTablaCampo()
        {
            bitacora.Tabla = Tabla;
            bitacora.Campo = Campo;

            return (bitacora.ListarTablaCampo());
        }
    }
}

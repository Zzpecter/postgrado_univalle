using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public static class Mensajes
    {
        #region Mensajes
        public static string msjUsuarioInexistente = "No Existe ningún usuario con ese nombre de cuenta!";
        public static string msjPassIncorrecto = "Contraseña incorrecta!";
        public static string msjCampoVacio = "No se llenaron los campos necesarios!";
        public static string msjNombreIncorrecto = "Un nombre no puede contener Números!";
        public static string msjApellidoIncorrecto = "Un apellido no puede contener Números!";
        public static string msjCorreoIncorrecto = "Correo inválido!";
        public static string msjFaltaNombre = "Ingrese su nombre!";
        public static string msjFaltaApellido= "Ingrese su apellido!";
        public static string msjFaltaCorreo = "Ingrese su correo!";
        public static string msjFaltaNuevoPass = "Ingrese nueva contraseña!";
        public static string msjPassNoCoinciden = "Las contraseñas no coinciden!";
        public static string msjFaltaLogin = "Ingrese su login!";
        public static string msjGuardado = "Se guardo todo correctamente!";
        public static string msjPassInvalido = "Contraseña inválida (debe ser de 8 dígitos mínimo y combinar letras, números y opcionalmente caracteres)!";
        public static string msjEliminarRegistro = "Esta seguro que desea eliminar el registro seleccionado?";
        public static string msjLoginRepetido = "Ya existe un usuario con ese Login, por favor escoja otro";
        public static string msjGuardarNumero = "El número ingresado será guardado y podrá ingresar otro, Desea continuar?";
        public static string msjNumeroIncorrecto = "El número que ingresó es incorrecto! Ingrese sólo números";
        public static string msjNacionalidadIncorrecta = "No puede ingresar números en la nacionalidad!";
        public static string msjFaltanDatos = "Debe seleccionar 1 fila para continuar!";
        public static string msjMateriaRepetida = "Esa materia ya existe!";
        public static string msjRequisitoRepetido = "Ese requisito ya existe!";
        public static string msjHoraEntrada = "Hora de entrada no puede ser mayor a la de salida!";
        public static string msjChoque = "Existe choque de horarios!";
        public static string msjRegistroRepetido = "Registro Repetido!";
        public static string msjSeleccioneRegistro = "Seleccione un Registro!";
        public static string msjMateriaEnUso = "No se puede eliminar la materia!\n Esta siendo utilizada por un postgrado!";
        #endregion

        #region Captions
        public static string capError = "Error!";
        public static string capWarning = "Advertencia!";
        public static string capCorrecto = "Correcto!";
        #endregion
    }
}

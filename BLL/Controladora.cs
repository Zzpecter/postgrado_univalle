using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Controladora
    {
        private bool correcto;

        /// <summary>
        /// Comprueba que el campo no este vacio
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public bool CampoVacio(string campo)
        {
            correcto = false;
            if (!string.IsNullOrWhiteSpace(campo))
                correcto = true;
            return correcto;
        }

        /// <summary>
        /// Comprueba que solo se ingresen numeros enteros
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public bool CampoNumerico(string campo)
        {
            correcto = true;
            for (int i = 0; i < campo.Length; ++i)
                if (!char.IsNumber(campo[i]))
                    correcto = false;
            return correcto;
        }

        /// <summary>
        /// Comprueba que no se hayan ingresado numeros
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public bool CampoSinNumeros(string campo)
        {
            correcto = true;
            for (int i = 0; i < campo.Length; ++i)
                if (char.IsNumber(campo[i]))
                    correcto = false;
            return correcto;
        }

        /// <summary>
        /// Comprueba que no se hayan ingresado caracteres
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public bool CampoSinLetras(string campo)
        {
            correcto = true;
            for (int i = 0; i < campo.Length; ++i)
                if (char.IsLetter(campo[i]))
                    correcto = false;
            return correcto;
        }

        /// <summary>
        /// Comprueba que solo se ingresen letras
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public bool CampoSoloTexto(string campo)
        {
            correcto = true;
            for (int i = 0; i < campo.Length; ++i)
                if (!char.IsLetter(campo[i]))
                    correcto = false;
            return correcto;
        }

        /// <summary>
        /// Comprueba que se ingresen correos validos
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public bool CampoCorreo(string campo)
        {
            correcto = true;
            bool foundChar = false;
            bool foundChar2 = false;
            int pos = 0;
            int count = 0;

            //Verifica que no existan campos vacios
            foreach (char c in campo)
                if (c.Equals(' '))
                    correcto = false;

            //Busca que haya solo un '@', si hay mas devuelve falso, ningún correo tiene mas de un '@'
            if (correcto)
            {
                for (int i = 0; i < campo.Length; ++i)
                {
                    if (campo[i].Equals('@') && !foundChar)
                    {
                        foundChar = true;
                        pos = i;
                    }
                    else if (campo[i].Equals('@') && foundChar)
                        correcto = false;
                    else if (!foundChar && i.Equals(campo.Length - 1))
                        correcto = false;
                }
            }

            //Busca un punto despues de '@', puede haber hasta dos puntos en el caso de @empresa.com.bo por ejemplo
            if (correcto && foundChar)
                for (int i = pos; i < campo.Length; ++i)
                {
                    if (campo[i].Equals('.'))
                    {
                        foundChar2 = true;
                        count++;
                    }
                    if (foundChar2 && count < 3)
                        correcto = true;
                    else
                        correcto = false;
                }
            return correcto;
        }

        /// <summary>
        /// Comprueba que se haya ingresado una contraseña lo suficientemente fuerte
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public bool CampoContraseña(string campo)
        {
            bool contieneLetras = false;
            bool contieneNumeros = false;
            bool contieneMayusculas = false;
            bool contieneMinusculas = false;
            bool contieneSimbolos = false;
            bool longitudCorrecta = false;
            int count = 0;

            for (int i = 0; i < campo.Length; ++i)
            {
                if (char.IsLetter(campo[i]))
                    contieneLetras = true;
                if (char.IsNumber(campo[i]))
                    contieneNumeros = true;
                if (char.IsUpper(campo[i]))
                    contieneMayusculas = true;
                if (char.IsLower(campo[i]))
                    contieneMinusculas = true;
                if (char.IsDigit(campo[i]))
                    contieneSimbolos = true;
                if (campo.Length >= 8)
                    longitudCorrecta = true;
            }

            if (contieneLetras)
                count++;
            if (contieneNumeros)
                count++;
            if (contieneMayusculas)
                count++;
            if (contieneMinusculas)
                count++;
            if (contieneSimbolos)
                count++;
            if (longitudCorrecta)
                count++;

            if (count > 3)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Comprueba que dos campos sean idénticos
        /// </summary>
        /// <param name="campo1"></param>
        /// <param name="campo2"></param>
        /// <returns></returns>
        public bool CamposIguales(string campo1, string campo2)
        {
            if (campo1.Equals(campo2))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Determina la fuerza de la contraseña
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public int FuerzaContraseña(string pass)
        {
            int cantidadSimbolos = 0;
            int cantidadNumeros = 0;
            int cantidadMayusculas = 0;
            int fuerza = 0;

            for (int i = 0; i < pass.Length; ++i)
            {
                if (char.IsDigit(pass[i]))
                    cantidadSimbolos++;
                else if (char.IsNumber(pass[i]))
                    cantidadNumeros++;
                else if (char.IsUpper(pass[i]))
                    cantidadMayusculas++;
            }

            if (pass.Length > 8)
                fuerza++;
            if (pass.Length > 12)
                fuerza++;
            if (pass.Length > 16)
                fuerza++;

            if (cantidadNumeros > 0)
                fuerza++;
            if (cantidadNumeros > 2)
                fuerza++;
            if (cantidadNumeros > 4)
                fuerza++;

            if (cantidadSimbolos > 0)
                fuerza++;
            if (cantidadSimbolos > 2)
                fuerza++;

            if (cantidadMayusculas > 0)
                fuerza++;
            if (cantidadMayusculas > 3)
                fuerza++;

            return fuerza;
        }

    }
}

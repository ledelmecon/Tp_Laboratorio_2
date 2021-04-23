using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Metodo que valida el operador 
    /// <param operador></param>
    /// <returns>El operador.</returns>
    /// </summary>
    public static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            
            switch (operador)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                default:
                    operador = "+";
                    return operador;

            
            }
            return operador;
        }


        /// <summary>
        /// Realiza operaciones con sobrecarga de operadores validadas
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado </returns>
        public static double Operar(Numero num1,Numero num2, string operador)
        {
            double sCoperador=0;//sobre carga operador
            switch (ValidarOperador(operador))
            {
                case "+":
                    sCoperador = num1 + num2;
                    break;

                case "-":
                    sCoperador = num1 - num2;
                    break;
                case "/":
                    sCoperador = num1 / num2;
                    break;
               
                case "*":
                    sCoperador = num1 * num2;
                    break;

            }
            return sCoperador;
            
        }


     
    }
}

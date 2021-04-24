using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        //atributos
        private double numero;
       
        /// <summary>
        /// Setea atributo validado uitlizando el metodo ValidarNumero
        /// </summary>
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
                
            }
        }
        #region Constructores
        /// <summary>
        /// Constructor por defecto inicia en 0 el atributo
        /// </summary>
        public Numero()
        {

            this.numero = 0;
            
        }
        /// <summary>
        /// Constructor con parametro String
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            this.SetNumero = numero;

        }
        /// <summary>
        /// Constructor con Double convertido en string
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero) : this(numero.ToString())
        {
           

        }
        #endregion
    

        #region Metodos
        /// <summary>
        /// Valida el número en formato string que se ingresa.
        /// </summary>
        /// <param strNumero></param>
        /// <returns>Retorna numero double o Cero si no lo puedo convertir.</returns>
        public double ValidarNumero(string strNumero)
        {
            double retornoD=0;
            if (double.TryParse(strNumero, out retornoD))
            {
                return retornoD;
            }
            else
            {
                return retornoD;
            }
        }

        /// <summary>
        /// Analiza si la cadena esta compuesta por binarios
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna true si es binario o false si contiene otro caracter.</returns>
        private bool EsBinario(string binario)
        {
            int aux= binario.Length;
            bool retorno=false;
            
            for (int i = 0; i < aux; i++)
            {
                
                if ("1"==binario.Substring(i, 1) || "0" == binario.Substring(i, 1))
                {
                    retorno = true;

                }
                else
                {
                    retorno = false;
                    break;
                    
                }
                
            }
           return retorno;
        }

        /// <summary>
        /// Convierte string binario en string decimal
        /// </summary>
        /// <param name="Binario"></param>
        /// <returns>Retorna String Decimal o Error si no pudo.</returns>
        public string BinarioDecimal(string Binario)
        {
            bool eB = EsBinario(Binario);
            double numDou = 0;
            if (eB ==true) 
            {
            Numero auxNum = new Numero(Binario);
            numDou = auxNum.numero;//guardo el atribuo double
            }
           
            int retorno = default(int);
            string errorMsg = "Valor inválido";
            int residuo = 0;
            int exponente = 0;

            if (numDou > 0)
            {
                do
                {
                    residuo = (int)numDou % 10;
                    numDou = numDou / 10;
                    numDou = Math.Floor(numDou);
                    retorno += (int)(residuo * Math.Pow(2, exponente));
                    exponente++;
                } while (numDou != 0);
            }
            else
            {
                return errorMsg;
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Convierte decimal en binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna binario armado en string</returns>
        public string DecimalBinario(string numero)
        {
            Numero numD = new Numero(numero);
            double numDecimal = Math.Floor(numD.numero);
            string retornoDeciBinario = string.Empty;
            string errorMsg = "Valor inválido";

            if (numDecimal > 0)
            {
                while (numDecimal != 0)
                {
                    
                    if (numDecimal % 2 == 0)
                    {
                        retornoDeciBinario = "0" + retornoDeciBinario;
                    }
                    else
                    {
                        retornoDeciBinario = "1" + retornoDeciBinario;
                    }
                    numDecimal /= 2;
                    numDecimal = Math.Floor(numDecimal);
                }
            }
            else
            {
                retornoDeciBinario = errorMsg;
            }

            return retornoDeciBinario;
        }

        /// <summary>
        /// Sebrocarga convierte decimal en binario /Retorna solo la parte entera.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Entero en binario</returns>
        public string DecimalBinario(double numero)
            {
                //Retorna solo la parte entera.
                
                return DecimalBinario(numero.ToString()); 
             }
        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga operador +
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Sobrecarga operador -
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
      
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Sobrecarga operador *
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga operador / con error de division
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public static double operator /(Numero num1, Numero num2)
        {
            double retornoDb = default(double);

            if (num2.numero == 0)
            {
                retornoDb = double.MinValue;
            }
            else
            {
                retornoDb = num1.numero / num2.numero;
            }
            return retornoDb;
        }
        #endregion


    }

}


    
    
   
  
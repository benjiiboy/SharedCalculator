using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator
{
    public class Lommeregner
    {
        /// <summary>
        /// Dette er en metode til at lægge to tal sammen
        /// </summary>
        /// <param name="InputA"></param>
        /// <param name="InputB"></param>
        /// <returns></returns>
        public double Addition(double InputA, double InputB)
        {
            return InputA + InputB;
        }

        /// <summary>
        /// Dette er en metode til at trække to metoder fra hinanden 
        /// </summary>
        /// <param name="InputA"></param>
        /// <param name="InputB"></param>
        /// <returns></returns>
        public double Subtraction(double InputA, double InputB)
        {
            return InputA - InputB;
        }

        /// <summary>
        /// Dette er en metode til at gange to talt
        /// </summary>
        /// <param name="InputA"></param>
        /// <param name="InputB"></param>
        /// <returns></returns>
        public double Multiplication(double InputA, double InputB)
        {
            return InputA * InputB;
        }

        /// <summary>
        /// Dette er en metode til at dividerer to tal med hinanden
        /// </summary>
        /// <param name="InputA"></param>
        /// <param name="InputB"></param>
        /// <returns></returns>
        public double Division(double InputA, double InputB)
        {
            return InputA / InputB;
        }

        /// <summary>
        /// Dette er en metode til at få kvadratroden af ét input tal
        /// </summary>
        /// <param name="InputA"></param>
        /// <returns></returns>
        public double Sqrt(double InputA)
        {
            return Math.Sqrt(InputA);
        }


    }
}

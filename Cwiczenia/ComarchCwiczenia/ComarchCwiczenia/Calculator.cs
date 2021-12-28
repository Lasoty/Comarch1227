/*
 * Author: Leszek Lewandowski
 * Date: 28-12-2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia
{
    public class Calculator
    {
        public static int Calculate(int x, int y, string operand) //+, -, *, /, %
        {
            int result = 0;
            switch (operand)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
            }

            return result;
        }

        internal static void ShowArray(int[] tab)
        {
            Console.Write("[");
            foreach (int item in tab)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("]");
        }

        internal static int[] SortArray(int[] tab)
        {
            int[] result = new int[tab.Length];
            tab.CopyTo(result, 0);

            for (int j = 0; j <= result.Length - 2; j++)
            {
                for (int i = 0; i <= result.Length - 2; i++)
                {
                    if (result[i] > result[i + 1])
                    {
                        int temp = result[i + 1];
                        result[i + 1] = result[i];
                        result[i] = temp;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Sumuje dowolną ilośc liczb całkowitych
        /// </summary>
        /// <param name="numbers">Liczba do zsumowania</param>
        /// <returns>Suma liczb całkowitych</returns>
        public static int Add(params int[] numbers)
        {
            // Inicjowanie zmiennej 
            int result = 0;

            if (numbers != null)
            {
                result = numbers.Sum();
            }

            return result;
        }

        public static float Add(float x, float y)
        {
            return x + y;
        }
    }
}

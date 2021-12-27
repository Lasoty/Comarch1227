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
    }
}

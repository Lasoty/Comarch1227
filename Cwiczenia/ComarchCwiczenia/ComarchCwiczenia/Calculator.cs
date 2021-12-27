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
    }
}

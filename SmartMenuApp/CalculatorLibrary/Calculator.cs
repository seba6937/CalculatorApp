using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double number1, double number2)
        {
            double res = number1 + number2;
            return res;

        }

        public static double Subtract(double number1, double number2)
        {
            double res = number1 - number2;
            return res;
        }

        public static double Multiply(double number1, double number2)
        {
            double res = number1 * number2;
            return res;
        }

        public static double Divide(double number1, double number2)
        {
            double res = number1 / number2;
            return res;
        }

        public static double Sum(double[] numbers)
        {
            double res = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res = numbers[i] + res;
            }
            return res;
        }

        public static double Minimum(double[] numbers)
        {
            double res = Maximum(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < res)
                {
                    res = numbers[i];
                }
            }
            return res;
        }

        public static double Maximum(double[] numbers)
        {
            double res = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > res)
                {
                    res = numbers[i];
                }
            }
            return res;
        }

        public static double Average(double[] numbers)
        {
            double all = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                all = all + numbers[i];
            }
            double avg = all / numbers.Length;
            return avg;
        }
    }
}

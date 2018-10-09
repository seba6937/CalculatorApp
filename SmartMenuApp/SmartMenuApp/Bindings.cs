using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace CalculatorApp
{
    public class Bindings
    {
        public string call(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("skriv 2 tal seperaret med enter: ");
                    return Calculator.Add(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())).ToString();

                case 2:
                    Console.WriteLine("skriv 2 tal seperaret med enter: ");
                    return Calculator.Subtract(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())).ToString();

                case 3:
                    Console.WriteLine("skriv 2 tal seperaret med enter: ");
                    return Calculator.Multiply(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())).ToString();

                case 4:
                    Console.WriteLine("skriv 2 tal seperaret med enter: ");
                    return Calculator.Divide(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())).ToString();
                case 5:
                    Console.WriteLine("Skriv nogle tal: ");
                    List<double> numbersMax = new List<double>();
                    while (Console.ReadLine() != null)
                    {
                        double addNumbers;
                        double.TryParse(Console.ReadLine(), out addNumbers);
                        numbersMax.Add(addNumbers);
                    }
                    return Calculator.Maximum(numbersMax.ToArray()).ToString();
                case 6:
                    Console.WriteLine("Skriv nogle tal:");
                    List<double> numbersMin = new List<double>();
                    while (Console.ReadLine() != "")
                    {
                        numbersMin.Add(double.Parse(Console.ReadLine()));
                    }
                    return Calculator.Minimum(numbersMin.ToArray()).ToString();
                case 7:
                    Console.WriteLine("Skriv nogle tal:");
                    List<double> numbersAvg = new List<double>();
                    while (Console.ReadLine() != "")
                    {
                        numbersAvg.Add(double.Parse(Console.ReadLine()));
                    }
                    return Calculator.Average(numbersAvg.ToArray()).ToString();
                case 8:
                    Console.WriteLine("Skriv nogle tal:");
                    List<double> numbersSum = new List<double>();
                    while (Console.ReadLine() != "")
                    {
                        numbersSum.Add(double.Parse(Console.ReadLine()));
                    }
                    return Calculator.Sum(numbersSum.ToArray()).ToString();
            }
            return "Du kan kun vælge tal der er vist i menuen";
        }
        public void exit()
        {
            Environment.Exit(0);
        }
    }
}
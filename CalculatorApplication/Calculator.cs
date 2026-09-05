using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    internal class Calculator
    {

    }
    public delegate T Formula<T>(T arg1, T arg2);

    public class CalculatorClass
    {
        public Formula<double> info;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }
        public double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }

        private Formula<double> calculateHandler;

        public event Formula<double> CalculateEvent
        {
            add
            {
                calculateHandler += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                calculateHandler -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }

        public double Calculate(double num1, double num2)
        {
            if (calculateHandler != null)
            {
                return calculateHandler(num1, num2);
            }
            else
            {
                return 0.0;
            }
        }
    }

}
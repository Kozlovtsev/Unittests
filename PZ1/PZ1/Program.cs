using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Addition: " + calculator.Add(10, 5));
            Console.WriteLine("Subtraction: " + calculator.Subtract(10, 5));
            Console.WriteLine("Multiplication: " + calculator.Multiply(10, 5));
            Console.WriteLine("Division: " + calculator.Divide(10, 5));
        }
    }
}

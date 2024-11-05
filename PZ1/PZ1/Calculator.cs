using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1
{
    public class Calculator
    {
        private void ValidateInput(double a, double b)
        {
            if (double.IsNaN(a) || double.IsNaN(b) || double.IsInfinity(a) || double.IsInfinity(b))
            {
                throw new ArgumentException("Входные данные должны быть действительными числами");
            }
        }

        public double Add(double a, double b)
        {
            ValidateInput(a, b);
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            ValidateInput(a, b);
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            ValidateInput(a, b);
            return a * b;
        }

        public double Divide(double a, double b)
        {
            ValidateInput(a, b);
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль не допускается.");
            return a / b;
        }

        public async Task<double> AddAsync(double a, double b)
        {
            ValidateInput(a, b);
            await Task.Delay(1000);
            return a + b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Helpers
{
    public static class Calculator
    {
        public static double Plus(double n1, double n2) => n1 + n2;

        public static double Minus(double n1, double n2) => n1 - n2;

        public static double Multiplication(double n1, double n2) => n1 * n2;

        public static double Divide(double n1, double n2)
        {
            if (n2 == 0) throw new DivideByZeroException("Ошибка деления на 0!");

            return n1 / n2;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //кортеж

            int n1 = 5;
            int n2 = 7;

            Console.WriteLine($"n1 = {n1}, n2 = {n2}");
            (n1, n2) = (n2, n1);
            Console.WriteLine($"n1 = {n1}, n2 = {n2}");

            //кортеж






            Console.ReadLine();
        }
    }
}

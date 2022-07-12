using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Entities;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //кортеж и операции с ним

            int n1 = 5;
            int n2 = 7;

            //Console.WriteLine($"n1 = {n1}, n2 = {n2}");
            (n1, n2) = (n2, n1);
            //Console.WriteLine($"n1 = {n1}, n2 = {n2}");

            List<int> _list = new List<int>(new int[] { 1, 2, 3 });
            int[] _array = { 1, 2, 3, 4, 5 };

            (int, int) result = Helpers.OtherHelpers.Calc_Sum_Count(_list);
            //Console.WriteLine($"sum = {result.Item1}, count = {result.Item2}");

            //кортеж и операции с ним

            int a, b, c;
            a = b = c = 34 * 2 / 4; // 17

            int x = n1 >= n2 ? 1 : 0;
            //Console.WriteLine(x);

            //for (int i = 1;i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (int i in _list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(_array[^1]);

            int fc = Helpers.OtherHelpers.Factorial(10);
            //Console.WriteLine(fc);

            //switch (a)
            //{
            //    case 1:
            //        break;
            //}

            //Console.WriteLine((int)Helpers.OtherHelpers.types.second);
            //Console.WriteLine(Helpers.OtherHelpers.types.first);
            //Console.WriteLine(Helpers.OtherHelpers.types.first.ToString());

            int? t1 = null;
            //Console.WriteLine(t1);

            Person _person = new Person("Albert", "Danilov");

            //_person.SecondName = "";

            Object _obj1 = new Object();
            Object _obj2 = new Object();

            //Console.WriteLine(_obj1.ToString());
            //Console.WriteLine(_obj1.GetHashCode());
            //Console.WriteLine(_obj2.GetHashCode());
            //Console.WriteLine(_obj2.GetType());

            bool eq = _obj1.Equals(_obj2) ? true : false;

            //Console.WriteLine(eq);

            Lazy<Person> _person2 = new Lazy<Person>();
            _person2.Value.Name = "Albert";

            //Console.WriteLine(_person2.Value.Name);


            //Hashtable tbl = new Hashtable();

            int[] _array2 = { 5, 7, 4, 2, 6, 9, 7, 65, 4, 3, 2, 2, 3 };

            foreach (int item in _array2) Console.Write($"{item} ");
            Console.WriteLine();
            Console.WriteLine();

            Helpers.Sorting.Bubble_Sort(ref _array2);

            foreach (int item in _array2) Console.Write($"{item} "); 
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

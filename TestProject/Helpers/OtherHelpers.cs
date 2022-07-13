using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Helpers
{
    public static class OtherHelpers
    {
        public static (int, int) Calc_Sum_Count(List<int> _list)
        {
            return (_list.Sum(), _list.Count());
        }

        public static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }

        public enum types
        {
            first,
            second,
            third
        }

        public static string StringFunc1()
        {
            string result = string.Empty;

            for (int i = 0; i < 100000; i++)
            {
                result += Guid.NewGuid().ToString();
            }

            return result;
        }

        public static string StringFunc2()
        {
            string result = string.Empty;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 100000; i++)
            {
                sb.Append(Guid.NewGuid().ToString());
            }

            return sb.ToString();
        }
    }
}

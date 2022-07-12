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
    }
}

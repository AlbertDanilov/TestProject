using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Helpers
{
    public static class Sorting
    {
        public static void Bubble_Sort(ref int[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            for (int j = 0; j < _array.Length - i - 1; j++)
            {
                if (_array[j] > _array[j + 1]) (_array[j], _array[j + 1]) = (_array[j + 1], _array[j]);
            }
        }
    }
}

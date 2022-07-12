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
    }
}

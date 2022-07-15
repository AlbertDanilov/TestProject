using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Entities;

namespace TestProject.Helpers
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.Name.Equals(y.Name, StringComparison.InvariantCultureIgnoreCase) && 
                   x.SecondName.Equals(y.SecondName, StringComparison.InvariantCultureIgnoreCase) && 
                   (x.LastName == null || y.LastName == null || x.LastName != null && y.LastName != null && x.LastName.Equals(y.SecondName, StringComparison.InvariantCultureIgnoreCase));
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}

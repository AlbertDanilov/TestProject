using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public string SecondName { get; }
        public string LastName { get; set; }


        public Person() {}

        public Person(string Name, string SecondName, string LastName = null)
        {
            this.Name = Name;
            this.SecondName = SecondName;
            this.LastName = LastName;
        }
    }
}

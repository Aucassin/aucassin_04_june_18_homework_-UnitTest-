using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aucassin_04_june_18_homework__UnitTest_
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            this.Name = "Jack";
            this.Age = 30;
        }
    }
}

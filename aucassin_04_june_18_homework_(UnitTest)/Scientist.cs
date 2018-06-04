using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aucassin_04_june_18_homework__UnitTest_
{
    public class Scientist : Person
    {
        public int IQ { get; set; }
        public Scientist()
        {
            this.Name = "Prof Zoidberg";
            this.Age = 70;
            this.IQ = 180;
        }
    }
}

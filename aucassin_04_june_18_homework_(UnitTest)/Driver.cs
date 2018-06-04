using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aucassin_04_june_18_homework__UnitTest_
{
    public class Driver : Person
    {
        public string Car { get; set; }
        public Driver()
        {
            this.Name = "Vin";
            this.Age = 35;
            this.Car = "Lancer";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aucassin_04_june_18_homework__UnitTest_
{
    public class Villain : Person
    {
        public bool HasALethalWeapon { get; set; }
        public Villain()
        {
            this.Name = "Dr. Langeskov";
            this.Age = 40;
            this.HasALethalWeapon = false;
        }
    }
}

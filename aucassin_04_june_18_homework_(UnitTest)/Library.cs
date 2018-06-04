using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aucassin_04_june_18_homework__UnitTest_
{
    public class Library
    {
        public List<string> Books { get; set; }
        public Library()
        {
            this.Books = new List<string> { "book1", "book2", "book3" };
        }
    }
}

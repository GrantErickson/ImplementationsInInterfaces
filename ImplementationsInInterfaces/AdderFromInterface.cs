using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationsInInterfaces
{
    public class AdderFromInterface : IBase
    {
        public  AdderFromInterface(string a)
        {
            A = a;
        }

        public string A { get; set; }

        public string Dupe(int count)
        {
            return string.Concat(Enumerable.Repeat(A, count));
        }
    }
}

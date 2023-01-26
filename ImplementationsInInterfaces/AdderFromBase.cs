using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationsInInterfaces
{
    public class AdderFromBase: Base
    {
        public AdderFromBase(string a)
        {
            A = a;
        }
        public override string A { get; set; }
        public override string Dupe(int count)
        {
            return string.Concat(Enumerable.Repeat(A, count));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationsInInterfaces
{
    public abstract class Base
    {
        public abstract string A { get; set; }
        public abstract string Dupe(int count);
        public string Add(string b) => A + b;
    }
}

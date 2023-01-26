using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationsInInterfaces
{
    public interface IBase
    {
        public string A { get; set; }

        public string Dupe(int count);

        public string Add(string b) => A + b;



    }
}

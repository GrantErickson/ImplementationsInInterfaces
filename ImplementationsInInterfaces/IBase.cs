using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationsInInterfaces
{
    interface IBase
    {
        string A { get; set; }

        string Dupe(int count);

        string Add(string b) => A + b;



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBaseInterface
{
     interface IBaseInterface
    {
        void Method1();
    }
    interface IDerivedInterface:IBaseInterface
    { void Method2(); }
}

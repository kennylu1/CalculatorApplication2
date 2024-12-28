using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class InterfaceImplementer:IMyInterface

    {
        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement()called.");
        }
        public void ParentInterfaceMethod() {
            Console.WriteLine("ParentInterfaceMethod()called.");
        }
    }
}
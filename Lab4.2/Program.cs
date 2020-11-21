using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A(b);
            B1 b1 = new B1();
            b1.GetLvl(100, 1);
            
        }
    }
}

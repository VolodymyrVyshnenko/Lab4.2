using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab4._2
{
    class B
    {
        public string name = "Billy";
        public int lvl = 1;
        public B()
        {
            Console.WriteLine();
            Console.ReadLine();

        }

        public virtual void GetLvl(int n1 = 1, int n2 = 2, int n3 = 3, int n4 = 4)
        {
            lvl++;
        }
        
    }
}
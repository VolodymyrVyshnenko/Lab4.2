using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class B3 : B
    {
        public int course = 2;
        public override void GetLvl(int n1, int n2 = 2, int n3 = 3, int n4 = 4)
        {
            lvl += course;
        }
    }
}
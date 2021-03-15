 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111
{
        public interface IElain
        {
        int age { get; set; }
        string name { get; set; }
        bool onlihansyoja { get; set; }

        string palautaeläimennimi();
        int palautaeläimenikä();
        bool palautaliha();
        }
}





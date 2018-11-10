using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLADIMIR_RAEVSKY_GBCS_HM2
{
    partial class Homework2
    {
        static void DigitCount(int number)
        {
            int count = 1;
           
            while(number != 1)
            {
                number /= 10;
                ++count;
            }
            
            Print($"The number of digits: {count}");
        }
    }
}

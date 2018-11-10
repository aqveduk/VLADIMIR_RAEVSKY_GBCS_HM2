using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLADIMIR_RAEVSKY_GBCS_HM2
{
    partial class Homework2
    {
        static void VarSum(int number)
        {

            int sum = 0;
            while (number != 0)
            {
                if (number > 0 && number % 2 == 1)
                {
                    sum = sum + number;
                }
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Result is: {sum}");
        }

    }

}

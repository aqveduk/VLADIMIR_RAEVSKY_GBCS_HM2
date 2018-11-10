using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLADIMIR_RAEVSKY_GBCS_HM2
{
    partial class Homework2
    {

        static int SumOfNum(int num)
        {
            int k = 0;
            int m = 0;

            while (num != 0)
            {
                //123  //12  //1
                k = num % 10; //3  //2  //1
                num /= 10; //12  //1  //0
                m += k; //0 + 3  //3 + 2  //5+1
            }
            return m;
        }

        static bool IsGood(int num)
        {
            if (num % SumOfNum(num) == 0)
                return true;
            else
                return false;
        }

        static void AllGoodNum()
        {
            DateTime start = DateTime.Now;
            for (int i = 1; i < 1000000; i++)
            {
               
                if (IsGood(i))
                {
                    Console.WriteLine("{0} is a good number", i);
                }
                
            }
            Console.WriteLine(DateTime.Now - start);
        }

        
    }
}

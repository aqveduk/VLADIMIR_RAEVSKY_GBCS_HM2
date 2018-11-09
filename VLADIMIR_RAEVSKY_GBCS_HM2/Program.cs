using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLADIMIR_RAEVSKY_GBCS_HM2
{
    class Program
    {
        static void Pause(string message = "Press any key to continue"){ Console.Write(message); Console.ReadKey(); }
        static void Print(string text) { Console.WriteLine(text); }

        static void Main(string[] args)
        {
            int min;

            Print("Enter the first value: ");
            int first = int.Parse(Console.ReadLine());

            Print("Enter the second value: ");
            int second = int.Parse(Console.ReadLine());

            Print("Enter the third value: ");
            int third = int.Parse(Console.ReadLine());

            if (first < second)
            {
                min = first;
            }
            else
            {
                min = second;
            }

            Print((min < third) ? $"The lowest number is: {min}" : $"The lowest number is: {third}");

            Pause();

        }



    }
}

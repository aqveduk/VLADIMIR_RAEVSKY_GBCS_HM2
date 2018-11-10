using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLADIMIR_RAEVSKY_GBCS_HM2
{
    partial class Homework2
    {
        static void BMIMod(double weight)
        {
            Console.Write("Enter your height: ");

            double height = Double.Parse(Console.ReadLine());
            while (true)
            {
                if (height < 0 || height > 3.5)
                {
                    Print("You have entered incorrect value. Please use select from this range 0  - 3.5");
                    height = Double.Parse(Console.ReadLine());
                }
                else
                    break;
            }

            double index = weight / (height * height);

            if (index < 18.5 && index > 0)
                Console.WriteLine($"Your index is {index}. Extremely low! You have to add the weight.");
            if (index > 18.5 && index < 24.99)
                Console.WriteLine($"Your index is {index}. Congratulations! You have a good weight.");
            if (index > 25 && index < 30)
                Console.WriteLine($"Your index is {index}. Good, but you can lose some weight.");
            if (index > 30)
                Console.WriteLine($"Your index is {index}. Sorry, you are too fat. Please lose the weight as soon as possible!");

        }
    }
}

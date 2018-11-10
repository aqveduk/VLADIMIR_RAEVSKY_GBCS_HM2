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
            const double INDEXREF = 21.745; //Эталон индекса массы тела

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
            double weightOff = Math.Abs(weight - (INDEXREF * (height * height))); //нахождение разницы в весе

            if (index < 18.5 && index > 0)
            {
                Console.WriteLine($"Your index is {index}. Extremely low! You have to add {weightOff} kg to your weight.");
            }
            if (index > 18.5 && index < 24.99)
                Console.WriteLine($"Your index is {index}. Congratulations! You have a good weight.");
            if (index > 25 && index < 30)
                Console.WriteLine($"Your index is {index}. Good, but you have to reduce your weight on {weightOff} kg.");
            if (index > 30)
                Console.WriteLine($"Your index is {index}. Sorry, you are too fat. Please lose {weightOff} kg in weight as soon as possible!");

        }
    }
}

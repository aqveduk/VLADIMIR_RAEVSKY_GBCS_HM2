using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLADIMIR_RAEVSKY_GBCS_HM2
{
    partial class Homework2
    {
        static void Pause(string message = "Press any key to continue") { Console.Write(message); Console.ReadKey(); }
        static void Print(string text) { Console.WriteLine(text); }

        public static int IntChecker()
        {
            while (true)
            {
                String input = Console.ReadLine();
                if (Int32.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Print("Please enter the interger number:\n");
                }
            }
        }

        static void Minimum(int first, int second, int third) {
            int min;

            if (first < second)
            {
                min = first;
            }
            else
            {
                min = second;
            }

            Print((min < third) ? $"The lowest number is: {min}" : $"The lowest number is: {third}\n");
        }

        static void Main(string[] args)
        {
            //MENU
            Print("Welcome to GeekBrains homework number 2.\n Enter the task number: ");
            int tasks = int.Parse(Console.ReadLine());
            switch (tasks)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    //Task4();

                    break;
                case 5:
                    //Task5();

                    break;
                case 6:
                    //Task6();

                    break;
                case 7:
                    //Task7();

                    break;

            }

            Pause();

        }

        static void Task1()
        {
            //FIRST TASK 
            Print("Enter the first value: ");
            int first = int.Parse(Console.ReadLine());

            Print("Enter the second value: ");
            int second = int.Parse(Console.ReadLine());

            Print("Enter the third value: ");
            int third = int.Parse(Console.ReadLine());

            Minimum(first, second, third);
        }

        static void Task2()
        {
            //SECOND TASK
            Print("Enter the  value to count digits on it: ");
            int digit = int.Parse(Console.ReadLine());
            DigitCount(digit);
        }

        static void Task3()
        {
            Print("Enter values to calculate the sum of all positive odd numbers: ");
            int value = int.Parse(Console.ReadLine());
            VarSum(value);
        }
    }
}

/*
 * 
    Vladimir Raevskiy
    Второй урок
    TASK1 - ПОИСК МИНИМАЛЬНОГО ЗНАЧЕНИЯ
    TASK2 - СЛОЖЕНИЕ ВСЕХ СОСТАВЛЯЮЩИХ ЧИСЛА
    TASK3 - СУММА ВСЕХ ПОЛОЖИЬЕЛЬНЫХ ЧИСЕЛ, БОЛЬШИХ 0
    TASK4 - ВВОД ЛОГИНА И ПАРОЛЯ
    TASK5 - ИМТ С УКАЗАНИЕМ РАЗНИЦЫ
*
*/

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
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:

                case 7:
                    Print("Will be ready soon.");
                    break;
                default:
                    Print("Incorrect input");
                    break;

            }
            
            Pause();
        }

        static void Task1()
        {
            //FIRST TASK -  ПОИСК МИНИМАЛЬНОГО ЗНАЧЕНИЯ
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
            //SECOND TASK  - СЛОЖЕНИЕ ВСЕХ СОСТАВЛЯЮЩИХ ЧИСЛА
            Print("Enter the  value to count digits on it: ");
            int digit = int.Parse(Console.ReadLine());
            DigitCount(digit);
        }

        static void Task3()
        {
            //THIRD TASK  - СУММА ВСЕХ ПОЛОЖИЬЕЛЬНЫХ ЧИСЕЛ, БОЛЬШИХ 0
            Print("Enter values to calculate the sum of all positive odd numbers: ");
            int value = int.Parse(Console.ReadLine());
            VarSum(value);
        }

        static void Task4()
        {   
            //FORTH TASK -  ВВОД ЛОГИНА И ПАРОЛЯ
            Console.Write("Welcome to login window.\nTo sign-up into the system use your username: ");
            string username = Console.ReadLine();
            LoginForm(username);
        }

        static void Task5()
        {
            //FIFTH TASK - ИМТ С УКАЗАНИЕМ РАЗНИЦЫ
            Console.Write("Welcome to BMI index calculatoin.\nEnter your weight: ");
            double weight = Double.Parse(Console.ReadLine());
            BMIMod(weight);
            
        }
    }
}


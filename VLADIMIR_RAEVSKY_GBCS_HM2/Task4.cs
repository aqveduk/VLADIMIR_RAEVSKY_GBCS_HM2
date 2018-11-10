using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLADIMIR_RAEVSKY_GBCS_HM2
{
    partial class Homework2
    {
        static void LoginForm(string username)
        {
            string passInDB = "GeekBrains";
            int count = 0;
            if (username == "root")
            {
                do
                {
                    count++;
                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    if (password == passInDB)
                    {
                        Print($"WELCOM! Your login and password is in DataBase. Number of tries: {count}");
                        return;
                    }
                    else
                    {
                        Print($"Sorry, the password is incorrect.");
                    }
                } while (count < 3);
                Print($"\nYou have incorrectly typed your password more than 3 times. Try again later.");  //Неправильно напечатали более 3 раз

            }
            else
            {
                Print("Sorry, we did not find your account in the system.");
            }

        }
    }
}

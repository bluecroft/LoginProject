using System;
using System.IO;
namespace LoginProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to login or signout?");
            string UInput;
            UInput = Console.ReadLine();
            if (UInput == "Register")

            {
                Console.WriteLine("Type in username");
                string username;
                username = Console.ReadLine();
                Console.WriteLine("Type in password");
                string password;
                password = Console.ReadLine();

                string user = $"{username}, {password}";

                StreamWriter tjh = null; ;
                try
                {
                    tjh = new StreamWriter("C:/Users/K31361/Register.txt");
                    tjh.WriteLine(user);

                    tjh.Close();

                }
                catch
                {
                    Console.WriteLine("error");
                }
                

            }
            else
            {
                Console.WriteLine("Type in your username");
                Console.WriteLine("Type in your password");
            }
        }
    }
}



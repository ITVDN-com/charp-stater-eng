using System;

namespace Authentication
{
    class Program
    {
        static void Main()
        {
            string login = "Admin";
            string password = "P@ssw0rd";

            Console.Write("Enter login: ");

            // In line 17, create a string local variable with a name usersLogin 
            // and accept the users input.
            
            string usersLogin = Console.ReadLine(); 
            
            if (login == usersLogin)
            {
                Console.Write("Please, Enter your password: ");
                string usersPassword = Console.ReadLine();
                
                if (password == usersPassword)
                {
                    Console.WriteLine("Hello {0}, You are logged in.", usersLogin);
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                }                
            }
            else
            {
                Console.WriteLine("No user with such a name.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}


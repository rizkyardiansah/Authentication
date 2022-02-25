using System;
using System.Collections.Generic;

namespace Authentication
{
    class MainClass
    {
        public static List<Account> user = new List<Account>();
        static void Main(string[] args)
        {
            string userChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("==BASIC AUTHENTICATION==");
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Show User");
                Console.WriteLine("3. Search User");
                Console.WriteLine("4. Login");
                Console.WriteLine("5. Update User");

                Console.WriteLine("6. Delete User");
                Console.WriteLine("7. Exit");

                Console.Write("Choose: ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.Clear();
                        userCRUD.createAccount(user);
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Clear();
                        userCRUD.showAccounts(user);
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        userCRUD.SearchAccount(user);
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.Clear();
                        userCRUD.loginAccount(user);
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.Clear();
                        userCRUD.UpdateUser(user);
                        break;
                    
                    case "6":
                        Console.Clear();
                        userCRUD.DeleteUser(user);
                        break;

                    case "7":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            } while (true);
        }


    }
}

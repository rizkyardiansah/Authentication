using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication
{
    class userCRUD
    {
        public static void createAccount(List<Account> user)
        {
            Console.WriteLine("==CREATE USER==");
            Console.Write("Firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (firstname.Length < 2 || lastname.Length < 2 || password.Length < 2)
            {
                Console.WriteLine("======== Invalid Data =======");
            }
            else
            {
                string username = firstname.Substring(0, 2) + lastname.Substring(0, 2);
                Account newAccount = new Account(firstname, lastname, password, username);
                user.Add(newAccount);
                Console.WriteLine("======== Account Created =======");
            }
        }

        public static void loginAccount(List<Account> user)
        {
            Console.WriteLine("==LOGIN USER==");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            foreach (Account a in user)
            {
                if (a.UserName.Equals(username) && a.Password.Equals(password))
                {
                    Console.WriteLine("======== Login Success =======");
                    return;
                }
            }
            Console.WriteLine("======== Login Failed =======");
        }

        public static void showAccounts(List<Account> user)
        {
            Console.WriteLine("==SHOW ACCOUNTS==");
            foreach (Account a in user)
            {
                Console.WriteLine("=================");
                Console.WriteLine($"NAME: {a.FirstName} {a.LastName}");
                Console.WriteLine($"USERNAME: {a.UserName}");
                Console.WriteLine($"PASSWORD: {a.Password}");
                Console.WriteLine("=================");
            }
        }

        public static void SearchAccount(List<Account> username)
        {
            Console.WriteLine("==SEARCH ACCOUNT==");
            Console.Write("Username : ");
            string inp = Console.ReadLine();
            Console.Clear();

            foreach (Account user in username)
            {
                if (user.UserName == inp)
                {
                    Console.WriteLine("======== User Found =======");
                    Console.WriteLine("\t SHOW DATA USER");
                    Console.WriteLine($"First Name \t: {user.FirstName} \nLast Name \t: {user.LastName} \nUsername \t: {user.UserName} \nPassword \t: {user.Password}");
                    return;
                }
            }

            Console.WriteLine($"======== User Not Found =======");
        }

        public static void UpdateUser(List<Account> username)
        {
            string inp;
            string inp2;
            string back;
            string newUsername;
            Console.WriteLine("===================================");
            Console.WriteLine("Masukkan username yang akan di Edit");
            Console.Write("Username : ");
            inp = Console.ReadLine();
            Console.Clear();
            foreach (Account user in username)
            {
                if (user.UserName == inp)
                {
                    Console.WriteLine($"======== User Found =======");
                    Console.WriteLine("Edit Option : \n1. First Name \n2. Last Name \n3. Edit All \n4. Exit");
                    Console.Write("Choose Option : ");
                    int inpAngka = Convert.ToInt32(Console.ReadLine());
                    switch (inpAngka)
                    {
                        case 1:
                            do
                            {
                                Console.Write("Edit First Name : ");
                                inp = Console.ReadLine();

                                Console.Write("Sure ? ");
                                back = Console.ReadLine();
                                Console.Clear();
                            } while (inp.Equals("y"));

                            if (back.Equals("y"))
                            {
                                user.FirstName = inp;
                                newUsername = $"{user.FirstName.Substring(0,2)}{user.LastName.Substring(0, 2)}";
                                user.UserName = newUsername;
                                Console.WriteLine($"======== Firstname Updated =======");
                            }
                            break;
                        case 2:
                            do
                            {
                                Console.Write("Edit Last Name : ");
                                inp = Console.ReadLine();

                                Console.Write("Sure ? ");
                                back = Console.ReadLine();

                            } while (inp.Equals("y"));

                            if (back.Equals("y"))
                            {
                                user.LastName = inp;
                                newUsername = $"{user.FirstName.Substring(0, 2)}{user.LastName.Substring(0, 2)}";
                                user.UserName = newUsername;
                                Console.WriteLine($"======== Lastname Updated =======");
                            }
                            break;
                        case 3:
                            do
                            {
                                Console.Write("Edit First Name : ");
                                inp = Console.ReadLine();

                                Console.Write("Edit Last Name : ");
                                inp2 = Console.ReadLine();

                                Console.Write("Yakin ? (y/t)");
                                back = Console.ReadLine();
                            } while (back.Equals("t"));

                            if (back.Equals("y"))
                            {
                                user.FirstName = inp;
                                user.LastName = inp2;
                                newUsername = $"{user.FirstName.Substring(0, 2)}{user.LastName.Substring(0, 2)}";
                                user.UserName = newUsername;
                                Console.WriteLine($"======== Update Succeded =======");
                            }
                            break;

                        case 4:
                            break;

                        default:
                            Console.WriteLine($"======== Wrong Input =======");
                            break;
                    }

                    return;
                }
            }

            Console.WriteLine($"======== User Not Found =======");
        }

        public static void DeleteUser(List<Account> username)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Masukkan username yang akan di Delete");
            Console.Write("Username : ");
            string inp = Console.ReadLine();

            foreach (Account user in username)
            {
                if (user.UserName == inp)
                {
                    Console.WriteLine("======== Username Ditemukan =======");
                    Console.WriteLine("Yakin Hapus ? ");
                    string back = Console.ReadLine();

                    username.Remove(user);
                    Console.WriteLine("\tDelete Berhasil");
                    return;
                }

                Console.WriteLine("User tidak ditemukan");
            }
            
        }
    }
}

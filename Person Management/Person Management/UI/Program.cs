using Person_Management.ApplicationLogic.Validations;
using Person_Management.Database.Repository;
using System;

namespace Person_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Our available commands :");
            Console.WriteLine("/add-new-person");
            Console.WriteLine("/remove-person-by-id");
            Console.WriteLine("/show-persons");
            Console.WriteLine("/exit");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter command : ");
                string command = Console.ReadLine();

                if (command == "/add-new-person")
                {
                    Console.Write("Please add person's name :");
                    string name = Console.ReadLine();

                    Console.Write("Please add person's surname :");
                    string lastName = Console.ReadLine();

                    Console.Write("Please add person's fathername code :");
                    string fathername = Console.ReadLine();

                    Console.Write("Please add person's FIN code :");
                    string fin = Console.ReadLine();

                    Console.Write("Please add person's email code :");
                    string email = Console.ReadLine();

                    if (UserValidations.IsValidations(email,fin))
                    {
                    Person person = UserRepository.Add(name, lastName, fathername, fin, email);
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }

                }
                else if (command == "/remove-person-by-id")
                {
                    Console.Write("To remove person, please enter his/her ID code : ");
                    uint id = Convert.ToUInt32(Console.ReadLine());
                    UserRepository.Remove(command);
                }
                else if (command == "/show-persons")
                {
                    Console.WriteLine("Persons in database : ");
                    Person.GetInfo();
                }
                else if (command == "/exit")
                {
                    Console.WriteLine("Thanks for using our application!");
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found, please enter command from list!");
                    Console.WriteLine();
                }
            }

        }
    }
}

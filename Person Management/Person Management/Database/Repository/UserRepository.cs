using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Management.Database.Repository
{
    class UserRepository
    {
        private static List<Person> Persons { get; set; } = new List<Person>();

        public static Person AddNewPerson(string name, string lastname, string fathername, string fin, string email)
        {
            Person person = new Person(name, lastname, fathername, fin, email);
            Persons.Add(person);
            return person;
        }

        public void RemovePerson(string fin)
        {
            for (int i = 0; i < Persons.Count; i++)
            {
                if (Persons[i].Fin == fin)
                {
                    Persons.Remove(Persons[i]);
                }
            }
        }
        public void UpdatePerson(int id, string name, string lastname, string fathername, string fin, string email)
        {
            for (int i = 0; i < Persons.Count; i++)
            {
                if (Persons[i].Id == id)
                {
                    Persons[i].Name = name;
                    Persons[i].LastName = lastname;
                    Persons[i].FatherName = fathername;
                    Persons[i].Fin = fin;
                    Persons[i].Email = email;

                }
            }
        }
    }
}

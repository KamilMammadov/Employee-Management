using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Management.Database.Repository
{
    class Person
    {
        private static int _idCounter;
        public int Id { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public int Fin { get; set; }
        public string Email { get; set; }  

        public Person(string name, string lastName, string fatherName, int fin, string email)
        {
            Id = _idCounter;
            Name = name;
            LastName = lastName;
            FatherName = fatherName;
            Fin = fin;
            Email = email;

            _idCounter++;
        }
    }
}

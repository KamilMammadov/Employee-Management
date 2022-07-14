using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Management.Database.Models
{
    class Address
    {
        private static int _idCounter=1;
        public int Id { get;}

        public string Name { get; set; }

        public Address(string name)
        {
            Id = _idCounter;
            Name = name;
            _idCounter++;
        }
    }
}

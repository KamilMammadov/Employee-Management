using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Management.Database.Models
{
    class Address
    {
        private static int _idCounter;
        public int Id { get; set; }

        public string AdressName { get; set; }

        public Address(string name)
        {
            Id = _idCounter;
            AdressName = name;
            _idCounter++;
        }
    }
}

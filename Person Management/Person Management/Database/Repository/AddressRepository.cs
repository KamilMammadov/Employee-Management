using Person_Management.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Management.Database.Repository
{

    class AddressRepository
    {
        private static List<Address> adresses { get; set; } = new List<Address>();


        public static Address AddNewAddress(string name)
        {
            Address address = new Address(name);
            adresses.Add(address);
            return address;
        }

        public void Remove(int id)
        {
            for (int i = 0; i < adresses.Count; i++)
            {
                if (adresses[i].Id==id)
                {
                    adresses.Remove(adresses[i]);
                }
            }
        }

        public void Update(int id,string name)
        { 
            for (int i = 0; i < adresses.Count; i++)
            {
                if (adresses[i].Id==id)
                {
                    adresses[i].Name = name;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftShoes.Entities
{
    public class Address
    {
        private int id;
        private string city;
        private string country;
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address(int id, string city,string country) 
        {
            id = Id;
            city = City;
            country = Country;
        }
    }
}

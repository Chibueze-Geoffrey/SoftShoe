using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftShoes.Entities
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string email;
        private int phone;
        public int CustomerId { get;set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Phone { get; set; }
        public Address address { get; set; }
        public Customer(int id, string firstName,string lastName, string email, int phone,Address address )
        {
            id = CustomerId;
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            phone = Phone;


        }



    }
}

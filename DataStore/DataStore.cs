using SoftShoes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class DataStore
    {
        public static List<Customer> customers { get; set; } = new List<Customer>();
      //  public List<Order> order { get; set; } = new List<Order>();
      public DataStore(Customer customer) {  }
    }


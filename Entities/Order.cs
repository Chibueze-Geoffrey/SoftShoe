using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftShoes.Entities
{
    internal class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateOnly DateTimeOnly { get; set; }

        public Order(int orderId, Customer customer)
        {
            OrderId = orderId;
        }

    }
}

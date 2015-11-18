using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedecorationService.Data
{
    public class Customer : Base<Customer>
    {
        public string FirstName;
        public string LastName;
        public List<Order> Orders
        {
            get
            {
                return Order.Items
                    .Where(order => order.Customer == this)
                    .ToList();
            }
        }

        public Customer() { }
    }
}

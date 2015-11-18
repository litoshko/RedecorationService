using System;
using System.Collections.Generic;
using System.Linq;

namespace RedecorationService.Data
{
    public class Order : Base<Order>
    {
        public string Address;
        public string ContractCode;
        public decimal Price;
        public DateTime DateCreated;
        private Guid _customerId;
        public Customer Customer
        {
            get
            {
                return Customer.Items
                    .Where(item => item.Id == _customerId)
                    .First();
            }
            set
            {
                _customerId = value.Id;
            }
        }

        public List<Team> Teams
        {
            get
            {
                return TeamsForOrder.Items
                    .Where(tfo => tfo.Order == this)
                    .Select(tfo => tfo.Team)
                    .ToList();
            }
        }

        public Order()
        {
        }
    }
}

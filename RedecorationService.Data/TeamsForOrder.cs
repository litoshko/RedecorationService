using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedecorationService.Data
{
    public class TeamsForOrder : Base<TeamsForOrder>
    {
        private Guid _teamId;
        private Guid _orderId;

        public Team Team
        {
            get
            {
                return Team.Items
                    .Where(team => team.Id == _teamId)
                    .First();
            }
            set
            {
                _teamId = value.Id;
            }
        }

        public Order Order
        {
            get
            {
                return Order.Items
                    .Where(order => order.Id == _orderId)
                    .First();
            }
            set
            {
                _orderId = value.Id;
            }
        }
    }
}

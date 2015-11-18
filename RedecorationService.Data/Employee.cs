using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedecorationService.Data
{
    public class Employee : Base<Employee>
    {
        public string FirstName;
        public string LastName;
        private Guid _teamId;
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

    }
}

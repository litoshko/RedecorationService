using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedecorationService.Data
{
    public class Team : Base<Team>
    {
        public string Name;

        public List<Employee> Employees
        {
            get
            {
                return Employee.Items
                    .Where(emp => emp.Team == this)
                    .ToList();
            }
        }

        public List<Order> Orders
        {
            get
            {
                return TeamsForOrder.Items
                    .Where(tfo => tfo.Team == this)
                    .Select(tfo => tfo.Order)
                    .ToList();
            }
        }
    }
}

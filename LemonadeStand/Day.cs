using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public List<Customer> customers;

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
            customers.Add(new Customer());
            customers.Add(new Customer());
            customers.Add(new Customer());
        }
    }
}

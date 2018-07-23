using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = Id;

        }
        public Customer(int id, string name)
            : this(id) //delegate the control to call the constractor
        {
            this.Name = name;
            
        }
        public class Order
        {

        }

        static void Main(string[] args)
        {
        }
    }
}

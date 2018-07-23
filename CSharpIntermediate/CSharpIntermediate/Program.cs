using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
  
{
    
    class Program
    {
        static void Main(string[] args)
        {
         
            var customer = new Customer();
            customer.Id = 223900;
            customer.Name = "Atieno";

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.ReadLine();
            

            
        }
    }
}

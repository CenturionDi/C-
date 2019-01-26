using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlineshop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ContextShop())
            {
                var customers = context.Customers.ToList();
                context.Customers.Add(new Customer
                {
                    Id = 1,
                    Name = "Ron",
                    Surname = "Black",
                    Phone = "32423534"

                });
                context.SaveChanges();
            }
        }
    }
}

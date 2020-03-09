using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestSelect : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();

            var firstQueryCustomers = from customer in customers
                                          //select customer.Name;
                                      select new { customer.Id, customer.Name };

            //foreach (var customer in firstQueryCustomers)
            //{
            //    Console.WriteLine(customer);
            //}

            var secondQueryCustomers = customers
                                        //.Select(customer => new { customer.Id, customer.Name })
                                        //.Select(customer => customer.Name);
                                        .Select(customer => new {Description = "Customer Name: " + customer.Name + "Age: " + customer.Age });

            foreach (var customer in secondQueryCustomers)
            {
                Console.WriteLine(customer.Description);
            }
        }
    }
}

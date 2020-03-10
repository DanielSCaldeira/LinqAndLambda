using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestAny : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();
            var orders = DataBase.DataBase.GetOrders();

            var bigOrders = orders.Any(order => order.TotalValue > 5000);

            if (bigOrders)
            {
                Console.WriteLine("Existem valores maaiores que 5000");
            }
            else
            {
                Console.WriteLine("Existem valores maaiores que 5000");
            }

            var oldCustomerOrders = orders.Where(order => customers.Any(customer => customer.Id == order.CustumerId && customer.Age > 50));
            foreach (var order in oldCustomerOrders)
            {
                Console.WriteLine("Customer Id: " + order.CustumerId + " - Purchaser: " + order.TotalValue.ToString("c2"));
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestWhere : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();
            var orders = DataBase.DataBase.GetOrders();
            //Filtro
            var ageCustomers = customers.Where(customer => customer.Age > 40 && customer.Age < 51);

            foreach (var customer in ageCustomers)
            {
                Console.WriteLine(customer.Name + " Age: " + customer.Age);
            }

            var firtCustomerOrders = orders.Where(order => ValidateOrders(order));

            foreach (var order in firtCustomerOrders)
            {
                Console.WriteLine(order.CustumerId + " Purchased: " + order.TotalValue.ToString("C2"));
            }
        }

        private static bool ValidateOrders(Model.Order order)
        {
            return (order.CustumerId == 1 && order.TotalValue > 1000 && order.TotalValue < 3000 || (order.CustumerId == 2));
        }
    }
}

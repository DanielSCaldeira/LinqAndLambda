using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestCountMaxMin : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();
            var orders = DataBase.DataBase.GetOrders();

            var orderCount = orders.Count();
            Console.WriteLine("Orders count: " + orderCount);


            var orderMax = orders.Max(order=> order.TotalValue);
            Console.WriteLine("Orders max: " + orderMax);

            var orderMin = orders.Min(order => order.TotalValue);
            Console.WriteLine("Orders count: " + orderMin);

            var firstCustomerOrders = orders.Where(order => order.CustumerId == 0);
            Console.WriteLine("Orders count: " + firstCustomerOrders.Count());
            Console.WriteLine("Orders Max: " + firstCustomerOrders.Max(order => order.TotalValue));
            Console.WriteLine("Orders MIn: " + firstCustomerOrders.Min(order => order.TotalValue));


        }
    }
}

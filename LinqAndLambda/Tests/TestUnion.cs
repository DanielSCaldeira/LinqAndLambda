using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestUnion : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();
            var orders = DataBase.DataBase.GetOrders();

            var firstCustomers = customers.FirstOrDefault();
            var lastCustomers = customers.LastOrDefault();

            var firstCustomerOrders = orders.Where(order => order.CustumerId == firstCustomers.Id);
            var lastfirstCustomerOrders = orders.Where(order => order.CustumerId == lastCustomers.Id);

            var firstAndLast = firstCustomerOrders.Union(lastfirstCustomerOrders);
        }
    }
}

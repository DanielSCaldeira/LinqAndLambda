using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestGroupBy : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            var totalOrders = orders.GroupBy(order => order.CustumerId)
                .Select(order => new
                {
                    CustomerId = order.Key,
                    TotalValue = order.Sum(x => x.TotalValue),
                    AverageValue = order.Average(x => x.TotalValue),
                    CountValue = order.Count(),
                });

            foreach (var totalOrder in totalOrders)
            {
                Console.WriteLine("Customer: " + totalOrder.CustomerId + " - TotalValue: " + totalOrder.TotalValue.ToString("c2") +
                    "Average Value: " + totalOrder.AverageValue.ToString("c2") + "Count orders: " + totalOrder.CountValue
                    );
            }
        }
    }
}

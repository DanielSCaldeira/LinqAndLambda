using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestSumAverage : ITest
    {
        public void Test()
        {
            var orders = DataBase.DataBase.GetOrders();

            var somaTotalValue = orders.Sum(order => order.TotalValue);
            var averageTotalValue = orders.Average(order => order.TotalValue);

            Console.WriteLine("Orders suma: " + somaTotalValue.ToString("c2"));
            Console.WriteLine("Orders média: " + averageTotalValue.ToString("c2"));

        }
    }
}

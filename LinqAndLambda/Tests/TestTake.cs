using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    public class TestTake : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();

            // pega os 10 primeiros registros da lista
            var firtTenCustomers = customers.Take(10);

            foreach (var customer in firtTenCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            //Percorre a lista até que encontre uma condição que sejá verdadeira
            var takeWhileCustomers = customers.TakeWhile(customer => customer.Age != 40);

            foreach (var customer in takeWhileCustomers)
            {
                Console.WriteLine("TakeWhile: " + customer.Name + " Age: " + customer.Age);
            }
        }
    }
}

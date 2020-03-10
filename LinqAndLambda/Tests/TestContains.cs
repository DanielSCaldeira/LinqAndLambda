using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestContains : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();

            var customerIds = customers.Select(customer => customer.Id);

            if (customerIds.Contains(1))
            {
                Console.WriteLine("Existe um id = 1");
            }
            else
            {
                Console.WriteLine("Não existe");
            }

        }
    }
}

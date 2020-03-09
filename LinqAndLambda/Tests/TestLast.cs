using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    public class TestLast: ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();

            //retorna uma exceção caso não exista nenhum registro
            var lastCustomer = customers.Last();
            Console.WriteLine(lastCustomer);

            try
            {
                //retorna uma exceção caso não exista nenhum registro
                var errorCustomer = customers.Last(customer => customer.Id < 0);
            }
            catch { }

            var customerLastOrDefault = customers.LastOrDefault(customer => customer.Id < 0);

            if(customerLastOrDefault == null)
            {
                Console.WriteLine("Não foi encontrado nenhum registro");
            }

            var customerWithAge = customers.LastOrDefault(customer => customer.Id < 40);
            Console.WriteLine(customerWithAge.Name);

        }
    }
}

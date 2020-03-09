using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestSkip : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();

            //Pula os 10 primeiros e pega o restante da lista
            var skipCustomers = customers.Skip(10);

            foreach (var customer in skipCustomers)
            {
                Console.WriteLine(customer.Name);
            }

            //Pula todos os registros que são diferentes de 40  
            //var skipWhileCustomers = customers.SkipWhile(customer => customer.Age != 40);

            //Cuidado com a condição caso o primeiro registro não for verdadeira ele ira mostra toda a lista
            var skipWhileCustomers = customers.SkipWhile(customer => customer.Age == 40);

            foreach (var customer in skipWhileCustomers)
            {
                Console.WriteLine("SkipWhile: " + customer.Name + " Age: " + customer.Age);
            }


        }
    }
}

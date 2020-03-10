using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestAll : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();

            var verificaTodaALista = customers.All(customer => customer.Id >= 0);

            if (verificaTodaALista)
            {
                Console.WriteLine("A lista obtem todos os itens com o id maior ou igual a 0");
            }
            else
            {
                Console.WriteLine("A lista não obtem todos itens com o id maior ou igual a 0");
            }
        }
    }
}

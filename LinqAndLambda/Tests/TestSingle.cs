using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    public class TestSingle : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();

            //var customersWithAge = customers.Single(customer => customer.Age == 10);
            var customersWithAge = customers.SingleOrDefault(customer => customer.Age == 10);

            if (customersWithAge != null)
            {
                Console.WriteLine(customersWithAge.Id +" - "+ customersWithAge.Name+ "Age" +customersWithAge.Age);
            }
            else
            {
                Console.WriteLine("Não existe customers com essa condição");
            }

            //Diferença de performace
            // first não pecorre a lista inteira 
            //var customersWithFirst = customers.First(customer => customer.SecondAge == 19);

            // Single pecorre a lista inteira 
            //var customersWithSingle = customers.Single(customer => customer.SecondAge == 19);
            
            // Retorna apenas o primeiro registro encontrado
            var customersWithFirst = customers.First(customer => customer.Age == 19);

            //Single se a condição retorna mais de uma condição retorna uma exceção
            var customersWithSingle = customers.Single(customer => customer.Age == 19);

            //SingleOrDefault se a condição retorna mais de uma condição retorna uma exceção é obrigatorio retona somente um registro           
            var customersWithSingleOrDefault = customers.SingleOrDefault(customer => customer.Age == 19);
           
            Console.WriteLine(customersWithSingleOrDefault);
        }
    }
}

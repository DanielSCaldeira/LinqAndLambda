using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    public class TestFirst : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();

            //var firstCustomer = customers.First();
            //Console.WriteLine(firstCustomer.Name);

            //var firstCustomerAge = customers.First(customer => customer.Age > 30);
            //Console.WriteLine(firstCustomerAge.Name);

            //try
            //{
            //    var customerWithAgeLessTen = customers.First(customer => customer.Age < 10);
            //    Console.WriteLine(customerWithAgeLessTen.Name);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Não foi encontrado nenhum registro detalhes: ", ex.ToString()); ;
            //}


            //var customerWithAgeLessTenFirstOrDefault = customers.FirstOrDefault(customer => customer.Age > 30);
            //Console.WriteLine("Usando o FirstOrDefault: "+ customerWithAgeLessTenFirstOrDefault.Name);

            //var customerWithAgeLessTenUsingFirstOrDefault = customers.FirstOrDefault(customer => customer.Age < 10);
            //if(customerWithAgeLessTenUsingFirstOrDefault != null)
            //{
            //    Console.WriteLine("Testando o FirstOrDefault: " + customerWithAgeLessTenUsingFirstOrDefault.Name);
            //}

            //retorna o valor default de age que é 0 por ser um int
            var ages = customers.Select(customer => customer.Age).FirstOrDefault(age => age < 10);
            Console.WriteLine(ages);
        }
    }
}

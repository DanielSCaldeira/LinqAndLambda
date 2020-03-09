using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestOrderBy : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();
            var orders = DataBase.DataBase.GetOrders();


            var customerOrders = customers.Join(
                orders,
                customer => customer.Id,
                order => order.CustumerId,
                 (customer, order) => new
                 {
                     CustomerId = customer.Id,
                     Name = customer.Name,
                     Age = customer.Age,
                     TotalValue = order.TotalValue,
                     CreatedDate = order.CreatedDate
                 }
                );

            //Asc
            //foreach (var customerOrder in customerOrders.OrderBy(order => order.TotalValue))
            //{
            //    Console.WriteLine(customerOrder.Name + " - Purchased: " + customerOrder.TotalValue.ToString("c2"));
            //}       
            
            //Desc
            foreach (var customerOrder in customerOrders.OrderByDescending(order => order.TotalValue))
            {
                Console.WriteLine(customerOrder.Name + " - Purchased: " + customerOrder.TotalValue.ToString("c2"));
            } 
            
            //Ordernar por mais de um campo pelo nome e pelo preço em ordem crescente
            foreach (var customerOrder in customerOrders.OrderByDescending(order => order.Name).ThenBy(order => order.TotalValue))
            {
                Console.WriteLine(customerOrder.Name + " - Purchased: " + customerOrder.TotalValue.ToString("c2"));
            }       
            
            //Ordernar por mais de um campo pelo nome e pelo preço em ordem decrescente
            foreach (var customerOrder in customerOrders.OrderByDescending(order => order.Name).ThenBy(order => order.TotalValue))
            {
                Console.WriteLine(customerOrder.Name + " - Purchased: " + customerOrder.TotalValue.ToString("c2"));
            }

        }
    }
}

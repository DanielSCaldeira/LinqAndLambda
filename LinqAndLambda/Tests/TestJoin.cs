using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestJoin : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();
            var orders = DataBase.DataBase.GetOrders();
            // Join vai duplicar a linha de customer para cada order
            //var customerOrders = customers.Join(
            //    orders,
            //    customer => customer.Id,
            //    order => order.CustumerId,
            //     ( customer, order ) => new { Customer = customer, Order = order }
            //    );

            //foreach (var customerOrder in customerOrders)
            //{
            //    Console.WriteLine("Custumer: " + customerOrder.Customer.Name + "purchased: "+customerOrder.Order.TotalValue.ToString("c2")
            //        + " in " + customerOrder.Order.CreatedDate.ToString("dd/MM/yyyy") 
            //        );
            //}   

            //GroupJoin vai trazer o objeto organizado ou seja dentro de cada customer vai ter uma lista de order
            var customerOrders = customers.GroupJoin(
                orders,
                customer => customer.Id,
                order => order.CustumerId,
                 (customer, allOrder) => new { Customer = customer, AllOrder = allOrder }
                );

            foreach (var customerOrder in customerOrders)
            {
                Console.WriteLine("The customer " + customerOrder.Customer.Name + "purchased: ");

                foreach (var order in customerOrder.AllOrder)
                {
                    Console.WriteLine("Total value: "+ order.TotalValue.ToString("c2") + " in "+ order.CreatedDate.ToString("dd/MM/yyyy"));
                }
            }

        }
    }
}

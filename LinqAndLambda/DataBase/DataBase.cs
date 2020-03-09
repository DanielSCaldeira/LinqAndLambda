using LinqAndLambda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.DataBase
{
    public class DataBase
    {
        public static List<Custumer> GetCustumers()
        {
            var customers = new List<Custumer>();

            for (int index = 0; index <= 50; index++)
            {
                var customer = new Custumer();
                customer.Id = index;
                customer.Name = $"Customer{index}";
                customer.Age = 19 + index;

                customers.Add(customer);
            }
            return customers;
        }

        public static List<Order> GetOrders()
        {
            var orders = new List<Order>();
            var customerId = 0;

            for (int index = 0; index <= 1000; index++)
            {
                var order = new Order();
                order.Id = index;
                if (customerId > 50)
                {
                    customerId = 0;
                }

                order.CustumerId = customerId;
                order.CreatedDate = DateTime.Now;
                order.TotalValue = 10 * index;

                orders.Add(order);
                customerId++;
            }
            return orders;
        }
    }
}

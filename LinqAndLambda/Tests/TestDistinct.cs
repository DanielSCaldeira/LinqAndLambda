﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda.Tests
{
    class TestDistinct : ITest
    {
        public void Test()
        {
            var customers = DataBase.DataBase.GetCustumers();
            var orders = DataBase.DataBase.GetOrders();
        }
    }
}

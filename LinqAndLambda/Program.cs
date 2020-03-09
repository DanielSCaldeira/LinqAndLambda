using LinqAndLambda.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest test = new TestOrderBy();
            test.Test();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfLearning.Introductory.Client_ServiceReference
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceProxy servieClient1 = new CalculatorServiceProxy("CalculatorService1");

            int addResult = servieClient1.Add(1, 2);

            CalculatorServiceProxy serviceClient2 = new CalculatorServiceProxy("CalculatorService2");

            int subtractResult = serviceClient2.Subtract(1, 2);

            Console.ReadLine();
        }
    }
}

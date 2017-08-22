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
            CalculatorServiceFacade servieClient1 = new CalculatorServiceFacade("WSHttpBinding_ICalculator");

            int addResult = servieClient1.Add(1, 2);

            CalculatorServiceFacade serviceClient2 = new CalculatorServiceFacade("WSHttpBinding_ICalculator1");

            int subtractResult = serviceClient2.Subtract(1, 2);

            Console.ReadLine();
        }
    }
}

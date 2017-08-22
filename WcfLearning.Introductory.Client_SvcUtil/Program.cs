using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfLearning.Introductory.Client_SvcUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceClient servieClient1 = new CalculatorServiceClient("WSHttpBinding_ICalculator");

            int addResult = servieClient1.Add(1, 2);

            CalculatorServiceClient serviceClient2 = new CalculatorServiceClient("WSHttpBinding_ICalculator1");

            int subtractResult = serviceClient2.Subtract(1, 2);

            Console.ReadLine();
        }
    }
}

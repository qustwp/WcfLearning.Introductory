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
            CalculatorServiceProxy servieProxy1 = new CalculatorServiceProxy("WSHttpBinding_ICalculator");

            int addResult = servieProxy1.Add(1, 2);

            CalculatorServiceProxy serviceProxy2 = new CalculatorServiceProxy("WSHttpBinding_ICalculator1");

            int subtractResult = serviceProxy2.Subtract(1, 2);

            Console.ReadLine();
        }
    }
}

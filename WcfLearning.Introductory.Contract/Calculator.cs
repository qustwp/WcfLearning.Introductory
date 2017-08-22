using System;

namespace WcfLearning.Introductory.Contract
{
    public class Calculator:ICalculator
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Do add, {0} + {1}", a, b);

            return a + b;
        }

        public int Subtract(int a, int b)
        {
            Console.WriteLine("Do subtract, {0} - {1}", a, b);

            return a - b;
        }
    }
}

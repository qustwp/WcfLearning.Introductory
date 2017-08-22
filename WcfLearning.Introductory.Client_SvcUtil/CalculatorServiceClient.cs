using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfLearning.Introductory.Client_SvcUtil
{
    public class CalculatorServiceClient
    {
        private CalculatorClient _proxy;

        public CalculatorServiceClient(string endpoint)
        {
            _proxy = new CalculatorClient(endpoint);
        }

        public int Add(int a, int b)
        {
            return _proxy.Add(a, b);
        }

        public int Subtract(int a, int b)
        {
            return _proxy.Subtract(a, b);
        }
    }
}

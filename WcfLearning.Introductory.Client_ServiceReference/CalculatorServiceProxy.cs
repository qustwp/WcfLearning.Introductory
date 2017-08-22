using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfLearning.Introductory.Contract;

namespace WcfLearning.Introductory.Client_ServiceReference
{
    public class CalculatorServiceProxy:ICalculator
    {
        private CalculatorServiceClient.CalculatorClient _client;

        public CalculatorServiceProxy(string endpoint)
        {
            _client = new CalculatorServiceClient.CalculatorClient(endpoint);
        }

        public int Add(int a, int b)
        {
            return _client.Add(a, b);
        }

        public int Subtract(int a, int b)
        {
            return _client.Subtract(a, b);
        }
    }
}

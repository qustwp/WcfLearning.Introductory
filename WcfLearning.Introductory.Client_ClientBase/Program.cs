using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using WcfLearning.Introductory.Contract;

namespace WcfLearning.Introductory.Client_ClientBase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CalculatorServiceProxy proxy = new CalculatorServiceProxy(new WSHttpBinding(), "http://localhost:8000/Introductory/CalculatorService1"))
            {
                int addResult = proxy.Add(1, 2);
            }

            using (CalculatorServiceClient client = new CalculatorServiceClient(new WSHttpBinding(), "http://localhost:8000/Introductory/CalculatorService2"))
            {
                int subtract = client.Channel.Subtract(1, 2);
            }

            Console.ReadLine();
        }
    }

    public class CalculatorServiceProxy : ClientBase<ICalculator>, ICalculator
    {
        public CalculatorServiceProxy(Binding binding, string endPointAddress)
            : base(binding, new EndpointAddress(endPointAddress))
        {
        }

        public int Add(int a, int b)
        {
            return base.Channel.Add(a, b);
        }

        public int Subtract(int a, int b)
        {
            return base.Channel.Subtract(a, b);
        }
    }

    public class CalculatorServiceClient : ClientBase<ICalculator>
    {
        // base.Channel 是 Protected.
        public ICalculator Channel { get { return base.Channel; } }

        public CalculatorServiceClient(Binding binding, string endPointAddress)
            : base(binding, new EndpointAddress(endPointAddress))
        {
        }
    }
}

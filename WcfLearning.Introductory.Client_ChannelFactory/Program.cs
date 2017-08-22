using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfLearning.Introductory.Contract;

namespace WcfLearning.Introductory.Client_ChannelFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<ICalculator> channelFactory1 = new ChannelFactory<ICalculator>(new WSHttpBinding(), "http://localhost:8000/Introductory/CalculatorService1"))
            {
                ICalculator proxy = channelFactory1.CreateChannel();
                int addResult = proxy.Add(1, 2);
            }

            using (ChannelFactory<ICalculator> channelFactory2 = new ChannelFactory<ICalculator>(new WSHttpBinding(), "http://localhost:8000/Introductory/CalculatorService2"))
            {
                ICalculator proxy = channelFactory2.CreateChannel();
                int subtractResult = proxy.Subtract(1, 2);
            }

            Console.ReadLine();
        }
    }
}

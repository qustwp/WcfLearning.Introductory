using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfLearning.Introductory.Contract;

namespace WcfLearning.Introductory.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:8000/Introductory/");

            ServiceHost host = new ServiceHost(typeof(Calculator), uri);

            try
            {
                host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService1");
                host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService2");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press any key to terminate service.");
                Console.ReadLine();

                host.Close();
            }
            catch (CommunicationException exp)
            {
                Console.WriteLine("An exception occurred: {0}", exp.Message);

                host.Abort();
            }
        }
    }
}

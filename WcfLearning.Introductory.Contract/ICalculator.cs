using System.ServiceModel;

namespace WcfLearning.Introductory.Contract
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Subtract(int a, int b);
    }
}

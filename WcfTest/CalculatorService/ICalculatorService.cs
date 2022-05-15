using CalculatorService.Model;
using System.ServiceModel;

namespace CalculatorService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Add(int firstValue, int secondValue);

        [OperationContract]
        int Substract(int firstValue, int secondValue);

        [OperationContract]
        int Multiply(int firstValue, int secondValue);

        [OperationContract]
        decimal DivideBy(int value, int divider);

        [OperationContract]
        CalculateItemResponse Calculate(CalculateItem item);
    }
}

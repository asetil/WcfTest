using CalculatorService.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorService
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }

        public CalculateItemResponse Calculate(CalculateItem item)
        {

            var response = new CalculateItemResponse();

            try
            {
                if (item.ValueList == null || item.ValueList.Count < 2)
                    throw new Exception("Value list is empty! At least 2 items is required.");

                if (item.Operation == "Sum")
                {
                    response.Result = item.ValueList.Sum();
                }
                else if (item.Operation == "Multiply")
                {
                    var result = 1;
                    item.ValueList.ForEach(f => { result *= f; });
                    response.Result = result;
                }
                else if (item.Operation == "Divide")
                {
                    var result = item.ValueList[0];
                    item.ValueList.Skip(1).ToList().ForEach(f => { result /= f; });
                    response.Result = result;
                }
                else if (item.Operation == "Substract")
                {
                    var result = item.ValueList[0];
                    item.ValueList.Skip(1).ToList().ForEach(f => { result -= f; });
                    response.Result = result;
                }
                else
                    throw new InvalidOperationException("Operation geçerli değil. Desteklenen değerler : Sum/Multiply/Divide/Subtsrct");

                response.Success = true;
            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public decimal DivideBy(int value, int divider)
        {
            if (divider == 0)
                throw new DivideByZeroException();

            return value / divider;
        }

        public int Multiply(int firstValue, int secondValue)
        {
            return firstValue * secondValue;
        }

        public int Substract(int firstValue, int secondValue)
        {
            return firstValue - secondValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WcfTestClient.Calculator;

namespace WcfTestClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceClient client = new CalculatorServiceClient();
            var response = client.Calculate(new CalculateItem()
            {
                Operation = "Sum",
                ValueList = (new List<int>() { 4, 5, 3, 8 }).ToArray(),
            });
        }
    }
}

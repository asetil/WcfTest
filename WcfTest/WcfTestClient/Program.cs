using System;
using System.Collections.Generic;
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

            Console.WriteLine("Calculate Result:" + response.Result);

            var invalidResponse = client.Calculate(new CalculateItem()
            {
                Operation = "Namso",
                ValueList = (new List<int>() { 4, 7, 4 }).ToArray(),
            });

            Console.WriteLine("--------------");
            Console.WriteLine("Invalid Calculate Result:" + invalidResponse.Message);


            var multiplied = client.Multiply(6, 9);

            Console.WriteLine("--------------");
            Console.WriteLine("Multiplied Result:" + multiplied + ", Expected:54");

            Console.ReadLine();
        }
    }
}

using ClassLibrary1Core;
using ClassLibrary1CoreService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            string[] ary = new string[] { "", "" };

            for (int ctr = 0; ctr <= 1; ctr++)
                ary[ctr] = string.Format("{0,2:N0}", rand.NextDouble() * 10).Trim();

            //var sum = Class1.AddNumbers("2", "2");
            var input1 = ary[0];
            var input2 = ary[1];

            //var sum = ClassLibrary1Core.Class1.AddNumbers(input1, input2);

            var sum = ArithmeticAPIClient.AddNumbersAsync(input1, input2).GetAwaiter().GetResult();

            Console.WriteLine($"{input1}+{input2}={sum}");

            Console.ReadKey();
        }
    }
}

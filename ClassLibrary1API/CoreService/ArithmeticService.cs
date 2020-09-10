using ClassLibrary1Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1API.CoreService
{
    public class ArithmeticService
    {
        public static int AddNumbers(string input1, string input2)
        {
            var sum = Class1.AddNumbers(input1, input2);

            return sum;
        }
    }
}

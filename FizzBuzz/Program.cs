using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                var output = "";
                if (i % 3 == 0) // Multiple of 3: Add Fizz
                {
                    output += "Fizz";
                }

                if (i % 5 == 0) // Multiple of 5: Add Buzz
                {
                    output += "Buzz";
                }

                if (i % 7 == 0) // Multiple of 7: Add Bang
                {
                    output += "Bang";
                }

                if (output == "")
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }
        }
    }
}

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

                if (i % 11 == 0) // If number is multiple of 11 we do not print Fizz, Buzz or Bang
                {
                    if (i % 13 == 0)
                    {
                        output += "Fezz";
                    }

                    output += "Bong"; 
                }

                else
                {
                    if (i % 3 == 0) // Multiple of 3: Add Fizz
                    {
                        output += "Fizz";
                    }

                    if (i % 13 == 0) // Multiple of 13: add Fezz before Buzz and Bang
                    {
                        output += "Fezz";
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
                }

                Console.WriteLine(output);
            }
        }
    }
}

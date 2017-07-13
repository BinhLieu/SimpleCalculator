using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            beginCalculation();

            void beginCalculation()
            {
                StartCalculator calculate = new StartCalculator();
                calculate.getInputs();
                calculate.Calculator();
                repeatCalculator();
            }

            void repeatCalculator()
            {
                string _repeat;
                int repeat;

                Console.WriteLine("Would you like to make another calculation?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                _repeat = Console.ReadLine();

                if (Validation.IsAllDigits(_repeat) == true)
                {
                    repeat = int.Parse(_repeat);
                    if (repeat == 1)
                    {
                        beginCalculation();
                    }
                    else
                    {
                        Console.WriteLine("Goodbye");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid entry\n");
                    repeatCalculator();
                }
            }


        }
    }
}
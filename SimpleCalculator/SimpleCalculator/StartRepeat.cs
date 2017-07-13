using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class StartRepeat
    {
        public void BeginCalculation()
        {
            StartCalculator calculate = new StartCalculator();
            calculate.getInputs();
            calculate.Calculator();
            RepeatCalculator();
        }

        public void RepeatCalculator()
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
                    BeginCalculation();
                }
                else
                {
                    Console.WriteLine("Goodbye");
                }

            }
            else
            {
                Console.WriteLine("Invalid entry\n");
                RepeatCalculator();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Subtract
    {
        private double subtracted { get; set; }
        public double subtractNumbers(double x, double y)
        {
            subtracted = x - y;
            return subtracted;
        }

    }
}
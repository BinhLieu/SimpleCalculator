using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Addition
    {
        private double Sum { get; set; }
        public double addNumbers(double x, double y)
        {
            Sum = x + y;
            return Sum;
        }
    }
}

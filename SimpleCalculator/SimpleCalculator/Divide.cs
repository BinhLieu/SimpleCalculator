using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Divide
    {
        private double Divided { get; set; }
        public double divideNumbers(double x, double y)
        {
            Divided = x / y;
            return Divided;
        }
    }
}
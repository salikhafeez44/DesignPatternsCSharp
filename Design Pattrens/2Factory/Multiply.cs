using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattrens._2Factory
{
    public class Multiply : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine($"Divide {a}*{b} = {a*b}");
        }
    }
}

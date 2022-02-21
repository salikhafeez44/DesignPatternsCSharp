using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattrens._2Factory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string name)
        {
            ICalculate calculation = null;

            if (name == null) { return null; }
            else if (name.ToLower().Equals("add")) { calculation = new Add(); }
            else if (name.ToLower().Equals("subtract")) { calculation = new Substract(); }
            else if (name.ToLower().Equals("multiply")) { calculation = new Multiply(); }
            else if (name.ToLower().Equals("divide")) { calculation = new Divide(); }
            return calculation;
        }

    }
}

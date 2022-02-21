using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattrens._3Template
{
    public class Excelfile :Dataprocess
    {
        public override void ReadFile() 
        {
            Console.WriteLine("Read Excel File");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process Excel Data");
        }

    }
}

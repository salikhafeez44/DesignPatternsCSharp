using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattrens._3Template
{
    public class Textfile : Dataprocess
    {
        public override void ReadFile()
        {
            Console.WriteLine("Read Text File");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process Text Data");
        }

    }
}

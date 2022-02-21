using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattrens
{
    public class A
    {

        public string MyPropertyA { get; set; }

        public void methoodA() { Console.WriteLine(MyPropertyA); }

        public virtual void methoodAA() { Console.WriteLine(MyPropertyA); }

    }

    public class B:A
    {
        public string MyPropertyB { get; set; }

        public void methoodB() { Console.WriteLine(MyPropertyB); }

        public override void methoodAA() { Console.WriteLine("Override method A"); }
    }


    
}

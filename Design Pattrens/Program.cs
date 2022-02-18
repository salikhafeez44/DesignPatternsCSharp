using System;

namespace Design_Pattrens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.Instance;
            Singleton obj2 = Singleton.Instance;

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine();


             
        }
    }
}

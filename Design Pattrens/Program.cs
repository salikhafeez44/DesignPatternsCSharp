using System;
using Design_Pattrens._1BasicConcepts;
using Design_Pattrens._2Factory;
using Design_Pattrens._3Template;
namespace Design_Pattrens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("0.Singleton");
            Console.WriteLine();
            Singleton obj1 = Singleton.Instance;
            Singleton obj2 = Singleton.Instance;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("1.Basics");
            Console.WriteLine();
            A obj3 = new A();
            obj3.MyPropertyA = "Setting propertyA value from object A";
            obj3.methoodA();
            B obj4= new B();
            obj4.MyPropertyA = "Setting propertyA value from object B";
            obj4.methoodA();
            obj4.MyPropertyB = "Setting propertyB value from object B";
            obj4.methoodB();

            //Superclass object= new subclass();
            A obj5= new B();
            obj5.methoodAA();   


            IEmail email= new OutlookEmail();
            Employee employee1 = new Employee("Lynda", "N142", email);
            employee1.employeeSalary = 2000;
            employee1.companyId = "IMB";
            employee1.NotifyEmplaoyee();

            email = new WebserviceEmail();
            Employee employee2 = new Employee("Ron", "M198", email);
            employee2.employeeSalary = 7000;
            employee2.companyId = "IBM";
            employee2.NotifyEmplaoyee();

            employee1.PrintEmployeeInformation(employee1);
            employee2.PrintEmployeeInformation(employee2);

            Console.WriteLine();
            Console.WriteLine("2.Factory");
            Console.WriteLine();
            double num1, num2;

            Console.WriteLine("Enter the First number: ");
            bool result = Double.TryParse(Console.ReadLine(), out num1 );
            if (!result) { Console.WriteLine("Enter the First number correctlt!: "); }

            Console.WriteLine("Enter the Second number: ");
            result = Double.TryParse(Console.ReadLine(), out num2);
            if (!result) { Console.WriteLine("Enter the First number correctlt!: "); }

            Console.WriteLine("Enter the operation to perform: Add, Subtract, Divide, Multiply");
            CalculateFactory calculateFactory = new CalculateFactory();
            ICalculate obj=calculateFactory.GetCalculation(Console.ReadLine());
            obj.Calculate(num1, num2);


            Console.WriteLine();
            Console.WriteLine("3.Template");
            Console.WriteLine();
            Dataprocess textfile = new Textfile();
            textfile.GetProcessAndSave();
            Excelfile excelfile = new Excelfile();
            excelfile.GetProcessAndSave();
            
        }
    }
}

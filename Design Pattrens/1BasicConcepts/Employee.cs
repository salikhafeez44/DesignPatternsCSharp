using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattrens._1BasicConcepts
{
    internal class Employee
    {
        
        private string employeeName { get; set; }
        private string employeeId { get; set; }
        public double employeeSalary { get; set; }
        public string companyId { get; set; }
        IEmail email;

        public Employee(string employeeName, string employeeId, IEmail email)
        {
            this.employeeName = employeeName;
            this.employeeId = employeeId;
            this.email = email;
        }

        public void NotifyEmplaoyee() 
        {
            email.SendEmail();
        }

        public void PrintEmployeeInformation(Employee employee)
        {
            Console.WriteLine($"Name: {employee.employeeName}, ID {employee.employeeId}, Salary:{employee.employeeSalary}, Company:{employee.companyId}");
        }
    }
}

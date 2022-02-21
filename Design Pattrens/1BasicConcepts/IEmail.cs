using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattrens._1BasicConcepts
{
    internal interface IEmail
    {
        void SendEmail();
    }

    public class OutlookEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Sent Outlook Email!");
        }
    }

    public class WebserviceEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Sent Webservice Email!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattrens._3Template
{
    public abstract class Dataprocess
    {
        public void GetProcessAndSave()
        {
            ReadFile();
            ProcessData();
            SaveDataToDB();
        }
        public abstract void ReadFile();
        public abstract void ProcessData();

        public void SaveDataToDB()
        {
            Console.WriteLine("Save Data to DB");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsility
{
    public class EmployeeProcess
    {
        public void Process()
        {
            Console.WriteLine("******* Single Responsility Example");
            Console.BackgroundColor = ConsoleColor.Yellow;
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}

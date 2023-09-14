using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsility
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeCrud emp = new EmployeeCrud();
            emp.EmployeeList();
            EmployeeProcess emp2 = new EmployeeProcess();
            emp2.Process();
            EmployeeDef empdef = new EmployeeDef();
            empdef.PerYas = 22;
            empdef.PerAd = "Esra";
            empdef.PerSoyad = "Güler";
            emp.EmployeeAdd(empdef);

            emp.EmployeeList();


            Console.Read();
        }
    }
}

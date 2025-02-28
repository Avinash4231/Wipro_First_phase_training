using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    internal class HRInterfaceProblem
    {
        public static void run()
        {
            PEmp permanentEmployee = new PEmp();
            permanentEmployee.SetAPanDetails("ABCDE1234F");
            Console.WriteLine("Permanent Employee PAN: " + permanentEmployee.GetAPanDetails());
            permanentEmployee.LastDrawn();

            CEmp contractEmployee = new CEmp();
            contractEmployee.SetAPanDetails("XYZW5678G");
            Console.WriteLine("Contract Employee PAN: " + contractEmployee.GetAPanDetails());
            contractEmployee.LastDrawn();
        }
    }
}

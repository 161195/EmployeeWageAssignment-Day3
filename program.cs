using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Fauresia", 2, 3, 5);
            empWageBuilder.addCompanyEmpWage("Indoshottle", 5, 40, 6);


            empWageBuilder.computeEmpWage();
        }
    }
}

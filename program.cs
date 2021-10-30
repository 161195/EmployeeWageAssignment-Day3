using System;

namespace EmployeeWageAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array class object
            //calling all the necessary methods of different classes
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("indoshottle", 4, 7, 30);
            empWageBuilder.addCompanyEmpWage("Faurecia", 5, 30, 25);
            empWageBuilder.addCompanyEmpWage("Titan", 5, 20, 35);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();
        }
    }
}


using System;

namespace EmployeeWageAssignment
{
    class Program
    {
       static void Main(string[] args)
        {
            //creating an array class object
            //calling all the necessary methods of different classes
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Indoshottle", 4, 7, 30);
            empWageBuilder.addCompanyEmpWage("Faurecia", 5, 30, 25);
            empWageBuilder.addCompanyEmpWage("Titan", 5, 20, 35);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("The total wage for Indoshottle company is :" + empWageBuilder.getTotalWage("Indoshottle"));   //this line queries the total emp wage by the name of the company
        }
    }
}


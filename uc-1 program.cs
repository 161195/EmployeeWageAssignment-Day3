using System;

namespace EmployeeWageAssignment
{
    class program
    {
        static void Main(string[] args)
        {
            //constant
            int IS_PRESENT = 1;
            //creating object of random predefined class
            Random random = new Random();
            int empInput = random.Next(0, 2);

            if (IS_PRESENT == empInput)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.ReadLine();
        }
    }
}

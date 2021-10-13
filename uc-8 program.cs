using System;

namespace EmployeeWageAssignment
{
    class program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;

        public static void EmpWage(String company, int Emp_Rate_Per_Hrs, int Num_Of_Work_Days, int MaxHrsInMonth)
        {
            //variables
            int empHrs = 0, totalWorkDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkDays < NUM_OF_WORKING_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Total Employee Hours:" + totalEmpHrs + " " + "Employee Hours:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage is:" + totalEmpWage);
        }

        public static void Main(String[] args)
        {
            EmpWage("Faurecia", 2, 3, 5);
            EmpWage("IndoShottle", 5, 40, 6);
            EmpWage("TCS", 13, 10, 21);
        }
    }
}


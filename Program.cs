namespace AddPartTimeEmployeeWage
{
    internal class PartTimeFullTimeEmployee
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empHur = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 5);
            if (empCheck == IS_PART_TIME)
            {
                empHur = 4;
            }
            else if(empCheck == IS_FULL_TIME - IS_FULL_TIME)
            {
                empHur = 0;
            }
            empWage = empHur * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :" + empWage);

        }
    }
}

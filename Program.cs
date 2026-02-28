namespace LeaveManagementITP
{
    internal class Program
    {

        static void Main()
        {
            static int sickLeave = 10;
            static int vacationLeave = 15;
            static int personalLeave = 5;
            static int maternityLeave = 90;
            static int paternityLeave = 10;
            static int dayOffs = 5;

            while (true)
            {
                Console.WriteLine("\nLEAVE");
                Console.WriteLine("1. Sick Leave");
                Console.WriteLine("2. Vacation Leave");
                Console.WriteLine("3. Personal Leave");
                Console.WriteLine("4. Maternity Leave");
                Console.WriteLine("5. Paternity Leave");
                Console.WriteLine("6. Day Offs");
                Console.WriteLine("7. View Leave Balance");
                Console.WriteLine("8. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 8)
                    break;

                if (choice == 7)
                {
                    Console.WriteLine("\nLeave Balance");
                    Console.WriteLine("Sick Leave: " + sickLeave);
                    Console.WriteLine("Vacation Leave: " + vacationLeave);
                    Console.WriteLine("Personal Leave: " + personalLeave);
                    Console.WriteLine("Maternity Leave: " + maternityLeave);
                    Console.WriteLine("Paternity Leave: " + paternityLeave);
                    Console.WriteLine("Day Offs: " + dayOffs);
                    continue;

                }

                Console.WriteLine("Enter number of days to take: ");
                int days = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
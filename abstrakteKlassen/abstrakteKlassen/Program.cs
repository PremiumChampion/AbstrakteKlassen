using System;

namespace abstrakteKlassen
{
    class Program
    {
        public static void Main()
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Rick",
                LastName = "Wenz",
                AnnualSalary = 60000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine("-------------");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Alex",
                LastName = "Koppel",
                HourlyPay = 100,
                TotalHoursWorked = 40
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            Console.ReadLine();
        }
    }
}

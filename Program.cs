using System;
using System.Globalization;
using WorkerData.Entities;
using WorkerData.Entities.Enums;

namespace WorkerData // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();

            //Console.Write("Enter department's name: ");
            //d.Name = Console.ReadLine();
            w.Name = "Design";

            //Console.Write("Enter worker data:\nName: ");
            //w.Name = Console.ReadLine();
            w.Name = "Alex";

            //Console.Write("Level (Junior/MidLevel/Senior): ");
            //w.Level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            w.Level = Enum.Parse<WorkerLevel>("MidLevel");

            //Console.Write("Base salary: ");
            //w.Salary = double.Parse(Console.ReadLine());
            w.Salary = 1200.00;

            //Console.Write("How many contracts to this worker? ");
            //byte num = byte.Parse(Console.ReadLine());
            byte num = 3;

            for (int i = 0; i < num; i++)
            {
                HourContract hc = new HourContract()
                {
                    Date = DateTime.ParseExact("20/08/2018", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    ValuePerHour = 50.00,
                    Hours = 20
                };

                //HourContract hc = new HourContract().Duration(i);
                w.AddContract(hc);
            }

            //Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            Console.WriteLine(w.Listar);

        }
    }
}
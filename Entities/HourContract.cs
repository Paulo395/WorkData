using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerData.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public HourContract Duration(int cont)
        {
            Console.Write("Enter #" + cont + " contract data:\nDate (DD/MM/YYYY): ");
            Date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Value per hour: ");
            ValuePerHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Duration(Hour): ");
            Hours = Convert.ToInt32(Console.ReadLine());

            HourContract hc = new HourContract(Date,ValuePerHour,Hours);

            return hc;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return "Date: " + Date + "\n" +
                   "ValuePerHour: " + ValuePerHour + "\n" +
                   "Hours: " + Hours + "\n";
        }
    }
}

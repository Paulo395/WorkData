using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerData.Entities.Enums;

namespace WorkerData.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double salary, Department department)
        {
            Name = name;
            Level = level;
            Salary = salary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int mont)
        {
            return 0;
        }

        public override string ToString()
        {
            return "\n-------------\n" +
                   "Name: " + Name + "\n" +
                   "Level: " + Level + "\n" +
                   "Salary: " + Salary + "\n" ;
        }

        public void Listar()
        {
            foreach (HourContract contract in Contracts)
            {
                Console.WriteLine(contract);
            }
        }
    }
}

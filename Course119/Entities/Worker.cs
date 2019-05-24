using Course119.Entities.Enums;
using System.Collections.Generic;

namespace Course119.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        //garante que não vai ser nula
        public List<HourContract> Constracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Constracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Constracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Constracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}

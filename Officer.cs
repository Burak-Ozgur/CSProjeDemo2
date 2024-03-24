using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Officer : Personnel, ICalculate
    {
        public string Rank { get; set; }

        public double CalculateEmployeeSalary(int hoursWorked)
        {
            double baseSalary = HourlyWage * Math.Min(180, hoursWorked);
            double overtimePay = 0;

            if (hoursWorked > 180)
            {
                overtimePay = HourlyWage * 1.4 * (hoursWorked - 180);
            }

            return baseSalary + overtimePay;
        }

        public double CalculateManagerSalary(int hoursWorked, Manager manager)
        {
            double baseSalary = Math.Max(500, HourlyWage * hoursWorked);
            return baseSalary + manager.Bonus;
        }

        public double CalculateOfficerSalary(int hoursWorked)
        {
            double baseSalary = HourlyWage * Math.Min(180, hoursWorked);
            double overtimePay = 0;

            if (hoursWorked > 180)
            {
                overtimePay = HourlyWage * 1.5 * (hoursWorked - 180);
            }

            return baseSalary + overtimePay;
        }

    }
}

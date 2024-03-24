using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public interface ICalculate
    {
        public abstract double CalculateEmployeeSalary(int hoursWorked);
        public abstract double CalculateManagerSalary(int hoursWorked, Manager manager);
        public abstract double CalculateOfficerSalary(int hoursWorked);
    }
}

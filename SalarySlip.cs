using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSProjeDemo2
{
    public class SalarySlip
    {
        public static void GenerateSalaryReport(Officer officer, List<Personnel> personnelList)
        {
            foreach (var personnel in personnelList)
            {
                double salary = officer.CalculateEmployeeSalary(180); //salary is calculated based on 180 hours.
                string jsonOutput = JsonConvert.SerializeObject(new
                {
                    PersonnelName = personnel.Name,
                    WorkingHours = 180,
                    MainPayment = $"₺{salary:F2}",
                    ExtraWorkingHours = "", 
                    TotalPayment = $"₺{salary:F2}"
                }, Formatting.Indented);

                string fileName = $"{personnel.Name}_Salary_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.json";
                File.WriteAllText(fileName, jsonOutput);
            }
        }

        public static void PrintReport(Officer officer, List<Personnel> personnelList)
        {
            Console.WriteLine("Salary Report:");
            foreach (var personnel in personnelList)
            {
                double salary = officer.CalculateEmployeeSalary(180); //salary is calculated based on 180 hours.
                Console.WriteLine($"Personnel Name: {personnel.Name}");
                Console.WriteLine($"Working Hours: 180");
                Console.WriteLine($"Main Payment: ₺{salary:F2}");
                Console.WriteLine($"Extra Working Hours: ");
                Console.WriteLine($"Total Payment: ₺{salary:F2}\n");
            }

            Console.WriteLine("150 saatten az çalışan personellerin bilgileri:");
            foreach (var personnel in personnelList)
            {
                if (officer.CalculateEmployeeSalary(150) == 0)
                {
                    Console.WriteLine($"Personnel Name: {personnel.Name}");
                    Console.WriteLine($"Working Hours: 0");
                    Console.WriteLine($"Main Payment: ₺0");
                    Console.WriteLine($"Extra Working Hours: ");
                    Console.WriteLine($"Total Payment: ₺0\n");
                }
            }
        }
    }
}

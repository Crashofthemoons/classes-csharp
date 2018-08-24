using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime StartDate { get; set; }
        }

        public class Company
        {
            public DateTime FoundingDate { get; set; }
            public string CompanyName { get; set; }
            public List<Employee> Employees = new List<Employee>();

            public void ListEmployees() {

                foreach (Employee employee in Employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Title}");
                }
            }
        }
        static void Main(string[] args)
        {
            Company ButtsIncorporated = new Company() {
                FoundingDate = DateTime.Now,
                CompanyName = "Boots Inc"
            };

            Employee Tim = new Employee() {
                FirstName = "Tiny",
                LastName = "Tim",
                Title = "Boot Sniffer",
                StartDate = DateTime.Now,
            };

            Employee Brett = new Employee() {
                FirstName = "Little Boy",
                LastName = "Brett",
                Title = "Design Inspector",
                StartDate = DateTime.Now,
            };

            Employee Jordy = new Employee() {
                FirstName = "Jordy",
                LastName = "LaDoody",
                Title = "Boot Cleaner",
                StartDate = DateTime.Now,
            };

            ButtsIncorporated.Employees.Add(Tim);
            ButtsIncorporated.Employees.Add(Brett);
            ButtsIncorporated.Employees.Add(Jordy);

            ButtsIncorporated.ListEmployees();
        }
    }
}

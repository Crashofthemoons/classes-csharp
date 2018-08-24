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
                CompanyName = "Toots Inc"
            };

            Employee Tim = new Employee() {
                FirstName = "Tiny",
                LastName = "Tim",
                Title = "Toots Sniffer",
                StartDate = DateTime.Now,
            };

            Employee Brett = new Employee() {
                FirstName = "Little Boy",
                LastName = "Brett",
                Title = "Sphincter Inspector",
                StartDate = DateTime.Now,
            };

            Employee Jordy = new Employee() {
                FirstName = "Jordy",
                LastName = "LaDoody",
                Title = "Intestinal Cleaner",
                StartDate = DateTime.Now,
            };

            ButtsIncorporated.Employees.Add(Tim);
            ButtsIncorporated.Employees.Add(Brett);
            ButtsIncorporated.Employees.Add(Jordy);

            ButtsIncorporated.ListEmployees();
        }
    }
}

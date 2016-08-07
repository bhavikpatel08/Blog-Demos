using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7InmemoryProvider
{
class Program
{
    static void Main(string[] args)
    {
        using (var dataContext = new DataContext())
        {
            dataContext.Employee.Add(new Employee() { BirthDate = DateTime.Now, FirstName = "Bhavik", LastName = "Patel" });
            dataContext.Employee.Add(new Employee() { BirthDate = DateTime.Now, FirstName = "Sohil", LastName = "Patel" });
            dataContext.SaveChanges();

            foreach (var employee in dataContext.Employee.ToList())
            {
                Console.WriteLine($"Id= {employee.Id}, FirstName= {employee.FirstName}, LastName= {employee.LastName} and DateofBirth= {employee.BirthDate}");
            }

            Console.ReadLine();
        }
    }
}
}

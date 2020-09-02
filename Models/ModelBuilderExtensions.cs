using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 4,
                        Name = "Mark",
                        Department = Dept.IT,
                        Email = "mark@pragim.com"
                    },
                    new Employee
                    {
                        Id = 5,
                        Name = "Mary",
                        Department = Dept.HR,
                        Email = "mary@pragim.com"
                    });
        }
    }
}

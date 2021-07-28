using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyCRM.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademyCRM.DAL.EF.Contexts
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var group = new StudentGroup() {Title = "ASPNET_21_1"};
            modelBuilder.Entity<StudentGroup>().HasData(group);

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 5,
                    FirstName = "Oleg",
                    LastName = "Fedorov",
                    Group = group
                },
                new Student()
                {
                    Id = 6,
                    FirstName = "Andrey",
                    LastName = "Antonov",
                    Group = group
                }
            );
            
        }
    }
}

using AcademyCRM.BLL.Models;
using AcademyCRM.BLL.Services;
using System.Collections.Generic;

namespace AcademyCRM.BLL.Tests
{
    public class FakeStudentService : IStudentService
    {
        public IEnumerable<Student> GetAll() =>
            new List<Student>
            {
                new() {FirstName = "Ivan", LastName = "Petrov"},
                new() {FirstName = "Oleg", LastName = "Antonov"}
            };
    }
}
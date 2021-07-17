using System.Collections.Generic;
using SampleMVCWebApp.Models;

namespace SampleMVCWebApp.Services
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
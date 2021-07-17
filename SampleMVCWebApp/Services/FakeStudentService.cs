using System.Collections.Generic;
using SampleMVCWebApp.Models;

namespace SampleMVCWebApp.Services
{
    public class FakeStudentService : IStudentService
    {
        public IEnumerable<Student> GetAll()
        {
            return new List<Student>()
            {
                new Student() {FirstName = "Ivan", LastName = "Petrov"},
                new Student() {FirstName = "Oleg", LastName = "Antonov"}
            };
        }
    }
}
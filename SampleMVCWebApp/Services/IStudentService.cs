using System.Collections.Generic;
using SampleMVCWebApp.Models;

namespace SampleMVCWebApp.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
    }
}
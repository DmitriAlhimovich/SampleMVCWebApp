using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleMVCWebApp.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SampleMVCWebApp.Services;

namespace SampleMVCWebApp.Controllers
{
    public class StudentsController : Controller
    {
        private IStudentService _studentsService;

        public StudentsController(IStudentService studentService)
        {
            _studentsService = studentService;
        }

        public IActionResult Index()
        {
            var students = _studentsService.GetAll();
            return View(new StudentListModel(students));
        }
    }
}

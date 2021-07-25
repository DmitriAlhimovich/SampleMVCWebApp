using AcademyCRM.BLL.Services;
using AcademyCRM.MVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace AcademyCRM.MVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentsService;

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

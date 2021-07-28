using System.Collections.Generic;
using AcademyCRM.BLL.Services;
using AcademyCRM.MVC.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace AcademyCRM.MVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentsService;
        private readonly IMapper _mapper;

        public StudentsController(IStudentService studentService, IMapper mapper)
        {
            _studentsService = studentService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var students = _studentsService.GetAll();
            return View(_mapper.Map<IEnumerable<StudentModel>>(students));
        }
    }
}

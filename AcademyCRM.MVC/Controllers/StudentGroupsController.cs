using System.Collections.Generic;
using AcademyCRM.BLL.Services;
using AcademyCRM.MVC.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcademyCRM.MVC.Controllers
{
    public class StudentGroupsController : Controller
    {
        private readonly IStudentGroupService _groupService;
        private readonly IMapper _mapper;

        public StudentGroupsController(IStudentGroupService groupService, IMapper mapper)
        {
            _groupService = groupService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var groups = _groupService.GetAll();
            return View(_mapper.Map<IEnumerable<StudentGroupModel>>(groups));
        }
    }
}
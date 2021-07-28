﻿using System.Collections.Generic;
using AcademyCRM.BLL.Models;
using AcademyCRM.DAL;

namespace AcademyCRM.BLL.Services
{
    public class StudentGroupService : IStudentGroupService
    {
        IRepository<StudentGroup> _repository;

        public StudentGroupService(IRepository<StudentGroup> repository)
        {
            _repository = repository;
        }

        public IEnumerable<StudentGroup> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
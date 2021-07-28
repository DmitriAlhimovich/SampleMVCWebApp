﻿using System.Collections.Generic;
using AcademyCRM.BLL.Models;

namespace AcademyCRM.BLL.Services
{
    public interface IStudentGroupService
    {
        IEnumerable<StudentGroup> GetAll();
    }
}
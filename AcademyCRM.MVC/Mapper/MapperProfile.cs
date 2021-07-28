﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademyCRM.BLL.Models;
using AcademyCRM.MVC.Models;
using AutoMapper;

namespace AcademyCRM.MVC.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentModel>().ReverseMap();
        }
    }
}

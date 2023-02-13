using AutoMapper;
using MyProjectPraktikum.Common.DTOs;
using MyProjectPraktikum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectPraktikum.Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();
            //CreateMap<EGender, EGenderDTO>().ReverseMap();
            //CreateMap<EHMO, EHMODTO>().ReverseMap();
        }
    }
}

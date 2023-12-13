using AutoMapper;
using Demo.BAL.ModelDTO;
using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BAL
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TblStateDTO, TblState>().ReverseMap();
            CreateMap<TblCityDTO, TblCity>().ReverseMap();
            CreateMap<TblUserRegistrationDTO, TblUserRegistration>().ReverseMap();
        }
    }
}

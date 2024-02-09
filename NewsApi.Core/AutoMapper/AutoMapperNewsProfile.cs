using AutoMapper;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.AutoMapper
{
    public class AutoMapperNewsProfile : Profile
    {
        public AutoMapperNewsProfile()
        {
            CreateMap<NewsDto, News>().ReverseMap();
            CreateMap<NewsInsertDto, News>().ReverseMap();
            CreateMap<AuthorsDto, Authors>().ReverseMap();
            CreateMap<RolesDto, Roles>().ReverseMap();
            CreateMap<UsersDto, Users>().ReverseMap();
            CreateMap<StatisticsDto, Statistics>().ReverseMap();
        }
    }
}

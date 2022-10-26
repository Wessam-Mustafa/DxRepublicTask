using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CORE.DAL;
using CORE.DTO.Parent;

namespace BLL.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Parent, ParentInput>().ReverseMap();
            CreateMap<Parent, ParentOutput>();
        }
    }
}

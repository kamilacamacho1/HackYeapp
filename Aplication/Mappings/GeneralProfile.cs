using Aplication.Feactures.Cultivo.Commands.CreateCultivoCommand;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Commands
            CreateMap<CreateCultivoCommand, Cultivo>();
            #endregion
            #region DTOs
            //CreateMap<Cultivo, CustomerDTO>();
            #endregion
        }
    }
}

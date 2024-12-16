using AutoMapper;
using DrsDemo.Application.Queries.Countries;
using DrsDemo.Application.Queries.Teams;
using DrsDemo.Domain.Countries;
using DrsDemo.Domain.Teams;

namespace DrsDemo.Api
{
    public class DrsDemoAutoMapperProfile : Profile
    {
        public DrsDemoAutoMapperProfile()
        {
            #region Country Mapping
            CreateMap<Country, CountryDto>().ReverseMap();
            #endregion


            #region Team Mapping
            CreateMap<TeamDto, Team>().ReverseMap();
            #endregion

            #region Group Mapping
            #endregion

            #region DrawReport Mapping
            #endregion

        }
    }
}

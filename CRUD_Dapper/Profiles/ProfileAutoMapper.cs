using AutoMapper;
using CRUD_Dapper.Dto;
using CRUD_Dapper.Models;

namespace CRUD_Dapper.Profiles
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper()
        {
            CreateMap<Usuario, UsuarioListarDto>();
        }
    }
}

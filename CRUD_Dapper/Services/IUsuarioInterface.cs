using CRUD_Dapper.Dto;
using CRUD_Dapper.Models;

namespace CRUD_Dapper.Services
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<List<UsuarioListarDto>>> BuscarUsuarios();
    }
}

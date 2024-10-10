namespace CRUD_Dapper.Dto
{
    public class UsuarioListarDto
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }
        public bool Situação { get; set; } // 1 - Ativo ; 2 - Inativo
    }
}

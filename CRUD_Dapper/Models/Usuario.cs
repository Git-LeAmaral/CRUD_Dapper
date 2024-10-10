namespace CRUD_Dapper.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }
        public bool Situação { get; set; } // 1 - Ativo ; 2 - Inativo
        public string Senha { get; set; }
    }
}

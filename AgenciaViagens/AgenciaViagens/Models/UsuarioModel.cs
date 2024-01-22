using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaViagens.Models
{
    [Table("usuarios")]
    public class UsuarioModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("usuario_name")]
        public string? Name { get; set; }

        [Column ("cpf")]
        public string? Cpf { get; set; }

        [Column("email")]
        public string? Email { get; set; }
    }
}

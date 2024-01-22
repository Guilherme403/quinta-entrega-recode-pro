using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaViagens.Models
{
    [Table("destinos")]
    public class DestinoModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("destino_name")]
        public string? Name { get; set; }

        [Column("destino_preco")]
        public string? Preco { get; set; }

}
}

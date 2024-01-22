using AgenciaViagens.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaViagens.Models
{
    [Table("pedidos")]
    public class PedidoModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("pedido_pagar")]
        public PagarPedido Pagar { get; set; }

        [Column("pedido_valor")]
        public string? Valor { get; set; }

       

    }
}

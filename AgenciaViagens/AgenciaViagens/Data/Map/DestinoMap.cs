using AgenciaViagens.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgenciaViagens.Data.Map
{
    public class DestinoMap : IEntityTypeConfiguration<DestinoModel>
    {
        public void Configure(EntityTypeBuilder<DestinoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Preco).IsRequired().HasMaxLength(150);
        }
    }
}

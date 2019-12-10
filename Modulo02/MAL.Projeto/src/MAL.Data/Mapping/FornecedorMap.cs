using MAL.Data.bin.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAL.Data.Mapping
{
    public class FornecedorMap: IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");
            
            builder.Property(x => x.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.HasMany(x => x.Produtos)
                   .WithOne(x => x.Fornecedor)
                   .HasForeignKey(x => x.FornecedorID);

            builder.ToTable("Fornecedor");
        }
        
    }
}
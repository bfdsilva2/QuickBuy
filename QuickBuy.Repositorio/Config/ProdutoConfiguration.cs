using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
  public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
  {
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
      builder.HasKey(u => u.Id);

      builder.Property(u => u.Nome)
        .IsRequired()
        .HasMaxLength(50);

      builder.Property(u => u.Descricao)
        .IsRequired()
        .HasMaxLength(400);

      builder.Property(u => u.Preco)
        .IsRequired()
      .HasColumnType("00");
    }
  }
  
}

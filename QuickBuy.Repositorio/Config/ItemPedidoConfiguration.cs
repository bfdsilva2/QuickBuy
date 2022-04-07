using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
  public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
  {
    public void Configure(EntityTypeBuilder<ItemPedido> builder)
    {
      builder.HasKey(u => u.Id);

      builder.Property(u => u.ProdutoId)
        .IsRequired();

      builder.Property(u => u.Quantidade)
        .IsRequired();


    }
  }
  
}

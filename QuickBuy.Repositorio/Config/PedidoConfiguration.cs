using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
  public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
  {
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
      builder.HasKey();

      builder.Property(u => u.DataPedido)
        .IsRequired();

      builder.Property(u => u.DataPrevisaoEntrega)
        .IsRequired();

      builder.Property(u => u.CEP)
        .IsRequired()
        .HasMaxLength(10);

      builder.Property(u => u.Cidade)
        .IsRequired()
        .HasMaxLength(100);

      builder.Property(u => u.Estado)
        .IsRequired()
        .HasMaxLength(100);

      builder.Property(u => u.EnderecoCompleto)
        .IsRequired()
        .HasMaxLength(100);

    }
  }
  
}

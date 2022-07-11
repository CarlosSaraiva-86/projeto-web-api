using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Api.Domain;

namespace Web.Api.Data.Mappers
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey("Id");

            builder.Property(x => x.Id).HasColumnType("uniqueidentifier");
            builder.Property(x => x.Nome).HasColumnType("varchar(1000)");
            builder.Property(x => x.CpfCnpj).HasColumnType("varchar(100)");
            builder.Property(x => x.EnderecoId).HasColumnType("uniqueidentifier");

            builder.ToTable("Cliente");
        }
    }
}

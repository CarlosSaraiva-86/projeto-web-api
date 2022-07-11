using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Api.Domain;

namespace Web.Api.Data.Mappers
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey("Id");

            builder.Property(x => x.Logradouro).HasColumnType("varchar(1000)");
            builder.Property(x => x.Cidade).HasColumnType("varchar(100)");
            builder.Property(x => x.Cep).HasColumnType("varchar(20)");
            builder.Property(x => x.Numero).HasColumnType("int");
            builder.Property(x => x.Complemento).HasColumnType("varchar(1000)");
            builder.Property(x => x.Bairro).HasColumnType("varchar(200)");
        }
    }
}

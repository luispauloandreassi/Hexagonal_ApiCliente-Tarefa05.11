using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;

namespace Umfg.Repositorio.Mapeamento
{
    internal sealed class MapeamentoClienteo : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Documento).HasColumnName("DOCUMENTO");
            builder.Property(x => x.Nome).HasColumnName("NOME");
            builder.Property(x => x.Endereco).HasColumnName("ENDERECO");
            builder.Property(x => x.Celular).HasColumnName("CELULAR");
            builder.Property(x => x.Email).HasColumnName("EMAIL");
            builder.Property(x => x.Observacao).HasColumnName("OBSERVACAO");

            builder.Property(x => x.Documento).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Endereco).IsRequired();
            builder.Property(x => x.Celular).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Observacao).IsRequired();





        }
    }
}

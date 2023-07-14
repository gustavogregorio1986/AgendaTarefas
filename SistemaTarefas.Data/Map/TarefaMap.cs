using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SsitemaTarefas.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTarefas.Data.Map
{
    internal class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Titulo).IsRequired().HasMaxLength(80);
            builder.Property(t => t.DataInicio).IsRequired();
            builder.Property(t => t.DataFim).IsRequired();
            builder.Property(t => t.Descricao).HasMaxLength(350);
            builder.Property(t => t.Status).IsRequired();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SsitemaTarefas.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTarefas.Data.Contexto
{
    public class SistemaTarefasContexto : DbContext
    {
        public SistemaTarefasContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }

        
    }
}

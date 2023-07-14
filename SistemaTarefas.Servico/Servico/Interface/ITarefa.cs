using SsitemaTarefas.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTarefas.Servico.Servico.Interface
{
    public interface ITarefa
    {
        Task<Tarefa> Adicionar(Tarefa tarefa);


    }
}

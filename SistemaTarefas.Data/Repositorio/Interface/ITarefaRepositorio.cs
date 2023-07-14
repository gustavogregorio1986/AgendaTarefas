using SsitemaTarefas.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTarefas.Data.Repositorio.Interface
{
    public interface ITarefaRepositorio
    {
        Task<List<Tarefa>> BuscarTodasTarefas();

        Task<Tarefa> BuscarPorId(int id);


        Task<Tarefa> Adicionar(Tarefa tarefa);

        Task<Tarefa> Atualizar(Tarefa tarefa, int id);

        Task<bool> Apagar(int id);

    }
}

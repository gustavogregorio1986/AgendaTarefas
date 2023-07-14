using Microsoft.EntityFrameworkCore;
using SistemaTarefas.Data.Contexto;
using SistemaTarefas.Data.Repositorio.Interface;
using SsitemaTarefas.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTarefas.Data.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly SistemaTarefasContexto _sistemaTarefasContexto;

        public TarefaRepositorio(SistemaTarefasContexto sistemaTarefasContexto)
        {
            _sistemaTarefasContexto = sistemaTarefasContexto;
        }

        public async Task<Tarefa> Adicionar(Tarefa tarefa)
        {
           await _sistemaTarefasContexto.Tarefas.AddAsync(tarefa);
            await _sistemaTarefasContexto.SaveChangesAsync();
           return tarefa;
        }

        public async Task<bool> Apagar(int id)
        {
            _sistemaTarefasContexto.Remove(id);
            await _sistemaTarefasContexto.SaveChangesAsync();

            return true;
        }

        public async Task<Tarefa> Atualizar(Tarefa tarefa, int id)
        {
            Tarefa tarefaPorId = await BuscarPorId(id);

            tarefaPorId.Titulo = tarefa.Titulo;
            tarefaPorId.DataInicio = tarefa.DataInicio;
            tarefaPorId.DataFim = tarefa.DataFim;
            tarefaPorId.Descricao = tarefa.Descricao;

            _sistemaTarefasContexto.Tarefas.Update(tarefa);

            return tarefaPorId;
        }

        public async Task<Tarefa> BuscarPorId(int id)
        {
            return await _sistemaTarefasContexto.Tarefas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Tarefa>> BuscarTodasTarefas()
        {
            return await _sistemaTarefasContexto.Tarefas.ToListAsync();
        }
    }
}

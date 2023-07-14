using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaTarefas.Data.Repositorio;
using SsitemaTarefas.Dominio.Dominio;

namespace SistemaTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly TarefaRepositorio _tarefaRepositorio;

        public TarefaController(TarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }

        [HttpGet]
        public Task<List<Tarefa>> ListarTodasTarefas()
        {
            return _tarefaRepositorio.BuscarTodasTarefas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tarefa>> BuscarPorId(int id)
        {
            var tarefa = await _tarefaRepositorio.BuscarPorId(id);

            return Ok(tarefa);
        }

        [HttpPost]
        public async Task<ActionResult<Tarefa>> Adicionar([FromBody]Tarefa tarefa)
        {
            var tarefaModel = _tarefaRepositorio.Adicionar(tarefa);

            return Ok(tarefaModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Tarefa>> Atualizar([FromBody] Tarefa tarefa)
        {
            var tarefaModel = _tarefaRepositorio.Adicionar(tarefa);

            return Ok(tarefaModel);
        }

    }
}

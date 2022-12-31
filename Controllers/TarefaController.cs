using Microsoft.AspNetCore.Mvc;
using trilha_net_MVC_desafio_Entity.Models;
using trilha_net_MVC_desafio_Entity.Context;

namespace trilha_net_MVC_desafio_Entity.Controllers
{
    public class TarefaController : Controller
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        // Views
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Index() //Antigo ObterTodos()
        {
            // TODO: Buscar todas as tarefas no banco utilizando o EF
            // IMPLEMENTADO
            var tarefas = _context.Tarefas.ToList();
            return View(tarefas);
        }

        public IActionResult Deletar(int id)
        {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa == null) return RedirectToAction(nameof(Index));
            return View(tarefa);
        }

        public IActionResult Atualizar(int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if (tarefa == null) return RedirectToAction(nameof(Index));

            return View(tarefa);
        }

        public IActionResult BuscaDetalhada()
        {
            return View();
        }

        public IActionResult ObterPorTitulo(string titulo)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o titulo recebido por parâmetro
            // IMPLEMENTADO
            var tarefas = _context.Tarefas.Where(x => x.Titulo.Contains(titulo));
            return View(tarefas);
        }


        public IActionResult ObterPorId(int id)
        {
            // TODO: Buscar o Id no banco utilizando o EF
            // IMPLEMENTADO
            var tarefa = _context.Tarefas.Find(id);

            // TODO: Validar o tipo de retorno. Se não encontrar a tarefa, retornar NotFound
            // IMPLEMENTADO
            if (tarefa == null) return NotFound();
            // caso contrário retornar tarefa encontrada
            // IMPLEMENTADO
            return View(tarefa);
        }

        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return View(tarefa);
        }

        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o status recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            // IMPLEMENTADO
            var tarefa = _context.Tarefas.Where(x => x.Status == status);
            return View(tarefa);
        }

        // Métodos
        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            // TODO: Adicionar a tarefa recebida no EF e salvar as mudanças (save changes)
            // IMPLEMENTADO
            if (ModelState.IsValid)
            {
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPost]
        public IActionResult Atualizar(Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(tarefa.Id);

            if (tarefaBanco == null) return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            // TODO: Atualizar as informações da variável tarefaBanco com a tarefa recebida via parâmetro
            // IMPLEMENTADO
            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;
            // TODO: Atualizar a variável tarefaBanco no EF e salvar as mudanças (save changes)
            // IMPLEMENTADO
            _context.Tarefas.Update(tarefaBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Deletar(Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(tarefa.Id);

            // TODO: Remover a tarefa encontrada através do EF e salvar as mudanças (save changes)
            // IMPLEMENTADO
            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}

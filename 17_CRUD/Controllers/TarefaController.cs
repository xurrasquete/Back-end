
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _17_CRUD.Models;

namespace _17_CRUD.Controllers
{
    public class TarefaController : Controller
    {
        //Criando um objeto _tarefa que armazenará uma lista de tarefa
        private static List<Tarefa> _tarefas = new List<Tarefa>();

        public IActionResult Index()
        {
            return View(_tarefas);
        } 

        public IActionResult Adicionar()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult Adicionar(Tarefa novaTarefa)
        {
            //verificando  o total de tarefas da lista e somando mais 1 para o ID
            novaTarefa.Id = _tarefas.Count + 1;
            //Adicionando minha nova tarefa á minha lista
            _tarefas.Add(novaTarefa);
            //Redirecionar para a página com a lista de tarefas
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int Id)
        {
            Tarefa tarefaBD = _tarefas.Find(t => t.Id == Id);
            //Verificando se encontrou a terfa, se ela não é null
            if (tarefaBD == null)
                return NotFound();
            
            //Rediracioando para a lista de tarefas
            return View(tarefaBD);
        }

        [HttpPost]
        public IActionResult Editar(Tarefa tarefaEditando)
        {
            Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
            //Verificando se encontrou a terfa, se ela não é null
            if (tarefaBD == null)
            return NotFound();
            
            //Atualizando os dados da tarefa que já está na lista
            tarefaBD.Descricao = tarefaEditando.Descricao;
            tarefaBD.Concluida = tarefaEditando.Concluida;
            //Rediracioando para a lista de tarefas
            return RedirectToAction("Index");
        }

            public IActionResult Deletar(int Id)
        {
            Tarefa tarefaBD = _tarefas.Find(t => t.Id == Id);
            //Verificando se encontrou a terfa, se ela não é null
            if (tarefaBD == null)
                return NotFound();
            
            //Rediracioando para a lista de tarefas
            return View(tarefaBD);
        }

        [HttpPost]
        public IActionResult Deletar (Tarefa tarefaDeletando)
        {
            Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaDeletando.Id);
            if (tarefaDB == null)
                return NotFound();

            _tarefas.Remove(tarefaDB);

            return RedirectToAction("Index");
        }
    }
}
using CRUDMVC.Models;
using CRUDMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace CRUDMVC.Controllers
{
    public class DestinoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();
            ViewData["destinos"] = dbcontext.Destinos.Where(p => p.idDestino > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Destino destino)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(destino);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Destino destino)
        {
            var dbcontext = new Contexto();

            var destinoDelete = dbcontext.Destinos.Find(destino.idDestino);
            dbcontext.Remove(destinoDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Destino novosDadosDestino)
        {
            var dbcontext = new Contexto();

            var antigosDadosDestino = dbcontext.Destinos.Find(novosDadosDestino.idDestino);

            antigosDadosDestino.endereco = novosDadosDestino.endereco;
            antigosDadosDestino.nome = novosDadosDestino.nome;
            antigosDadosDestino.preco = novosDadosDestino.preco;
            antigosDadosDestino.qtdVagas = novosDadosDestino.qtdVagas;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
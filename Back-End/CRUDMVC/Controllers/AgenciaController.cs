using CRUDMVC.Models;
using CRUDMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace CRUDMVC.Controllers
{
    public class AgenciaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();
            ViewData["agencias"] = dbcontext.Agencias.Where(p => p.idAgencia > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Agencia agencia)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(agencia);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Agencia agencia)
        {
            var dbcontext = new Contexto();

            var agenciaDelete = dbcontext.Agencias.Find(agencia.idAgencia);
            dbcontext.Remove(agenciaDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Agencia novosDadosAgencia)
        {
            var dbcontext = new Contexto();

            var antigosDadosAgencia = dbcontext.Agencias.Find(novosDadosAgencia.idAgencia);

            antigosDadosAgencia.cnpj = novosDadosAgencia.cnpj;
            antigosDadosAgencia.endereco = novosDadosAgencia.endereco;
            antigosDadosAgencia.telefone = novosDadosAgencia.telefone;
            antigosDadosAgencia.email = novosDadosAgencia.email;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
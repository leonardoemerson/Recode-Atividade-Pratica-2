using CRUDMVC.Models;
using CRUDMVC.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace CRUDMVC.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["clientes"] = dbcontext.Clientes.Where(p => p.idCliente > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(cliente);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Cliente cliente)
        {
            var dbcontext = new Contexto();

            var clienteDelete = dbcontext.Clientes.Find(cliente.idCliente);
            dbcontext.Remove(clienteDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Cliente novosDadosCliente)
        {
            var dbcontext = new Contexto();

            var antigosDadosCliente = dbcontext.Clientes.Find(novosDadosCliente.idCliente);

            antigosDadosCliente.nome = novosDadosCliente.nome;
            antigosDadosCliente.cpf = novosDadosCliente.cpf;
            antigosDadosCliente.rg = novosDadosCliente.rg;
            antigosDadosCliente.endereco = novosDadosCliente.endereco;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
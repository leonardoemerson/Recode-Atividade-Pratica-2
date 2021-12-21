using CRUDMVC;
using System;

namespace CRUDMVC.Models
{
    public class Destino
    {
        public int idDestino { get; set; }
        public string endereco { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public int qtdVagas { get; set; }
    }
}
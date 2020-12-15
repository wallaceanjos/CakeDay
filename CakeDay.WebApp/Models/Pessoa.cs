using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeDay.WebApp.Models
{
    public class Pessoa
    {
        public Guid IdNumber { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public DateTime DataNasc { get; set; }
    }
}

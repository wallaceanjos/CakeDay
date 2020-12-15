using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CakeDay.WebApp.Models;
using CakeDay.WebApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CakeDay.WebApp.Controllers
{
    public class PessoasController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(string nome, string celular, string datanasc)
        {
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.IdNumber = Guid.NewGuid();
            novaPessoa.Nome = nome;
            novaPessoa.Celular = celular;
            novaPessoa.DataNasc = DateTime.Parse(datanasc, new CultureInfo("pt-BR"));


            PessoaRepository repository = new PessoaRepository();
            repository.Salvar(novaPessoa);

            return View();
        }

        [HttpGet]
        public ActionResult Remover(Guid idnumber)
        {
            PessoaRepository repository = new PessoaRepository();
            Pessoa pessoa = repository.BuscarPessoaPorIdNumber(idnumber);
            repository.Remover(pessoa);
            return View(pessoa);
        }

        [HttpGet]
        public ActionResult Detalhar(Guid idnumber)
        {
            PessoaRepository repository = new PessoaRepository();
            Pessoa pessoa = repository.BuscarPessoaPorIdNumber(idnumber);
            return View(pessoa);
        }

        [HttpGet]
        public ActionResult Editar(Guid idnumber)
        {
            PessoaRepository repository = new PessoaRepository();
            Pessoa pessoa = repository.BuscarPessoaPorIdNumber(idnumber);
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Editar(Guid idnumber, string nome)
        {
            PessoaRepository repository = new PessoaRepository();

            Pessoa pessoa = repository.BuscarPessoaPorIdNumber(idnumber);
            pessoa.Nome = nome;
            repository.Alterar(pessoa);

            return View(pessoa);
        }

        [HttpGet]
        public ActionResult Listar(string buscar)
        {
            PessoaRepository repository = new PessoaRepository();

            List<Pessoa> pessoas = repository.BuscarPessoas(buscar);
            return View(pessoas);
        }
    }
}

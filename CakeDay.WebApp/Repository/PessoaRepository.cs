using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeDay.WebApp.Models;

namespace CakeDay.WebApp.Repository
{
    public class PessoaRepository
    {
        private static List<Pessoa> Pessoas = new List<Pessoa>();
        public void Salvar(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public void Alterar(Pessoa pessoa)
        {
            Pessoa editarPessoa = new Pessoa();

            if(editarPessoa.IdNumber == pessoa.IdNumber)
            {
                Pessoas.Remove(pessoa);
                Salvar(editarPessoa);
            }
        }

        public void Remover(Pessoa pessoa)
        {
            Pessoas.Remove(pessoa);
        }



        public List<Pessoa> BuscarPessoas(string buscar)
        {
            if(buscar != null)
            {
                return Pessoas.Where(pessoa => pessoa.Nome.Contains(buscar, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }

            return Pessoas;
        }

        public Pessoa BuscarPessoaPorIdNumber(Guid idnumber)
        {
            return Pessoas.FirstOrDefault(pessoa => pessoa.IdNumber == idnumber);
        }
    }
}

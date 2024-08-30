using Curso_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    // Q 1.
    public class PessoaAtual
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    public class Exercicio
    {
        public void ExibirInfomacoes()
        {

            var ListPessoas = new List<PessoaAtual>
            {
                new PessoaAtual{Nome= "Rodrigo", Idade= 20 },
                new PessoaAtual{Nome= "Bianca", Idade= 20 },
                new PessoaAtual{Nome= "Isac", Idade= 30 },
                new PessoaAtual{Nome= "Renato", Idade= 50 },
                new PessoaAtual{Nome= "Renato", Idade= 30 },
                new PessoaAtual{Nome= "Aline", Idade= 20 }

            };

            var pessoaComecacomAeMaior25 = ListPessoas.Where(p => p.Nome.StartsWith("A") && p.Idade > 25);

            if (!pessoaComecacomAeMaior25.Any())
            {
                // Se a lista estiver vazia
                Console.WriteLine("Não tem pessoas com 'A' no início do nome e idade > 25");
            }
            else
            {
                // Se a lista contiver elementos
                foreach (var pessoa in pessoaComecacomAeMaior25)
                {
                    Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade}");
                }
            }

        }
    }


    // Q 2
}

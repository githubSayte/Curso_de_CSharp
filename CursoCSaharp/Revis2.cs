using Curso_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    // Q 1.
    /*
     public class PessoaAtual
     {
         public string Nome { get; set; }
         public int Idade { get; set; }
     }

     public class Exercicio1
     {
         public void ExibirInfomacoes()
         {

             var ListPessoas = new List<PessoaAtual>
             {
                 new PessoaAtual{Nome = "Rodrigo", Idade= 20 },
                 new PessoaAtual{Nome = "Bianca", Idade= 20 },
                 new PessoaAtual{Nome = "Isac", Idade= 30 },
                 new PessoaAtual{Nome = "Renato", Idade= 50 },
                 new PessoaAtual{Nome = "Renato", Idade= 30 },
                 new PessoaAtual{Nome = "Aline", Idade= 20 }

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
     public class Produto
     {
         public string Nome1 { get; set; }
         public decimal Preço { get; set; }
     }

     public class Exercicio
     {
         public void ExibirResultado()
         {
             var produtos = new List<Produto>
 {
             new Produto { Nome1 = "Produto A", Preço = 50 },
             new Produto { Nome1 = "Produto B", Preço = 150 },
             new Produto { Nome1 = "Produto C", Preço = 200 },
             new Produto { Nome1 = "Produto D", Preço = 80 }};


             var precoMedio = produtos.Average(p => p.Preço);
             var produtosAcimaDaMedia = produtos.Where(p => p.Preço > precoMedio);

             Console.WriteLine("Produtos com preço acima da média:");
             foreach (var produto in produtosAcimaDaMedia)
             {
                 Console.WriteLine($"{produto.Nome}, {produto.Preço}");
             }

         }

    }

    
    // Q 3

    public class PessoaNova
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
    }

    public class Exercicios
    {
        public void ExibirResutados()
        {
            var pessoas = new List<PessoaNova>
{
            new PessoaNova { Nome = "Alice", Idade = 30, Cidade = "São Paulo" },
            new PessoaNova { Nome = "Bob", Idade = 25, Cidade = "Rio de Janeiro" },
            new PessoaNova { Nome = "Charlie", Idade = 35, Cidade = "São Paulo" },
            new PessoaNova { Nome = "Diana", Idade = 40, Cidade = "Belo Horizonte" },
            new PessoaNova { Nome = "Eve", Idade = 28, Cidade = "São Paulo" }
};


            var pessoasOrdemReversa = pessoas
           .OrderByDescending(p => p.Nome)
           .Select(p => p.Nome);

            Console.WriteLine("Nomes das pessoas em ordem alfabética reversa:");
            foreach (var nome in pessoasOrdemReversa)
            {
                Console.WriteLine(nome);
            }

        }

    }

    // Q 4

     public class PessoaNova
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
    }

    public class Exercicios
    {
        public void ExibirResutados()
        {
            var pessoas = new List<PessoaNova>
{
            new PessoaNova { Nome = "Alice", Idade = 30, Cidade = "São Paulo" },
            new PessoaNova { Nome = "Bob", Idade = 25, Cidade = "Rio de Janeiro" },
            new PessoaNova { Nome = "Charlie", Idade = 35, Cidade = "São Paulo" },
            new PessoaNova { Nome = "Diana", Idade = 40, Cidade = "Belo Horizonte" },
            new PessoaNova { Nome = "Eve", Idade = 28, Cidade = "São Paulo" }
};

            var pessoaMaisJovemPorCidade = pessoas
           .GroupBy(p => p.Cidade)
           .Select(grupo => grupo.OrderBy(p => p.Idade).First());

            Console.WriteLine("Pessoa mais jovem por cidade:");
            foreach (var pessoa in pessoaMaisJovemPorCidade)
            {
                Console.WriteLine($"{pessoa.Nome} de {pessoa.Cidade} com {pessoa.Idade} anos");
            }


        }

    }

    // Q 5

     public class Livro
    {
        public string Título { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
    }

    public class Exercicios
    {
        public void Exibirresultados()
        {
            var livros = new List<Livro>
         {
             new Livro { Título = "Livro A", Autor = "Autor A", AnoPublicacao = 1995 },
             new Livro { Título = "Livro B", Autor = "Autor B", AnoPublicacao = 2005 },
             new Livro { Título = "Livro C", Autor = "Autor C", AnoPublicacao = 2010 },
             new Livro { Título = "Livro D", Autor = "Autor D", AnoPublicacao = 2000 }
         };

            var livrosDepois2000 = livros
            .Where(l => l.AnoPublicacao > 2000)
            .OrderBy(l => l.AnoPublicacao);

            Console.WriteLine("Livros publicados após 2000, ordenados por ano:");
            foreach (var livro in livrosDepois2000)
            {
                Console.WriteLine($"{livro.Título} por {livro.Autor} ({livro.AnoPublicacao})");
            }


        }
    }

    
    public class PessoaNova
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
    }

    public class Exercicio
    {
        public void ExibirResultado()
        {
            var pessoas = new List<PessoaNova>
        {
            new PessoaNova { Nome = "Alice", Idade = 30, Cidade = "São Paulo" },
            new PessoaNova { Nome = "Bob", Idade = 25, Cidade = "Rio de Janeiro" },
            new PessoaNova { Nome = "Charlie", Idade = 35, Cidade = "São Paulo" },
            new PessoaNova { Nome = "Diana", Idade = 40, Cidade = "Belo Horizonte" },
            new PessoaNova { Nome = "Eve", Idade = 28, Cidade = "São Paulo" }
        };

            var pessoasDeSP = from pessoa in pessoas
                              where pessoa.Cidade == "São Paulo"
                              select pessoa;

            Console.WriteLine("Pessoas de São Paulo:");
            foreach (var pessoa in pessoasDeSP)
            {
                Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos");
            }



        }
    }


     public class PessoaNova
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
    }

    public class Exercicio
    {
        public void ExibirResultado()
        {
            var pessoas = new List<PessoaNova>
        {
            new PessoaNova { Nome = "Alice", Idade = 30, Cidade = "São Paulo" },
            new PessoaNova { Nome = "Bob", Idade = 25, Cidade = "Rio de Janeiro" },
            new PessoaNova { Nome = "Charlie", Idade = 35, Cidade = "São Paulo" },
            new PessoaNova { Nome = "Diana", Idade = 40, Cidade = "Belo Horizonte" },
            new PessoaNova { Nome = "Eve", Idade = 28, Cidade = "São Paulo" }
        };

            var pessoaMaisVelhaPorCidade = pessoas
             .GroupBy(p => p.Cidade)
             .Select(grupo => grupo.OrderByDescending(p => p.Idade).First());

            Console.WriteLine("Pessoa mais velha por cidade:");
            foreach (var pessoa in pessoaMaisVelhaPorCidade)
            {
                Console.WriteLine($"{pessoa.Nome} de {pessoa.Cidade} com {pessoa.Idade} anos");,
        }



        }
    }



    public class PessoaNova
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public decimal Salario { get; set; }
    }

    public class Exercicio
    {
        public void ExibirResultado()
        {
            var pessoasComSalario = new List<PessoaNova>
         {
             new PessoaNova { Nome = "Alice", Idade = 30, Cidade = "São Paulo", Salario = 1.800M },
             new PessoaNova { Nome = "Bob", Idade = 25, Cidade = "Rio de Janeiro", Salario = 2.800M },
             new PessoaNova { Nome = "Charlie", Idade = 35, Cidade = "São Paulo", Salario = 3.800M },
             new PessoaNova { Nome = "Diana", Idade = 40, Cidade = "Belo Horizonte", Salario = 4.800M},
             new PessoaNova { Nome = "Eve", Idade = 28, Cidade = "São Paulo" , Salario = 5.800M}
         };
            var salarioMedio = pessoasComSalario.Average(p => p.Salario);

            Console.WriteLine($"Salário Médio: {salarioMedio}");



        }
    }




    public class PessoaNova
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public decimal Salario { get; set; }
    }

    public class Exercicio
    {
        public void ExibirResultado()
        {
            var pessoas = new List<PessoaNova>
        {
            new PessoaNova { Nome = "Alice", Idade = 30, Cidade = "São Paulo", Salario = 1.800M },
            new PessoaNova { Nome = "Bob", Idade = 25, Cidade = "Rio de Janeiro", Salario = 2.800M },
            new PessoaNova { Nome = "Charlie", Idade = 35, Cidade = "São Paulo", Salario = 3.800M },
            new PessoaNova { Nome = "Diana", Idade = 40, Cidade = "Belo Horizonte", Salario = 4.800M},
            new PessoaNova { Nome = "Eve", Idade = 28, Cidade = "São Paulo" , Salario = 5.800M}
        };

            var pessoasEntre20e30 = pessoas
            .Where(p => p.Idade >= 20 && p.Idade <= 30)
            .OrderBy(p => p.Nome)
            .Select(p => p.Nome);

            Console.WriteLine("Pessoas com idade entre 20 e 30 anos (ordenadas por nome):");
            foreach (var nome in pessoasEntre20e30)
            {
                Console.WriteLine(nome);
            }

        }
    }



     public class PessoaNova
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public decimal Salario { get; set; }
    }

    public class Exercicio
    {
        public void ExibirResultado()
        {
            var pessoas = new List<PessoaNova>
         {
             new PessoaNova { Nome = "Alice", Idade = 30, Cidade = "São Paulo", Salario = 1.800M },
             new PessoaNova { Nome = "Bob", Idade = 25, Cidade = "Rio de Janeiro", Salario = 2.800M },
             new PessoaNova { Nome = "Charlie", Idade = 35, Cidade = "São Paulo", Salario = 3.800M },
             new PessoaNova { Nome = "Diana", Idade = 40, Cidade = "Belo Horizonte", Salario = 4.800M},
             new PessoaNova { Nome = "Eve", Idade = 28, Cidade = "São Paulo" , Salario = 5.800M}
         };

            var quantidadePessoasAcimaDe30 = pessoas.Count(p => p.Idade > 30);

            Console.WriteLine($"Quantidade de pessoas com mais de 30 anos: {quantidadePessoasAcimaDe30}");


        }
    }





     */






}



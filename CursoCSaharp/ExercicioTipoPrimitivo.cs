using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSaharp
{/**
  
  1. Modifique o método LerArmazenar para armazenar o sobrenome do usuário e
  exibi-lo junto com o nome:

  public static void EntradaSaida()
        {
            string? nome;
            string? sobrenome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome:");
            sobrenome = Console.ReadLine();
            Console.WriteLine($"O nome e: {nome}, o sonbrenome e:{sobrenome}");
        }

    2. Peça ao usuário para inserir a idade e exiba o nome e a idade:

          public static void EntradaSaida()
          {
                    string? nome;
                    int? idade;
                    Console.WriteLine("Digite o seu nome:");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o sua idade:");
                    idade = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"O nome e: {nome}, e idade e:{idade}");
          }

    3. Peça ao usuário para inserir a cidade e exiba o nome e a cidade:

     public static void EntradaSaida()
        {
            string? nome;
            string? Cidade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua Cidade:");
            Cidade = (Console.ReadLine());
            Console.WriteLine($"O seu nome é: {nome}, e a sua Cidade é:{Cidade}");
        }

     4. Armazene o nome do usuário em maiúsculas e exiba-o:

      public static void EntradaSaida()
        {
            string? nome;
            Console.WriteLine("Digite o seu nome com todas as letras minúsculas:");
            nome = Console.ReadLine(). ToUpper();
            Console.WriteLine($"O seu nome é: {nome}");
        }

    5. Armazene o nome do usuário em minúsculas e exiba-o:

    public static void EntradaSaida()
        {
            string? nome;
            Console.WriteLine("Digite o seu nome com todas as letras minúsculas:");
            nome = Console.ReadLine(). ToLower();
            Console.WriteLine($"O seu nome é: {nome}");
        }

    6. Peça ao usuário para inserir seu nome e idade, depois exiba ambos em uma única linha:

     public static void EntradaSaida()
        {
            string? nome;
            int? idade; 
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Você é o: {nome},{idade} anos ");
        }

    7. Peça ao usuário para inserir seu nome e cidade de nascimento, depois exiba ambos:

    public static void EntradaSaida()
        {
            string? nome;
            string? Cidade;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nome da cidade onde você nasceu:");
            Cidade = (Console.ReadLine());
            Console.WriteLine($"O seu nome é: {nome}, e você nasceu em:{Cidade}");
        }

    8. Peça ao usuário para inserir seu nome e profissão, depois exiba ambos:

     public static void EntradaSaida()
        {
            string? nome;
            string? profissao;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nome da sua profissão:");
            profissao = (Console.ReadLine());
            Console.WriteLine($"O seu nome é: {nome}, e você é um:{profissao}");
        }

  */
    public static class ExercicioTipoPrimitivo
    {
        public static void EntradaSaida()
        {
            string? nome;
            string? profissao;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nome da sua profissão:");
            profissao = (Console.ReadLine());
            Console.WriteLine($"O seu nome é: {nome}, e você é um:{profissao}");
        }
    }
}

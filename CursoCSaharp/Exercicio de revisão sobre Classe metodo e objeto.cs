using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    public class Exercicio_de_revisão_sobre_Classe_metodo_e_objeto
    {
    }
     // Q 1.
   public class Pessoa
    {
        // Propriedades da classe
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor para inicializar as propriedades
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método que imprime a mensagem
        public void Falar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }

    // Q 2.

   //using System;

class Calculadora1
    {
        // Método que realiza a soma de dois números inteiros
        public int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        // Método que realiza a subtração de dois números inteiros
        public int Subtracao(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}

 // Q 3.
//using System;

public class Carro
{
    // Propriedades automáticas
    public string Modelo3 { get; set; }
    public int Ano { get; set; }
    public decimal Preco { get; set; }

    // Método para exibir as informações do carro
    public void ExibirInfo()
    {
        Console.WriteLine($"Modelo: {Modelo3}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Preço: R${Preco}");
    }
}


// Q 4.
//using System;

class Matematica
{
    // Método estático que calcula o fatorial de um número inteiro não-negativo
    public static int Fatorial(int numero)
    {
        if (numero < 0)
            throw new ArgumentException("O número deve ser não-negativo.");

        if (numero == 0 || numero == 1)
            return 1;

        int resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}




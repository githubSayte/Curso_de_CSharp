
using System;
using Curso_C_;
using CursoCSharp;



    void Main(string[] args)
    {
        // Cria um objeto da classe Soma
        Revis somarN = new Revis();

        // Chama o método Somar passando os dois números e armazena o resultado
        int resultado = somarN.Somar(30, 5);

        // Exibe o resultado no console
        Console.WriteLine($"O resultado da soma é igual a: {resultado}");

        // Pausa o console para que o usuário veja o resultado
        Console.ReadLine();
    }



Carro carro1 = new Carro("Toyota", "Corolla", 2024);
carro1.ExibirDetalhes();

Pessoa1 pessoa1 = new Pessoa1();

pessoa1.Nome1 = "Rei Hokague";
pessoa1.Idade1 = 35;
pessoa1.Cidade1 = "Brasilia";

pessoa1.ExibirInformacoes();

Pessoa2 pessoa2 = new Pessoa2();

pessoa2.Nome2 = "Renato";
pessoa2.Idade2 = 25;

pessoa2.Exibir();

RevisãoExercicios.Questoes();



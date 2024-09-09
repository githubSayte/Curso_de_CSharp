
using CursoCSharp;



/**

 var explicacaoEnum = new ExplicacaoEnum();

 //chamando 
 explicacaoEnum.DemonstrarEnum();

 //Exibindo 
 explicacaoEnum.ExplicacaoDetalhada();
*/

/**
var recursao = new Recursao();
recursao.DemonstrarRecursao();
 */


/**
var explicacao = new ExplicacaoStructs();
explicacao.DemonstrarDiferenca();
*/


/**
// Criando uma instância da classe NullableTypesDemo
var demo = new NullableTypesDemo();

// Definindo valores para os tipos nullable
demo.Numero = null; // Numero pode ser null
demo.EstaCompleto = true; // EstaCompleto pode ser null ou bool

// Exibindo os valores
demo.ExibirValores();

// Mostrando o uso do operador de coalescência nula
Console.WriteLine($"Valor de Numero ou padrão: {demo.ObterValorOuPadrao()}");

 // Explicando os conceitos
 demo.ExplicarConceitos();

Colecoes colecoes = new Colecoes();

colecoes.ExplicarDictionary();
Console.WriteLine();

colecoes.ExplicarQueue();
Console.WriteLine();

colecoes.ExplicarStack();
Console.WriteLine();

colecoes.ExplicarSet()

*/

//var dia = new ExplicacaoEnum();
//dia.ExplicacaoDetalhada();
//dia.DemonstrarEnum();   


/**
class Programa1
{
   static void Main(string[] args)
   {
        // Cria uma instância da classe Pessoa
        Pessoa pessoa = new Pessoa("João", 30);

        // Chama o método Falar
        pessoa.Falar();
   }

}
*/
/**
using System.Collections.Generic;

class Programa2
{
    static void Main(string[] args)
    {
        // Cria uma instância da classe Calculadora
        Calculadora1 calc = new Calculadora1();

        // Usa o método Soma
        int resultadoSoma = calc.Soma(10, 5);
        Console.WriteLine($"Soma: 10 + 5 = {resultadoSoma}");

        // Usa o método Subtracao
        int resultadoSubtracao = calc.Subtracao(10, 5);
        Console.WriteLine($"Subtração: 10 - 5 = {resultadoSubtracao}");
    }
}
*/
/**
class Program
{
    static void Main(string[] args)
    {
        // Instancia a classe Carro
        Carro carro = new Carro();

        // Define os valores das propriedades
        carro.Modelo3 = "Ford Mustang";
        carro.Ano = 2022;
        carro.Preco = 250000.00m;  // Usando o sufixo 'm' para valores decimais

        // Chama o método ExibirInfo
        carro.ExibirInfo();
    }
*/

var livro = new Livro("Se houver amanhã", "Sidey Shadon", 1990, 1999);






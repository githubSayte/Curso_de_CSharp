using System;

namespace CursoCSharp
{    // Q 1, 2 e 3
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int Ano;


        public Carro(string marca, string modelo, int ano) 
        {          

            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public void ExibirDetalhes() 
        {
            Console.WriteLine($"As caracteristicas do carro são: A marca é: {Marca}, o modelo é: {Modelo} e o ano de fabricação é: {Ano}");
        
        }

    }
    //Q 4 e 5 
    public class Pessoa1 
    {
        public string Nome1;
        public int Idade1;
        public string Cidade1;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"As caracteristicas da pessoa em questão são: nome: {Nome}, idade: {Idade} anos e Cidade: {Cidade}"); 
        }
    }

    //Q 6 
    public class Pessoa2 
    {
        public int Idade2;
        public string Nome2; 
        public void Exibir()
        {
            Console.WriteLine($"Idade: {Idade2} anos, nome: {Nome2}");
        }
    }

    public class Soma
    {
        // Método que recebe dois parâmetros do tipo int e retorna a soma
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }

}
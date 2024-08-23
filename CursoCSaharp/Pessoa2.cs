using System;

namespace CursoCSharp
{
    public class Pessoa2
    {
       public string Nome;
       public int Idade;
       public string Cidade;

        public Pessoa2(string nome, int idade, string cidade) 
        {
            Nome = nome;
            Idade = idade;
            Cidade = cidade;
        }
        public void ExibirInformacoes()
        {
            
          Console.WriteLine($"As caracteristicas da pessoa em questão são: nome: {Nome}, idade: {Idade} anos e Cidade: {Cidade}");
         
        }
    }

}

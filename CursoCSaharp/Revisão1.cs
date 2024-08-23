using System;

namespace CursoCSharp
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;


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

   
}
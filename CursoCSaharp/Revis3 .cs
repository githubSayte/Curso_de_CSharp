using Curso_C_;
using System;

namespace CursoCSharp
{
    public class TipoVariavel
    {
        public void Exibir() 
        {
            var NomeClatura = "Rei Hokague!" ; // O compilador infere que o tipo é string
            var NumeroVariavel = 1; // O compilador infere que o tipo é int
            var AlturaDele = 1.70; // O compilador infere que o tipo é double

            var Data = new List<int> { 10, 4, 1989 };
            var Data = Data.OrderBy(p => p.Data);
            Console.WriteLine("\nData:");
            foreach (var pessoa in pessoasOrdenadasPorIdade)
            {
                Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos");
            }

            Console.WriteLine($"Numero inteiro: {NumeroVariavel}, Tipo: {NumeroVariavel.GetType()}");
            Console.WriteLine($"Numero real: {AlturaDele}, Tipo: {AlturaDele.GetType()}");
            Console.WriteLine($"Texto: {NomeClatura}, Tipo: {NomeClatura.GetType()}");

        }
        
    }
}

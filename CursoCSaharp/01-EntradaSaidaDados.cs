using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    public static class EntradaSaidaDados
    {
        public static void LerArmazenar()
        {

            Console.WriteLine("Digite o seu nome:");
            string? nome = Console.ReadLine();

            Console.WriteLine($"O nome e: {nome}");

        }
    }
}
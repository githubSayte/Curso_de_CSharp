using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CursoCSaharp
{
    public class Atividades_Operadores_Aritmeticos
    {

        /** 1.
        int? n1;
        int? n2;
        Console.WriteLine("Digite o primeiro numero");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o primeiro numero");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A soma dos numeros é: {(n1+n2)}");
        */

        /** 2.
int? n1;
int? n2;
Console.WriteLine("Digite o primeiro numero");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o primeiro numero");
n2 = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine($"A soma dos numeros é: {(n1+n2)}");
*/

        /** 3.
int? n1;
int? n2;
Console.WriteLine("Digite o primeiro numero");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o primeiro numero");
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A soma dos numeros é: {(n1+n2)}");
*/

        /** 4.
int? n1;
int? n2;
Console.WriteLine("Digite o primeiro numero");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o primeiro numero");
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A soma dos numeros é: {(n1+n2)}");
*/

        /** 5.
int? n1;
int? n2;
Console.WriteLine("Digite o primeiro numero");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
n2 = Convert.ToInt32(Console.ReadLine());

if(n2 == 0 || n1 == 0)

{
Console.WriteLine("o segundo numero não pode ser 0 ")
}

else
{
Console.WriteLine($"A divisão entre os dois numeros é {(n1/n2)}");
}

public static void apresentardados()
{
/** 6.
            int? n1;         
            Console.WriteLine("Digite o primeiro numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Digite o primeiro numero{n1++}");

}
/** 7.
         int? n1;         
            Console.WriteLine("Digite o primeiro numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Digite o primeiro numero{n1--}");

*/

        /** 8.

9
int? n1;
int? n2;
int? n3;
Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"o resultado é:{(n1+n2)-2}");

         /** 10
public static void apresentardados()
{

            int? n1;
            int? n2;
            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"o resultado é:{(n1 * n1)+n2}");
*/
        /** 11
        public static void apresentardados()
        {
            int? n1;
            
            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O dobro da variavel é:{(2 * n1)}");
            Console.WriteLine($"A metade da variavel é:{(n1 / 2)}");
         }
          */

        /**12.
        public static void apresentardados()
        {
            int? n1;
        int? n2;
            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"o resultado da expressão é: {(n1 + n2) * (n1 - n2)}.");
        
         public static void apresentardados()
        {
            int dias;
            Console.WriteLine("Digite a quantidade de dias:?");
            dias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A quantidade de horas contidas nos dias informados são: {(dias * 24)}");

        }


        */

        public static void MostrarResultado()
        {
            Console.Write("Digite a hora e os minutos no formato HHMM (ex: 1430 para 14:30):");
            string input = Console.ReadLine();

            // Verificar se a entrada tem o comprimento correto (4 caracteres)
            if (input.Length == 4 && int.TryParse(input, out _))
            {
                // Extrair horas e minutos da string
                int horas = int.Parse(input.Substring(0, 2));
                int minutos = int.Parse(input.Substring(2, 2));

                // Converter horas e minutos em minutos totais
                int minutosTotais = (horas * 60) + minutos;
                Console.WriteLine($"Total em minutos: {minutosTotais}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de digitar 4 dígitos.");
            }
        }

    } 
}
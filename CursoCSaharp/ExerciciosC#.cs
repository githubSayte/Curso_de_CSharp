using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CursoCSharp
{
    public class ExerciciosC_
    {
        /**
        1. Criando e Inicializando um Array
        Crie um array de inteiros chamado numeros com capacidade para 5 elementos. Inicialize-o com os valores 2, 4, 6, 8, 10 e imprima todos os elementos.
        */
        public void Resposta1()
        {
            Console.WriteLine("Resposta da questão 1");
            int[] numeros = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < numeros.Length; i++)
            {
               Console.WriteLine(numeros[i]);
            }
            
        }
        /**
         2. Acessando Elementos de um Array
         Dado o array int[] valores = {1, 3, 5, 7, 9};, imprima o terceiro elemento do array.
         */
        
        public void Resposta2()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 2");
            int[] numeros = { 1, 3, 5, 7, 9 };
            Console.WriteLine($"O terceiro elemento do array é: {numeros[2]}");
        }
        /**
         3.	Alterando Valores em um Array
         Crie um array de strings chamado nomes com os valores "Ana", "Bruno", "Carla". Mude o valor de "Bruno" para "Beto" e depois imprima todos os elementos do array.
         */
        public void Resposta3()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 3");
            // Substituir o elemento "Bruno" por "Beto" no array
            string[] nomes = {"Ana", "Bruno", "Carla"};

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == "Bruno") 
                {
                  nomes[i] = "Beto";
                }
            }
            for (int i = 0; i < nomes.Length; i++)
            {
              Console.WriteLine(nomes[i]);
            }
        }
        /**
         4.	Calculando a Soma dos Elementos de um Array
         Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6. Calcule e imprima a soma de todos os elementos do array.
         */
        public void Resposta4() 
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 4");
           
            int[] notas = { 7, 8, 9, 10, 6 };
            int soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
              soma += notas[i];
            }
            Console.WriteLine("A soma de todos os elementos do array é igual a: " + soma);
        }
        /**
        5.	Procurando um Elemento em um Array
        Dado o array int[] numeros = { 5, 10, 15, 20, 25 };, escreva um código que verifique se o número 15 está presente no array e imprima uma mensagem confirmando.
        */
        public void Resposta5()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 5");

            int[] numeros = { 5, 10, 15, 20, 25 };

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 15)
                {
                    Console.WriteLine("Confirmado, o número 15 está presente no array!");
                    return;  // Sai do método, pois o número foi encontrado
                }
            }

            Console.WriteLine("Não confirmado, o número 15 não está presente no array!");
        }

        /**
         6.	Criando e Adicionando Elementos em uma List
         Crie uma List<string> chamada frutas. Adicione as frutas "Maçã", "Banana", "Laranja" e imprima todos os elementos da lista.
         */
        public void Resposta6()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 6");
            List<string> frutas = { };
            add."Maçã";
        }

        /**
          
          */
        public void Resposta7()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 7");
        }

        /**
          
          */
        public void Resposta8()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 8");
        }

        /**
          
          */
        public void Resposta9()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 9");
        }

        /**
          
          */
        public void Resposta10()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 10");
        }

        /**
          
          */
        public void Resposta11()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 11");
        }

        /**
          
          */
        public void Resposta12()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 12");
        }

        /**
          
          */
        public void Resposta13()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 13");
        }

        /**
          
          */
        public void Resposta14()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 14");
        }

        /**
          
          */
        public void Resposta15()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 15");
        }

        /**
          
          */
        public void Resposta16()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 16");
        }
    }
}
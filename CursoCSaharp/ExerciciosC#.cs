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
            int[] numeros0 = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < numeros0.Length; i++)
            {
               Console.WriteLine(numeros0[i]);
            } 
        }

        /**
        2. Acessando Elementos de um Array
        Dado o array int[] valores = {1, 3, 5, 7, 9};, 
        imprima o terceiro elemento do array.
        */
        
        public void Resposta2()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 2");
            int[] numeros1 = { 1, 3, 5, 7, 9 };
            Console.WriteLine($"O terceiro elemento do array é: {numeros1[2]}");
        }

        /**
        3.	Alterando Valores em um Array
        Crie um array de strings chamado nomes com os valores "Ana", "Bruno", "Carla". 
        Mude o valor de "Bruno" para "Beto" e depois imprima todos os elementos do array.
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
        Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6. 
        Calcule e imprima a soma de todos os elementos do array.
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
        Dado o array int[] numeros = { 5, 10, 15, 20, 25 };, 
        escreva um código que verifique se o número 15 está presente no array e imprima uma mensagem confirmando.
        */

        public void Resposta5()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 5");

            int[] numeros2 = { 5, 10, 15, 20, 25 };

            for (int i = 0; i < numeros2.Length; i++)
            {
                if (numeros2[i] == 15)
                {
                    Console.WriteLine("Confirmado, o número 15 está presente no array!");
                    return;  // Sai do método, pois o número foi encontrado
                }
            }

            Console.WriteLine("Não confirmado, o número 15 não está presente no array!");
        }

        /**
        6.	Criando e Adicionando Elementos em uma List
        Crie uma List<string> chamada frutas.
        Adicione as frutas "Maçã", "Banana", "Laranja" e imprima todos os elementos da lista.
        */

        public void Resposta6()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 6");
            Console.WriteLine("Criando a lista: frutas");
            List<string> frutas = new List<string>();
            //Adicionar Elementos à Lista
            frutas.Add("Maçã");
            frutas.Add("Banana");
            frutas.Add("Laranja");
            //Exibir lista com os elementos adicionados
            Console.WriteLine("a lista 'frutas' após a adição de elementos:");
            Console.WriteLine("frutas:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }          
        }

        /**
        7. Removendo um Elemento de uma List
        Crie uma List<int> chamada numeros e adicione os valores 1, 2, 3, 4, 5. 
        Remova o número 3 da lista e depois imprima os elementos restantes.
        */

        public void Resposta7()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 7");
            Console.WriteLine("Criando a lista 'numeros'");
            // Adicionar Elementos à Lista
            List<int> numeros3 = new List<int>();
            numeros3.Add(1);
            numeros3.Add(2);
            numeros3.Add(3);
            numeros3.Add(4);
            numeros3.Add(5);
            Console.WriteLine("A lista 'numeros' após a adição de elementos:");
            Console.WriteLine("numeros");
            foreach (int numero in numeros3)
            {
                Console.WriteLine(numero);
            }
            // Remover Elementos da Lista
            Console.WriteLine("\nLista 'numeros' após remoções de elementos:");
            numeros3.RemoveAt(2); // Remove o terceiro elemento da lista
            Console.WriteLine("numeros");
            foreach (int numero in numeros3)
            {
                Console.WriteLine(numero);
            }
        }

        /**
        8. Acessando um Elemento Específico em uma List
        Dada a List<string> chamada cidades = new List<string> {"São Paulo", "Rio de Janeiro", "Belo Horizonte"}, imprima a segunda cidade da lista.
        */

        public void Resposta8()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 8");
            Console.WriteLine("Cidades");
            List<string> cidades = new List<string> { "São Paulo", "Rio de Janeiro", "Belo Horizonte" };
            foreach (string cidade in cidades)
            {
                Console.WriteLine(cidade);
            }
            Console.WriteLine("A segunda cidade da lista é:" + cidades[1]);
        }
        
        /**
        9.	Contando Elementos em uma List
        Crie uma List<string> chamada animais e adicione os valores "Cachorro", "Gato", "Coelho". Escreva um código que imprima quantos elementos existem na lista.
        */

        public void Resposta9()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 9");
            Console.WriteLine("Criando a lista: animais");
            List<string> animais = new List<string>();
            //Adicionar Elementos à Lista
            animais.Add("Cachorro");
            animais.Add("Gato");
            animais.Add("Coelho");
            //Exibir lista com os elementos adicionados
            Console.WriteLine("a lista 'animais' após a adição de elementos:");
            Console.WriteLine("animais:");
            foreach (string animal in animais)
            {
                Console.WriteLine(animal);
            }
        }

        /**
        10.	Variável Local em um Método
        Escreva um método chamado CalculaSoma que declare uma variável local int soma e calcule a soma de dois números passados como parâmetros.
        A variável soma deve estar acessível apenas dentro deste método.
        */

        public void Resposta10_CalculaSoma(int n1, int n2)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 10");

            // Declaração da variável local 'soma'
            int soma = n1 + n2;

            // Exibe a soma dos números
            Console.WriteLine($"A soma de {n1} e {n2} é igual a: {soma}");
        }

        /**
         * 11.	Variável Global em uma Classe
         Crie uma classe chamada Carro com uma variável global string marca. 
         No método Main, instancie um objeto Carro, defina a marca do carro como "Toyota" e imprima a marca.
         */

        public void Resposta11()
        {
           Console.WriteLine("\n");
           Console.WriteLine("Resposta da questão 11");
        }

        /**
        12.	Conflito de Escopo
        Escreva um método onde você declare uma variável local com o mesmo nome de uma variável global da classe.
        Mostre como acessar ambas as variáveis no mesmo método.
        */

        public void Resposta12()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 12");

        }

        /**
        13. Variável Local dentro de um Bloco Condicional
        Escreva um código onde uma variável int x seja declarada dentro de um bloco if. 
        Tente acessar essa variável fora do bloco if e observe o que acontece.
        */

        public void Resposta13()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 13");
        }

        /**
        14.	Alterando o Valor de uma Variável Global
        Crie uma variável global int contador em uma classe. 
        No método Main, altere o valor de contador dentro de um loop for e depois imprima o valor final de contador.
        */

        public void Resposta14()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 14");
        }

        /**
        15. Capturando uma Exceção de Conversão de Tipo
        Tente converter uma string não numérica para um inteiro usando int.Parse. 
        Use try-catch para capturar a exceção e imprima uma mensagem apropriada.
        */

        public void Resposta15()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 15");
        }

        /**
        16.	Lançando Exceções
        Escreva um método que recebe um número inteiro. Se o número for negativo, lance uma ArgumentException. 
        Capture a exceção no método Main e imprima uma mensagem apropriada.
        */

        public void Resposta16()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Resposta da questão 16");
        }
    }

}
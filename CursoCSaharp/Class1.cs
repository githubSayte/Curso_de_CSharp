using System;

namespace CursoCSharp
{/**
    public class Carro
    {
        public string Marca { get; }
        public string Modelo { get; }
        public int Ano { get; }

        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        // Método que exibe os detalhes do carro
        public void ExibirDetalhes()
        {
            Console.WriteLine($"A marca do carro é {Marca}, o modelo do carro é {Modelo}, e o ano do carro é {Ano}");
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }

        // Método que exibe as informações da pessoa
        public void ExibirInformacoes()
        {
            Console.WriteLine($"O nome da pessoa é {Nome}, a idade é {Idade}, e a cidade é {Cidade}");
        }
    }

    public class Exercicio
    {
        public string Nome { get; set; } = "Rodrigo";
        public int Idade { get; set; } = 25;

        // Método que exibe o nome e a idade
        public void Exibir()
        {
            Console.WriteLine($"O nome é {Nome}, a idade é {Idade}");
        }

        // Método que retorna a soma de dois números
        public int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        // Método que exibe se está chovendo ou não
        public bool MostrarBoleano()
        {
            bool estaChovendo = false;

            if (estaChovendo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Método que verifica se a pessoa é maior de idade
        public bool VerificarMaioridade(int idade)
        {
            return idade >= 18;
        }

        // Método que exibe a altura formatada com duas casas decimais
        public void ExibirAltura()
        {
            double altura = 1.75;
            Console.WriteLine($"A altura é {altura:F2}");
        }

        // Método que exibe o caractere armazenado na variável 'letra'
        public void ExibirChar()
        {
            char letra = 'A';
            Console.WriteLine($"O caractere é {letra}");
        }

        // Método que exibe a nota e diz se a pessoa foi aprovada ou reprovada
        public void ExibirNota(double nota)
        {
            if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }

        // Método que calcula o fatorial de um número
        public long Fatorial(int n)
        {
            if (n == 0)
            {
                return 1; // O fatorial de 0 é 1
            }

            long resultado = 1;

            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }

    public class Calculadora
    {
        // Método que multiplica dois números inteiros
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Sobrecarga do método Multiplicar para três números inteiros
        public int Multiplicar(int a, int b, int c)
        {
            return a * b * c;
        }
    }

    public class FluxoLoop
    {
        // Método que exibe números de 1 a 10
        public void ExibirLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Método que exibe números de 10 a 1 usando loop while
        public void ExibirLoopWhile()
        {
            int contador = 10;
            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador--;
            }
        }

        // Método que imprime os números pares até o número n
        public void ImprimirPares(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Programa
    {
        static void Main()
        {
            // Parte 1: Criação de Classes e Objetos
            Carro carro = new Carro("Honda", "Civic", 2024);
            carro.ExibirDetalhes();

            Pessoa pessoa = new Pessoa
            {
                Nome = "Rodrigo",
                Idade = 43,
                Cidade = "Brasília"
            };
            pessoa.ExibirInformacoes();

            // Parte 2: Manipulação de Variáveis e Tipos Primitivos
            Exercicio exercicio = new Exercicio();
            exercicio.Exibir();
            int soma = exercicio.Soma(9, 3);
            Console.WriteLine($"A soma de dois números é {soma}");

            bool estaChovendo = exercicio.MostrarBoleano();
            Console.WriteLine($"Está chovendo? {estaChovendo}");

            bool maioridade = exercicio.VerificarMaioridade(20);
            Console.WriteLine($"A pessoa é maior de idade? {maioridade}");

            exercicio.ExibirAltura();
            exercicio.ExibirChar();
            exercicio.ExibirNota(9);

            long fatorial = exercicio.Fatorial(10);
            Console.WriteLine($"O fatorial é: {fatorial}");

            // Parte 3: Métodos e Sobrecarga
            Calculadora calculadora = new Calculadora();
            double produto2 = calculadora.Multiplicar(2, 3);
            Console.WriteLine($"O resultado da multiplicação com dois parâmetros é {produto2}");

            double produto3 = calculadora.Multiplicar(2, 3, 4);
            Console.WriteLine($"O resultado da multiplicação com três parâmetros é {produto3}");

            // Parte 4: Controle de Fluxo e Loops
            FluxoLoop fluxoLoop = new FluxoLoop();
            fluxoLoop.ExibirLoop();
            fluxoLoop.ExibirLoopWhile();
            fluxoLoop.ImprimirPares(6);
        }
    }
}
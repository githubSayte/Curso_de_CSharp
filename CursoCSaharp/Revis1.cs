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
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;

        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"A marca do carro e {Marca} o modelo do carro e {Modelo} e o ano do carro e {Ano}");
        }
    }

    public class PessoaNova
    {
        public string Nome;
        public int Idade;
        public string Cidade;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O nome da pessoa e {Nome} a idade da pessoa e {Idade} e a cidade da pessoa e {Cidade}");

        }
    }

    public class Exercicio
    {
        public string Nome = "Rodrigo";
        public int Idade = 25;
        public void Exibir()
        {
            Console.WriteLine($"O nome e {Nome} a idade e{Idade}");

        }

        public int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

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

        public bool verificarMaioridade(int idade)
        {
            if (idade >= 18)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public void ExibirAltura()
        {
            Double altura = 1.7554646546546;
            Console.WriteLine($"A altura e {altura:F2}");
        }

        public double CalcularArea(double raio)
        {
            return ((raio * raio) * 3.14);
        }

        public double CalcularArea(double l, double h)
        {
            return l * h;
        }

        public void ExibirChar()
        {
            char letra = 'A';
            Console.WriteLine($"O caractere e {letra}");
        }
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
        public double Multiplicar(double n1, double n2)
        {
            return (n1 * n2);
        }
        public double Multiplicar(double n1, double n2, double n3)
        {
            return (n1 * n2 * n3);
        }
    }

    public class FluxoLoop
    {
        public void ExibirLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}");
            }
        }

        public void ExibirLoopWhile()
        {
            int contador = 10;
            while (contador >= 1)
            {
                Console.WriteLine($"{contador}");
                contador--;
            }
        }
        public void ImprimirPares(int n)
        {
            int contador = 1;
            while (contador <= n)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
            }


        }

    }

}

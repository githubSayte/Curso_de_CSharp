using Curso_C_;

Carro carro = new Carro("Honda", "Civic", 2024);
carro.ExibirDetalhes();

PessoaNova ps = new PessoaNova();
ps.Nome = "Rodrigo";
ps.Idade = 43;
ps.Cidade = "Brasilia";

Exercicio exercicio = new Exercicio();
exercicio.Exibir();

int rebeceSoma = exercicio.Soma(9, 3);
Console.WriteLine($"A soma dde dois numeros e {rebeceSoma}");

bool recebeBool = exercicio.MostrarBoleano();
Console.WriteLine($"Esta chevendo?{recebeBool}");

bool recebeBoolIdade = exercicio.verificarMaioridade(20);
Console.WriteLine($"A pessoa e maior de idade? {recebeBoolIdade}");

exercicio.ExibirAltura();

double recebeAreaC = exercicio.CalcularArea(9.45);
Console.WriteLine($"A area e {recebeAreaC:F2}");

double recebeAreaR = exercicio.CalcularArea(9, 6);
Console.WriteLine($"A area e {recebeAreaR:F2}");

Calculadora ck = new Calculadora();
double recebeMulti2 = ck.Multiplicar(2, 3);
Console.WriteLine($"O valor da multiplicação com dois parametros e{recebeMulti2}");
double recebeMulti3 = ck.Multiplicar(2, 3, 4);
Console.WriteLine($"O valor da multiplicação com tres parametros e{recebeMulti3}");

exercicio.ExibirChar();
exercicio.ExibirNota(9);
long recebeFatorial = exercicio.Fatorial(10);
Console.WriteLine($"O Fatorial e: {recebeFatorial}");




FluxoLoop fl = new FluxoLoop();
fl.ExibirLoop();
fl.ExibirLoopWhile();
fl.ImprimirPares(6);


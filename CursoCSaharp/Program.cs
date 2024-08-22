
using Curso_C_;
using CursoCSharp;

//bool resultado;
//resultado =  OperadoresLogicos.ELogico(false, false);
//Console.WriteLine($"O resultado do operador logico E:{resultado}");
//resultado = OperadoresLogicos.Negacao(true);
//Console.WriteLine($"O resultado do operador logico Negação:{resultado}");
//resultado = OperadoresLogicos.OULogico(true, true);
//Console.WriteLine($"O resultado do operador logico OuLogico:{resultado}");
//resultado = OperadoresLogicos.OUExclusivo(false, false);
//Console.WriteLine($"O resultado do operador logico OUExclusivo:{resultado}");



//TipoPrimitivo.ImprimirTipos();
//EntradaSaidaDados.LerArmazenar();
//Exercicios.EntradaSaida();
//OperadoresAritmeticos.Soma();
//OperadoresAritmeticos.Subtracao();
//OperadoresAritmeticos.Divisao();
//OperadoresAritmeticos.Multiplicacao();
//OperadoresAritmeticos.Resto();
//OperadoresAritmeticos.Incremento();
//OperadoresAritmeticos.Decremento();

//OperadoresAtribuicao.AtribuicaoSimples()
//OperadoresComparação.DemonstrarOperadores()
//OperadorTernario.DemonstrarTernario();
//Conversão.DemonstrarConversoes();
//EstruturaCondicional.DemonstrarCondicionais();
//EstruturaRepetição.DemonstrarRepeticoes();
//_11_Array.DemonstrarArray();
//_12_ListExemplo.DemonstrarLista();
//_13_EscopoVariavel escopoVariavel = new _13_EscopoVariavel();

//escopoVariavel.Metodo1();
//escopoVariavel.Metodo2();
//escopoVariavel.Metodo3();
//escopoVariavel.ExibirContadorGlobal();
//Aluno vitor = new Aluno();
//Aluno atila = new Aluno();

//vitor.nome = "João Vitor";
//vitor.matricula = "321321321321";
//vitor.curso = "Técnico";
//atila.nome = "Atila Cantoara";
//atila.matricula = "654654654654";
//atila.curso = "Técnico";

//Console.WriteLine($"O nome do aluno é, {vitor.nome}, o curso do aluno é,{vitor.curso} e a matricula do aluno é {vitor.matricula}");
//Console.WriteLine($"O nome do aluno é, {atila.nome}, o curso do aluno é,{atila.curso} e a matricula do aluno é {atila.matricula}");
//_13_EscopoVariavel  variavel = new _13_EscopoVariavel();
//variavel.Metodo1();
//variavel.Metodo2();
//variavel.Metodo3();
//variavel.ExibirContadorGlobal();
/** 
 TratarExcecoes tr = new TratarExcecoes();
tr.ExecutarDivisao(9, 3);
TratarExcecoes tr1 = new TratarExcecoes();
tr1.ExecutarDivisao(0, 2);
*/


/** 
ExerciciosC_ ex = new ExerciciosC_();
ex.Resposta1();
ex.Resposta2();
ex.Resposta3();
ex.Resposta4();
ex.Resposta5();
ex.Resposta6();
ex.Resposta7();
ex.Resposta8();
ex.Resposta9();
ex.Resposta10_CalculaSoma(1,2);
ex.Resposta11();
ex.Resposta12();
ex.Resposta13();
ex.Resposta14();
ex.Resposta15();
ex.Resposta16();
*/

/** 
ConceitosOOP conceitos = new ConceitosOOP();
conceitos.ExplicarOrientacaoAObjetos();
conceitos.DiferencaEntreParadigmas();
conceitos.ExplicarPilares();

Pessoa pessoa1 = new Pessoa("Alice",30);
Pessoa pessoa2 = new Pessoa("Bob", 25);


// 2 usando metodos de instancia (metodos não estaticos)

pessoa1.ExibirInformacoes();
pessoa2.ExibirInformacoes();

// 3 usando metodo estático (pertence a Classe, não a instancia)
Pessoa.ExibirNumeroDePessoas();

// 4 membros de instancias vs. Membros Estáticos
Console.WriteLine($"Pessoa1: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
Console.WriteLine($"Pessoa1: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
Console.WriteLine($"Número total de pessoas: {Pessoa.NumeroDePessoas}");
*/



// Instanciando a classe Produto usando o construtor padrão
Produto produto1 = new Produto();
produto1.ExibirInformacoes();

// Instanciando a classe Produto usando o construtor com parâmetros
Produto produto2 = new Produto("Smartphone", 1999.99m, 50);
produto2.ExibirInformacoes();

// Modificando atributos usando propriedades
produto1.Nome = "Notebook";
produto1.Preco = 2999.99m;
produto1.Estoque = 25;
produto1.ExibirInformacoes();

// Acessando método protegido através da classe derivada
ProdutoEspecial produtoEspecial = new ProdutoEspecial();
produtoEspecial.ExibirMetodoProtegido();

// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Models;

// Pessoa p = new Pessoa();
// p.Nome = "campos";
// p.Idade = 26;
// p.Apresentar();

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;
// DateTime dataVencimento = DateTime.Now.AddDays(5);

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade:"+quantidade);
// Console.WriteLine("Valor da variável altura:"+altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco:"+preco);
// Console.WriteLine("Valor da variável condicao:"+condicao);
// Console.WriteLine("Valor da variável dataVencimento:" + dataVencimento.ToString("dd/MM/yyyy HH:mm"));

// int a = 10;
// int b = 20;

// int c = a + b;
// c = c + 5; //30 + 5
// c += 5;
// c -= 5;
// c *= 5;
// Console.WriteLine(c);
// //Cast - Casting
// int d = Convert.ToInt32("5");
// Console.WriteLine(d);
// int e = int.Parse("5");
// Console.WriteLine(e);
// double f = double.Parse("5");
// Console.WriteLine(f);

// int g = Convert.ToInt32(null); // o metodo parse não aceita nulo enquanto a classe convert aceita e retorna 0, por isso é recomendável usar a classe convert
// Console.WriteLine(g);

// int inteiro = 5;
// string h = inteiro.ToString();
// Console.WriteLine(h);

// int i = 5;
// double j = i;
// Console.WriteLine(j); //implicitamente está sendo feita a conversão de um inteiro em double (pois um double suporta valores inteiros), este é um tipo de cast implícito
// //inteiro milhões, long bilhões, sendo assim inteiro cabe dentro de long

// int l = 5;
// long m = l;
// Console.WriteLine(m); //cast implícito também, porém se for de long para int, é preciso fazer a conversão

// // long n = long.MaxValue;
// // int o = Convert.ToInt32(n);
// // Console.WriteLine(o);   //Ctrl k+c

// int q = int.MaxValue;
// long r = q;
// Console.WriteLine(r);

// double s = 4 / 2 + 2;
// Console.WriteLine(s);

// string t = "15-";
// int u = 0;
// int.TryParse(t, out u);
// Console.WriteLine(u);
// Console.WriteLine("Conversão realizada com sucesso!");

// string v = "15-";
// //int x = 0;
// int.TryParse(v, out int x);
// Console.WriteLine(x);
// Console.WriteLine("Conversão realizada com sucesso!");

//Operadores condicionais

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;

// if (quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }

//Operadores condicionais - refatorando o código acima
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra>0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }

//Operadores condicionais - switch case

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//         Console.WriteLine("Vogal.");
//         break;
//     case "e":
//         Console.WriteLine("Vogal.");
//         break;
//     case "i":
//         Console.WriteLine("Vogal.");
//         break;
//         case "o":
//         Console.WriteLine("Vogal.");
//         break;
//         case "u":
//         Console.WriteLine("Vogal.");
//         break;
//     default:
//         Console.WriteLine("Você digitou uma letra não vogal.");
//         break;
// }

// Operadores lógicos

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResoponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResoponsavel)
// {
//     Console.WriteLine("Entrada liberada.");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada.");
// }

//Operadores lógicos - AND
// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado.");
// }
// else
// {
//     Console.WriteLine("Reprovado.");
// }

//Operadores lógicos - NOT
// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar.");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia.");
// }


//Calculadora
// Calculadora calc = new Calculadora();
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);

// calc.RaizQuadrada(9);

//Estrutura de repetição FOR

// int numero = 5;

// for(int contador=0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

//Estrutura de repetição WHILE
// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }

//Estrutura de repetição DO WHILE
//  int soma=0, numero = 0;

// do
// {
//     Console.WriteLine($"Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"A soma dos números digitados é: {soma}");

//Estrutura de repetição MENU - DO WHILE

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - cadastrar cliente");
    Console.WriteLine("2 - buscar cliente");
    Console.WriteLine("3 - apagar cliente");
    Console.WriteLine("4 - sair");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrando cliente...");
            break;
        case "2":
            Console.WriteLine("Buscando cliente...");
            break;
        case "3":
            Console.WriteLine("Apagando cliente...");
            break;
        case "4":
            Console.WriteLine("Saindo...");
            exibirMenu = false;
            //Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

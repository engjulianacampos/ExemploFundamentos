// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Models;

Pessoa p = new Pessoa();
p.Nome = "campos";
p.Idade = 26;
p.Apresentar();

string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;
DateTime dataVencimento = DateTime.Now.AddDays(5);

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade:"+quantidade);
Console.WriteLine("Valor da variável altura:"+altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco:"+preco);
Console.WriteLine("Valor da variável condicao:"+condicao);
Console.WriteLine("Valor da variável dataVencimento:" + dataVencimento.ToString("dd/MM/yyyy HH:mm"));

int a = 10;
int b = 20;

int c = a + b;
c = c + 5; //30 + 5
c += 5;
c -= 5;
c *= 5;
Console.WriteLine(c);

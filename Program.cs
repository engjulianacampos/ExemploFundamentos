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
//Cast - Casting
int d = Convert.ToInt32("5");
Console.WriteLine(d);
int e = int.Parse("5");
Console.WriteLine(e);
double f = double.Parse("5");
Console.WriteLine(f);

int g = Convert.ToInt32(null); // o metodo parse não aceita nulo enquanto a classe convert aceita e retorna 0, por isso é recomendável usar a classe convert
Console.WriteLine(g);

int inteiro = 5;
string h = inteiro.ToString();
Console.WriteLine(h);

int i = 5;
double j = i;
Console.WriteLine(j); //implicitamente está sendo feita a conversão de um inteiro em double (pois um double suporta valores inteiros), este é um tipo de cast implícito
//inteiro milhões, long bilhões, sendo assim inteiro cabe dentro de long

int l = 5;
long m = l;
Console.WriteLine(m); //cast implícito também, porém se for de long para int, é preciso fazer a conversão

// long n = long.MaxValue;
// int o = Convert.ToInt32(n);
// Console.WriteLine(o);   //Ctrl k+c

int q = int.MaxValue;
long r = q;
Console.WriteLine(r);

double s = 4 / 2 + 2;
Console.WriteLine(s);

string t = "15-";
int u = 0;
int.TryParse(t, out u);
Console.WriteLine(u);
Console.WriteLine("Conversão realizada com sucesso!");

string v = "15-";
//int x = 0;
int.TryParse(v, out int x);
Console.WriteLine(x);
Console.WriteLine("Conversão realizada com sucesso!");

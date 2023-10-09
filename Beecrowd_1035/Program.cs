
string[] valores = (Console.ReadLine() ?? "2 3 5 2") .Split(' ');

int a = int.Parse(valores[0]);
int b = int.Parse(valores[1]);
int c = int.Parse(valores[2]);
int d = int.Parse(valores[3]);


int x = a + b;
int y = c + d;

if (b > c && d > a && y > x && c >= 0 && d >= 0 && a%2 == 0)
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}
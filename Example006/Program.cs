// Задача по поиску самой тажелой гири
int a = new Random().Next(1,20);

int b = new Random().Next(1,20);

int c = new Random().Next(1,20);

int d = new Random().Next(1,20);

int e = new Random().Next(1,20);

int max = a;

if (a > max) max = a;

if (b > max) max = b;

if (c > max) max = c;

if (d > max) max = d;

if (e > max) max = e;

Console.Write("a = ");
Console.WriteLine(a);

Console.Write("b = ");
Console.WriteLine(b);

Console.Write("c = ");
Console.WriteLine(c);

Console.Write("d = ");
Console.WriteLine(d);

Console.Write("e = ");
Console.WriteLine(e);

Console.Write("max = ");
Console.WriteLine(max);
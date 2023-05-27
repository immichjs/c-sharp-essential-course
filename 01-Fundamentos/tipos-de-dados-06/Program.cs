int? x = null;
int y = x ?? 0;

Console.WriteLine(x);
Console.WriteLine(y);

x = 10;
y = x ?? 0;

Console.WriteLine(x);
Console.WriteLine(y);

int? a = 10;
int? b = 5;
int? c = 2;

Console.WriteLine(a * b * c);

if (a.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
} else
{
    Console.WriteLine("Não possui valor (null)");
}


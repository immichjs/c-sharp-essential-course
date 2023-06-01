using System.Linq.Expressions;
bool repeat = true;
bool? specialClient = null;

Console.WriteLine("Cliente especial (true/false)");
specialClient = Convert.ToBoolean(Console.ReadLine());

repeat = false;


if (specialClient == true)
{
    Console.WriteLine("Desconto de 10%");
}

int x, y;

Console.WriteLine("Informe o valor de X");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de Y");
y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X é maior que Y");
}

if (x < y)
{
    Console.WriteLine("X é menor que Y");
}

if (x == y)
{
    Console.WriteLine("X é igual Y");
}
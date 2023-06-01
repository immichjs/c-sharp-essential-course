while(true)
{
    Console.WriteLine("Informe um número");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 999)
    {
        break;
    }

    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} é par");
    } else
    {
        Console.WriteLine($"{number} é impar");
    }
}

int x = 0;

while (x <= 5)
{
    int y = 0;
    while (y <= 5)
    {
        Console.Write($"({x},{y})");
        y++;
    }
    x++;
    Console.WriteLine();
}
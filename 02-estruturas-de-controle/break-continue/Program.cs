for (; ;)
{
    string opcao = Console.ReadLine();

    if (opcao.ToLower() == "x")
    {
        Console.WriteLine("Finalizando...");
        break;
    }
}

for (int i = 0; i <= 10 ; i++)
{
    if (i == 5)
    {
        continue;
    }

    Console.WriteLine($"i = {i}");
}

int n = 0;
while (n <= 10)
{
    if (n == 5)
    {
        continue;
    }

    Console.WriteLine($"i = {n}");
    n++;
}
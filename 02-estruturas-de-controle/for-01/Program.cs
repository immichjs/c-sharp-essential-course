Console.WriteLine("Informe o numero para calcular a tabuada");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{number}.{i} = {number * i}");
    }
} else
{
    Console.WriteLine("Número inválido");
}
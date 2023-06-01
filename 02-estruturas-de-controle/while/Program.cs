int i = 1;
Console.WriteLine("Informe o número para calcular a tabuada");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine($"Tabuada do {number}");
    while (i <= 10)
    {
        Console.WriteLine($"{number} . {i} = {number * i}");
        i++;
    } 
}
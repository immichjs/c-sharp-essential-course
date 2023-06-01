Console.WriteLine("Informe o valor da compra");
double value = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o número de parcelas");
int installmentNumbers = Convert.ToInt32(Console.ReadLine()); 

switch(installmentNumbers)
{
    case 1:
        Console.WriteLine($"R$ {value} | {installmentNumbers} parcelas de R$ {value / installmentNumbers}");
        break;
    case 2:
        Console.WriteLine($"R$ {value} | {installmentNumbers} parcelas de R$ {value / installmentNumbers}");
        break;
    case 3:
        Console.WriteLine($"R$ {value} | {installmentNumbers} parcelas de R$ {value / installmentNumbers}");
        break;
}

Console.WriteLine("Informe um número");
int number = Convert.ToInt32(Console.ReadLine());

switch(number % 2)
{
    case 0:
        Console.WriteLine($"{number} é par");
        break;
    case 1:
        Console.WriteLine($"{number} é impar");
        break;
}
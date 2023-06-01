Console.WriteLine("Informe o Mês");
string month = Console.ReadLine().ToLower();

switch (month)
{
    case "janeiro":
    case "março":
    case "abril":
    case "maio":
    case "junho":
    case "julho":
    case "agosto":
    case "setembro":
    case "outubro":
    case "novembro":
    case "dezembro":
        Console.WriteLine($"{month.ToUpper()} possui 30/31 dias");
        break;
    case "fevereiro":
        Console.WriteLine($"{month.ToUpper()} possui 28 dias");
        break;
    default:
        Console.WriteLine("Mês inválido");
        break;
}
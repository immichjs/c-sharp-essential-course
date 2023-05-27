int positive = 1;
int result;

result = -positive;

Console.WriteLine(result);

Console.Write("Informe o número > ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo do número {number} é {-number}");

Console.Write("Informe a temperatura > ");
double temperature = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(temperature >= 40 ? "Quente" : "Frio");
bool c1 = 5 >= 7;
bool c2 = 5 <= 7;
bool c3 = 5 != 10;

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);

bool result = c1 && c2;
Console.WriteLine(result);
Console.WriteLine($"{c1} && {c2} = {result}");

result = c1 || c2;
Console.WriteLine(result);

Console.WriteLine($"{c1} || {c2} = {result}");
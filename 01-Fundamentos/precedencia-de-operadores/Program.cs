int x = 10 - 2 * 3;
Console.WriteLine(x);

x = (10 - 2) * 3;
Console.WriteLine(x);

bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(b);

b = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(b);

int f = 5, g = 6, h = 4;
int result = --f * g - ++h;
Console.WriteLine(result);
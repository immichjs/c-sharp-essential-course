int i = 1;

repeat:
Console.WriteLine($"i = {i}");

i++;

if (i <= 10)
{
    goto repeat;
}
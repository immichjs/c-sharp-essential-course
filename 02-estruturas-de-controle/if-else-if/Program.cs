
int note;

do
{
    Console.WriteLine("Informe a nota do aluno");
    note = Convert.ToInt32(Console.ReadLine());
} while (!(note >= 0 && note <= 10));

if (note >= 7)
{
    Console.WriteLine("Aprovado");
} else if (note >= 5 && note < 7)
{
    Console.WriteLine("Recuperação");
} else
{
    Console.WriteLine("Aprovado");
}
Console.WriteLine("Informe a nota do aluno");
int note = Convert.ToInt32(Console.ReadLine());

if (note >= 7)
{
    Console.WriteLine("Aprovado");
} else if (note >= 5 && note <= 7)
{
    Console.WriteLine("Recuperação");
} else if (note <= 7)
{
    Console.WriteLine("Reprovado");
}
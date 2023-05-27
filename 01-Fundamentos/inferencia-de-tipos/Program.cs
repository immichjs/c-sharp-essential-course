var age = 25;
var name = "Michel";
var salary = 2548.03;

Console.WriteLine($"{name} tem {age} anos e ganha R$ {salary} de salário.");

var car = new Carro();
car.MyMethod();

class Carro
{
    public void MyMethod()
    {
        Console.WriteLine("Meu método.");
    }
}
const int YEAR = 12;
const int MONTH = 11;
const int MONTH_YEAR = 12;
const int DAYS_YEAR = 365;
const float DAYS_FOR_MONTH = (float)DAYS_YEAR / (float)MONTH_YEAR;

Console.WriteLine(DAYS_FOR_MONTH);

double ray, perimeter, area;

Console.Write("Informe o raio do circulo > ");
ray = Convert.ToDouble(Console.ReadLine());

perimeter = 2 * Math.PI * ray;
area = Math.PI * Math.Pow(ray, 2);

Console.WriteLine($"Perímetro = {perimeter}");
Console.WriteLine($"Area = {area}");
DateTime now = DateTime.Now;

Console.WriteLine(now);
Console.WriteLine(now.Year);
Console.WriteLine(now.Month);
Console.WriteLine(now.Day);
Console.WriteLine(now.Hour);
Console.WriteLine(now.Minute);
Console.WriteLine(now.Second);
Console.WriteLine(now.Millisecond);

Console.WriteLine(now.AddDays(30));
Console.WriteLine(now.AddMonths(1));
Console.WriteLine(now.AddHours(2));
Console.WriteLine(now.AddHours(5));

Console.WriteLine(now.DayOfWeek);
Console.WriteLine(now.DayOfYear);

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());

Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());


using Getallen;

int dag = 3;

WeekDay day2 = WeekDay.Tuesday;
System.Console.WriteLine((WeekDay)dag);

WeekDay day3 = Enum.Parse<WeekDay>("Friday");
System.Console.WriteLine(day3);



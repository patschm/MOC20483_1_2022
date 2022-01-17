using System;

// TypeName varName;
int age = 42;
age += 5;
string name = "Jan";
DateTime birthDate = DateTime.Now.AddYears(-age);

Console.WriteLine($"My name = {name}, Born: {birthDate} ({++age} ago)");

double res = 5/(double)2;
Action<string> cc = Console.WriteLine;

cc("hoi");
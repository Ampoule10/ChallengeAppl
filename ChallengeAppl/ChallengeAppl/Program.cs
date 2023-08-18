using ChallengeAppl;

var employee = new Employee("Robert", "Lewandowski");
employee.AddGrade(7f);
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Wyniki dla: {employee.Name} {employee.Surname}:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");


using ChallengeAppl;

var employee = new Employee("Robert", "Lewandowski");
employee.AddGrade(7f);
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();
/*
Console.WriteLine($"Wyniki dla: {employee.Name} {employee.Surname}:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");
*/
Console.WriteLine($"GetStatisticsWithForEach");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Max: {statistics1.Max:N2}");
Console.WriteLine($"Min: {statistics1.Min:N2}");

Console.WriteLine($"GetStatisticsWithFor");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Max: {statistics2.Max:N2}");
Console.WriteLine($"Min: {statistics2.Min:N2}");

Console.WriteLine($"GetStatisticsWithDoWhile");
Console.WriteLine($"average: {statistics3.Average:N2}");
Console.WriteLine($"max: {statistics3.Max:N2}");
Console.WriteLine($"min: {statistics3.Min:N2}");


Console.WriteLine($"GetStatisticsWithWhile");
Console.WriteLine($"average: {statistics4.Average:N2}");
Console.WriteLine($"max: {statistics4.Max:N2}");
Console.WriteLine($"min: {statistics4.Min:N2}");


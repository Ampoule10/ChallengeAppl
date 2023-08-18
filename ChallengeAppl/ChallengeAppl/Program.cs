using ChallengeAppl;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników.");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    else if (input == "A" || input == "B" || input == "C" || input == "D" || input == "E")
    {
        var CharInput = Convert.ToChar(input);
        employee.AddGrade(CharInput);
    }
    else
    {
        employee.AddGrade(input);
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");





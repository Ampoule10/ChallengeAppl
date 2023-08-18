using ChallengeAppl;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników.");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee("Robert", "Lewandowski");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    {
        if (input == "A" || input == "B" || input == "C" || input == "D" || input == "E")
        {
            var CharInput = Convert.ToChar(input);
            employee.AddGrade(CharInput);
        }
        else
        {
            employee.AddGrade(input);
        }
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception cought: {e.Message}");
    }
   
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");





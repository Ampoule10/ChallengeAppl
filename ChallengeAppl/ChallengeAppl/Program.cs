using ChallengeAppl;

Employee employee1 = new Employee("Marcin", "Nowak", 21);
Employee employee2 = new Employee("Stefan", "Kowalski", 30);
Employee employee3 = new Employee("Marek", "Budzisz", 27);


employee1.AddScore(9);
employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(6);
employee1.AddScore(5);

employee2.AddScore(8);
employee2.AddScore(7);
employee2.AddScore(6);
employee2.AddScore(5);
employee2.AddScore(4);

employee3.AddScore(9);
employee3.AddScore(8);
employee3.AddScore(9);
employee3.AddScore(8);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
   employee1 ,employee2 , employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }

}
Console.WriteLine("Pracownik - " + employeeWithMaxResult.Name + " " + "" + employeeWithMaxResult.Surname + ", " + "" + (employeeWithMaxResult.Age + " lat, ") + "" + "uzyskał największą sumę ocen: " + "" + employeeWithMaxResult.Result);
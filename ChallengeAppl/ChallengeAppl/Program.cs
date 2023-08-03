using ChallengeAppl;

Employee employee1 = new Employee("Marcin", "Nowak", 21);
Employee employee2 = new Employee("Stefan", "Kowalski", 30);
Employee employee3 = new Employee("Marek", "Budzisz", 27);


employee1.Addscore(9);
employee1.Addscore(8);
employee1.Addscore(7);
employee1.Addscore(6);
employee1.Addscore(5);

employee2.Addscore(8);
employee2.Addscore(7);
employee2.Addscore(6);
employee2.Addscore(5);
employee2.Addscore(4);

employee3.Addscore(9);
employee3.Addscore(8);
employee3.Addscore(9);
employee3.Addscore(8);
employee3.Addscore(9);

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
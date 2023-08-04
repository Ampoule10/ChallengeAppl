namespace ChallengeAppl.Tests
{
    public class EmployeeTests
    {      

        [Test]
        public void WhenEmployeeCollectGrades_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Robert", "Lewandowski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var result = employee.GetStatistics();

            //assert
            Assert.That(result.Average, Is.EqualTo(3.33f).Within(0.01f));
            Assert.That(result.Min, Is.EqualTo(2));
            Assert.That(result.Max, Is.EqualTo(6));
        }  
    }
}




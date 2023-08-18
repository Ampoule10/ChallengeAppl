namespace ChallengeAppl.Tests
{
    public class EmployeeTests
    {      

        [Test]
        public void WhengetStatisticsCalled_ShouldReturnCorrectMax()
        {
            //arrange
            var employee = new Employee("Robert", "Lewandowski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistcs = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, statistcs.Max);        
        }

        [Test]
        public void WhengetStatisticsCalled_ShouldReturnCorrectMin()
        {
            //arrange
            var employee = new Employee("Robert", "Lewandowski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistcs = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistcs.Min);
        }

        [Test]
        public void WhengetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            //arrange
            var employee = new Employee("Robert", "Lewandowski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistcs = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round (3.33, 2), Math.Round(statistcs.Average, 2));
        }
    }
}




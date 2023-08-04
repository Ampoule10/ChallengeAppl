namespace ChallengeAppl.Tests
{
    public class Tests
    {

        [Test]
        public void WhenEmployee1ScoreSum_ShouldReturnCorrectResult()
        {
            //arrange
            var employee1 = new Employee("Marcin", "Nowak", 21);
            employee1.AddScore(6);
            employee1.AddScore(3);
            employee1.AddScore(-8);

            //act
            var result1 = employee1.Result;

            //assert
            Assert.AreEqual(1, result1);
        }
        [Test]

        public void WhenEmployee2ScoreSum_ShouldReturnCorrectResult()
        {
            //arrange
            var employee2 = new Employee("Stefan", "Kowalski", 30);
            employee2.AddScore(8);
            employee2.AddScore(5);
            employee2.AddScore(-8);

            //act
            var result2 = employee2.Result;

            //assert
            Assert.AreEqual(5, result2);

        }
        [Test]
        public void WhenEmployee3ScoreSum_ShouldReturnCorrectResult()
        {
            //arrange
            var employee3 = new Employee("Marek", "Budzisz", 27);
            employee3.AddScore(9);
            employee3.AddScore(5);
            employee3.AddScore(-2);

            //act
            var result3 = employee3.Result;

            //assert
            Assert.AreEqual(12, result3);
        }
    }
}
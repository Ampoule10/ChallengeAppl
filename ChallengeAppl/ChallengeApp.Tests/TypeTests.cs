namespace ChallengeAppl.Tests
{
    internal class TypeTests
    {
        //Dwa kolejne testy na typy wartościowe.
        [Test]
        public void NumbersShouldBeTheSame()
        {
            int number1 = 5;
            int number2 = 5;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void NumbersShouldBeDifferent()
        {
            float number3 = 4.75f;
            float number4 = 5.0f;

            Assert.AreNotEqual(number3, number4);
        }

        //Dwa kolejne testy na typy referencyjne.
        [Test]
        public void CountryNameShouldBeTheSame()
        {
            string country1 = "Polska";
            string country2 = "Polska";

            Assert.AreEqual(country1, country2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {         
            var employee1 = GetEmployee("Marcin");
            var employee2 = GetEmployee("Marcin");

            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee("Marcin","Nowak",21);
        }
    }
}

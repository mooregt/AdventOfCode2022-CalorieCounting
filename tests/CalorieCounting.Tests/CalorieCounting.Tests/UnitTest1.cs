using NUnit.Framework;
using CalorieCounting;

namespace CalorieCounting.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void GetCaloriesInput_GivenCalled_ShouldReturnStringArray()
        {
            // Arrange
            var caloriesRepo = new CaloriesRepository();

            // Act
            string[] result = caloriesRepo.GetCaloriesInput();

            // Assert
            Assert.IsInstanceOf<string[]>(result);
        }
    }
}

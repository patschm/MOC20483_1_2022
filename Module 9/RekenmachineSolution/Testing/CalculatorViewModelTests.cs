using Rekenmachine.ViewModels;
using Xunit;

namespace Testing
{
    public class CalculatorViewModelTests
    {
        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(100, 200, 300)]
        public void TestAdd(int a, int b, int r)
        {
            // Arrange
            CalculatorViewModel model = new CalculatorViewModel { A = a, B = b};
            int expectedResult = r;

            //Act
            model.AddCommand.Execute(null);

            Assert.Equal(expectedResult, model.Answer);

        }
    }
}
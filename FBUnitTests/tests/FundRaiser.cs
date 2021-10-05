using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class FundRaiser
    {
        public long CreateFundRaiser(long userId, FundRaiser fundRaiser)
        {
            // assume db connection classes
            // insert statement to create job per user
            // remember auth
            return 1L;
        }
        
    }
    [TestClass]
    public class FundRaiserTest
    {
        [TestMethod]
        public void CreateFundRaiserTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            FundRaiser fundRaiser = new FundRaiser();
                
            // Act - Invoke our method under test with the parameters.
            long actual = fundRaiser.CreateFundRaiser(1L, fundRaiser);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(1L, actual);
        }
    }
}
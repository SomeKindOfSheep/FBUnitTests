using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Page
    {
        public bool LikePage(long userId, Page page)
        {
            // assume db connection classes
            // insert statement to linking table person = photo
            // remember auth
            return true;
        }
        
        public long CreatePage(long userId, Page page)
        {
            // assume db connection classes
            // Delete statement to remove ID from linking table
            // remember auth
            return 1L;
        }
    }
    
    [TestClass]
    public class PageTest
    {
        [TestMethod]
        public void LikePageTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Page page = new Page();
                
            // Act - Invoke our method under test with the parameters.
            bool actual = page.LikePage(1L, page);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
        
        [TestMethod]
        public void CreatePageTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Page page = new Page();
                
            // Act - Invoke our method under test with the parameters.
            long actual = page.CreatePage(1L, page);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(1L, actual);
        }
    }
}
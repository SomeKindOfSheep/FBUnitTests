using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Search
    {
        public List<SearchResult> SearchPerson(long userId, string searchParam)
        {
            // assume db connection classes
            // Select statement with a like%
            // remember auth
            List<SearchResult> results = new List<SearchResult>();
            return results;
        }
    }
    
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void AddFriendTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Search search = new Search();
                
            // Act - Invoke our method under test with the parameters.
            List<SearchResult>  actual = search.SearchPerson(1L, "search");

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(0, actual.Count);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Auth
    {
        public string Login(string username, string password)
        {
            // assume db connection classes
            // select statement to hash + salt then compare 
            // return session token
            return "session-token";
        }
        
        // this would be logging out
        public bool EndSession(string sessionToken)
        {
            // assume db connection classes
            // delete statement to delete session token
            // return true if successful
            return true;
        }
    }

    [TestClass]
    public class AuthTest
    {
        
        [TestMethod]
        public void LoginTest()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Auth auth = new Auth();
                
            // Act - Invoke our method under test with the parameters.
            string actual = auth.Login("username", "plainTextpW");

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual("session-token", actual);
        }
        
        [TestMethod]
        public void EndSessionTest()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Auth auth = new Auth();
                
            // Act - Invoke our method under test with the parameters.
            bool actual = auth.EndSession("session-token");

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
        
    }
}
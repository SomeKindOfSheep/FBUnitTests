using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Friend
    {
        public bool AddFriend(long userId, long friendId)
        {
            // assume db connection classes
            // update statement to add friend
            // remember auth
            return true;
        }
        
        public bool RemoveFriend(long userId, long friendId)
        {
            // assume db connection classes
            // delete statement to delete link in table
            // remember auth
            return true;
        }
        
       
    }

    [TestClass]
    public class FriendTest
    {
        [TestMethod]
        public void AddFriendTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Friend friend = new Friend();
                
            // Act - Invoke our method under test with the parameters.
            bool actual = friend.AddFriend(1L, 2L);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
        
        [TestMethod]
        public void UnfriendTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Friend friend = new Friend();
                
            // Act - Invoke our method under test with the parameters.
            bool actual = friend.RemoveFriend(1L, 2L);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
    }
}
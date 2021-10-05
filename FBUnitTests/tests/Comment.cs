using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Comment
    {
        public bool DeleteComment(long userId, Comment comment)
        {
            // assume db connection classes
            // insert statement to date removed = now ()
            // remember auth
            return true;
        }
    }
    
    
    [TestClass]
    public class CommentTest
    {
        [TestMethod]
        public void DeleteCommentTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Comment comment = new Comment();
                
            // Act - Invoke our method under test with the parameters.
            bool actual = comment.DeleteComment(1L, comment);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
    }
}
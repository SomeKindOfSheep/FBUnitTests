using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Post
    {
        public long CreatePost(long userId, Post post)
        {
            // assume db connection classes
            // Insert statement to create post
            // remember auth
            // return new postId
            return 1L;
        }
        
        public bool SharePost(long userId, Post post)
        {
            // assume db connection classes
            // Update statement to add post to wall
            // remember auth
            // return boolean when share success
            return true;
        }
        
        public bool LikePost(long userId, Post post)
        {
            // assume db connection classes
            // Update to add userLike to post
            // remember auth
            // return boolean when like success
            return true;
        }
        
        public bool DeletePost(long userId, Post post)
        {
            // assume db connection classes
            // Update statement to change dateTo to now() where userId = post
            // remember auth
            // return boolean when delete is finalised
            return true;
        }
        
        public bool CommentOnPost(long userId, Post post)
        {
            // assume db connection classes
            // Update statement to add comment to post, comment would be part or at least linked to post
            // remember auth
            // return boolean when comment has been added
            return true;
        }
    }

    [TestClass]
    public class PostTest
    {
        
        [TestMethod]
        public void CreatePostTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            long userId = 1;
            Post post = new Post();
                
            // Act - Invoke our method under test with the parameters.
            long actual = post.CreatePost(userId, post);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(1L, actual);
        }
        
        [TestMethod]
        public void SharePostTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            long userId = 1;
            Post post = new Post();
                
            // Act - Invoke our method under test with the parameters.
            Boolean actual = post.SharePost(userId, post);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
        
        [TestMethod]
        public void DeletePostTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            long userId = 1;
            Post post = new Post();
                
            // Act - Invoke our method under test with the parameters.
            Boolean actual = post.DeletePost(userId, post);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
        
        [TestMethod]
        public void CommentOnPostTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            long userId = 1;
            Post post = new Post();
                
            // Act - Invoke our method under test with the parameters.
            Boolean actual = post.CommentOnPost(userId, post);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
    }
}
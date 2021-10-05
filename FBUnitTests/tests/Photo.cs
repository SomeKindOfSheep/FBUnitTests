using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Photo
    {
        public long TagPersonInPhoto(long userId, Photo photo)
        {
            // assume db connection classes
            // insert statement to linking table person = photo
            // remember auth
            return 1L;
        }
        
        public bool UnTagPersonFromPhoto(long userId, Photo photo)
        {
            // assume db connection classes
            // Delete statement to remove ID from linking table
            // remember auth
            return true;
        }
    }
    
    [TestClass]
    public class PhotoTest
    {
        [TestMethod]
        public void TagPersonInPhotoTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Photo photo = new Photo();
                
            // Act - Invoke our method under test with the parameters.
            long actual = photo.TagPersonInPhoto(1L, photo);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(1L, actual);
        }
        
        [TestMethod]
        public void UnTagPersonFromPhotoTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Photo photo = new Photo();
                
            // Act - Invoke our method under test with the parameters.
            bool actual = photo.UnTagPersonFromPhoto(1L, photo);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
    }
}
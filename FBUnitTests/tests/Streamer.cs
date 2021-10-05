using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Streamer
    {
        public bool Stream()
        {
            // this will some external streamer class
            // by external I mean internal library
            bool stillStreaming = true;

            return stillStreaming;
        }
    }

    [TestClass]
    public class StreamTest
    {
        [TestMethod]
        public void StillStreamingTest()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Streamer stream = new Streamer();

            // Act - Invoke our method under test with the parameters.
            bool actual = stream.Stream();

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(true, actual);
        }
        
    }
    
}
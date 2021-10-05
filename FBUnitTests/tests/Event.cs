using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Event
    {
        public long CreateEvent(long userId, Event room)
        {
            // assume db connection classes
            // insert statement to create event
            // remember auth
            return 1L;
        }
    }
    
    [TestClass]
    public class EventTest
    {
        [TestMethod]
        public void AddEventTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Event fbEvent = new Event();
                
            // Act - Invoke our method under test with the parameters.
            long actual = fbEvent.CreateEvent(1L, fbEvent);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(1L, actual);
        }
    }
}
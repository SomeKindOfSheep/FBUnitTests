using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Room
    {
        
        public long CreateRoom(long userId, Room room)
        {
            // assume db connection classes
            // insert statement to create room
            // remember auth
            return 1L;
        }

    }

    [TestClass]
    public class RoomTest
    {
        [TestMethod]
        public void AddRoomTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Room room = new Room();
                
            // Act - Invoke our method under test with the parameters.
            long actual = room.CreateRoom(1L, room);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(1L, actual);
        }
    }
}
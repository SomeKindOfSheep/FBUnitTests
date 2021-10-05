using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTesting.tests
{
    public class Job
    {
        public long CreateJob(long userId, Job job)
        {
            // assume db connection classes
            // insert statement to create job per user
            // remember auth
            return 1L;
        }
    }
    
    [TestClass]
    public class JobTest
    {
        [TestMethod]
        public void CreateJobTestMethod()
        {
            // Arrange - Initializes object and sets the value of the data
            // that is passed to the method under test.
            Job job = new Job();
                
            // Act - Invoke our method under test with the parameters.
            long actual = job.CreateJob(1L, job);

            // Assert - Verifies that the action of the method under test behaves as expected.
            Assert.AreEqual(1L, actual);
        }
    }
}
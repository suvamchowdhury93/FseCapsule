using Microsoft.VisualStudio.TestTools.UnitTesting;
using NBench;

namespace PerformanceTests
{
    [TestClass]
    public class TaskPerfTests
    {
        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,
        TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 5000)]
        public void PerformanceTests()
        {
            // Set up Prerequisites   
            var controller = new SPA_WebAPI.Controllers.TasksController();
            // Act on Test  
            var response = controller.ViewTask(4);
            // Assert the result  
            Assert.IsTrue(response != null);
        }
    }
}

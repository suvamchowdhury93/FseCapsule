using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SPA_DL;
using SPA_BL;

namespace SPA_WebAPI.Tests
{
    [TestClass]
    public class TaskManagerTests
    {
        [TestMethod]
        public void TestAddTask()
        {
            // Set up Prerequisites   
            var controller = new Controllers.TasksController();
            var task = new Task
            {
                Task_Name = "test",
                Parent_ID = null,
                Priority = 4,
                Start_Date = DateTime.Now
            };
            // Act on Test  
            var response = controller.AddTask(task);
            // Assert the result  
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void TestUpdateTask()
        {
            // Set up Prerequisites   
            var controller = new Controllers.TasksController();
            var task = new Task
            {
                Task_ID = 3,
                Task_Name = "test",
                Parent_ID = 2,
                Priority = 4,
                Start_Date = DateTime.Now
            };
            // Act on Test  
            var response = controller.UpdateTask(task);
            // Assert the result  
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void TestDeleteTask()
        {
            // Set up Prerequisites   
            var controller = new Controllers.TasksController();
            // Act on Test  
            var response = controller.DeleteTask(6);
            // Assert the result  
            Assert.IsTrue(response);
        }

        [TestMethod]
        public void TestViewTask()
        {
            // Set up Prerequisites   
            var controller = new Controllers.TasksController();
            // Act on Test  
            var response = controller.ViewTask(4);
            // Assert the result  
            Assert.IsTrue(response != null);
        }

        [TestMethod]
        public void TestViewTasks()
        {
            // Set up Prerequisites   
            var controller = new Controllers.TasksController();
            // Act on Test  
            var response = controller.ViewTasks(new SearchRequest
            {
                TaskName = "test"
            });
            // Assert the result  
            Assert.IsTrue(response != null);
        }

        [TestMethod]
        public void TestViewAllTasks()
        {
            // Set up Prerequisites   
            var controller = new Controllers.TasksController();
            // Act on Test  
            var response = controller.ViewAllTasks();
            // Assert the result  
            Assert.IsTrue(response != null && response.Count > 0);
        }
    }
}

using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using SPA_BL;
using SPA_DL;

namespace SPA_WebAPI.Controllers
{
    [RoutePrefix("tasks")]
    public class TasksController : ApiController
    {
        TaskRepository _taskRepo = new TaskRepository();

        [HttpGet, HttpPost]
        [Route("addtask")]
        public bool AddTask([FromBody]Task task)
        {
            return _taskRepo.AddTask(task);
        }

        [HttpGet, HttpPost]
        [Route("updatetask")]
        public bool UpdateTask([FromBody]Task task)
        {
            return _taskRepo.UpdateTask(task);
        }

        [HttpGet, HttpPost]
        [Route("deletetask/{taskId}")]
        public bool DeleteTask(long taskId)
        {
            return _taskRepo.DeleteTask(taskId);
        }

        [HttpGet, HttpPost]
        [Route("viewtask/{taskId}")]
        public Task ViewTask(long taskId)
        {
            return _taskRepo.ViewTask(taskId);
        }

        [HttpGet, HttpPost]
        [Route("viewtasks")]
        public List<TaskDetail> ViewTasks([FromBody]SearchRequest searchReq)
        {
            return _taskRepo.ViewTasks(searchReq);
        }

        [HttpGet, HttpPost]
        [Route("viewalltasks")]
        public List<TaskDetail> ViewAllTasks()
        {
            return _taskRepo.ViewAllTasks();
        }
    }
}

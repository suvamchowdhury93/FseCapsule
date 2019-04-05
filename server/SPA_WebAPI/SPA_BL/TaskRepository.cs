using System.Linq;
using System.Data;
using SPA_DL;
using System.Collections.Generic;

namespace SPA_BL
{
    public class TaskRepository
    {
        public bool AddTask(Task task)
        {
            bool isSaved = false;
            using (var taskManagerContext = new TASKMANAGEREntities())
            {
                taskManagerContext.Tasks.Add(task);
                taskManagerContext.SaveChanges();
                isSaved = true;
            }
            return isSaved;
        }

        public bool UpdateTask(Task task)
        {
            bool isUpdated = false;
            using (var taskManagerContext = new TASKMANAGEREntities())
            {
                var taskDtl = taskManagerContext.Tasks.Where(x => x.Task_ID == task.Task_ID).FirstOrDefault();
                taskDtl.Task_Name = task.Task_Name;
                taskDtl.Parent_ID = task.Parent_ID;
                taskDtl.Start_Date = task.Start_Date;
                taskDtl.End_Date = task.End_Date;
                taskDtl.Priority = task.Priority;
                taskManagerContext.SaveChanges();
                isUpdated = true;
            }
            return isUpdated;
        }

        public bool DeleteTask(long taskId)
        {
            bool isDeleted = false;
            using (var taskManagerContext = new TASKMANAGEREntities())
            {
                var taskDtl = taskManagerContext.Tasks.Where(x => x.Task_ID == taskId).FirstOrDefault();
                taskManagerContext.Tasks.Remove(taskDtl);
                taskManagerContext.SaveChanges();
                isDeleted = true;
            }
            return isDeleted;
        }

        public Task ViewTask(long taskId)
        {
            Task task = null;
            using (var taskManagerContext = new TASKMANAGEREntities())
            {
                task = taskManagerContext.Tasks.Where(x => x.Task_ID == taskId).FirstOrDefault();
            }
            return task;
        }

        public List<TaskDetail> ViewTasks(SearchRequest searchReq)
        {
            List<TaskDetail> tasks = null;
            using (var taskManagerContext = new TASKMANAGEREntities())
            {
                var taskList = (from task in taskManagerContext.Tasks
                                join parent in taskManagerContext.Tasks on task.Parent_ID equals parent.Task_ID into gj
                                from parenttask in gj.DefaultIfEmpty()
                                select new
                                {
                                    task.Task_ID,
                                    task.Task_Name,
                                    task.Priority,
                                    task.Parent_ID,
                                    task.Start_Date,
                                    task.End_Date,
                                    Parent_Task = (parenttask != null ? parenttask.Task_Name : string.Empty)
                                }).ToList();

                var list = taskList;

                if (searchReq != null)
                {
                    list = taskList.Where(x => x.Task_Name.Contains(searchReq.TaskName)
                        || (x.Priority >= searchReq.PriorityFrom && x.Priority <= searchReq.PriorityTo)
                        || x.Start_Date >= searchReq.StartDate
                        || x.End_Date <= searchReq.EndDate).ToList();
                }

                if (list != null)
                {
                    tasks = new List<TaskDetail>();
                    foreach (var item in list)
                    {
                        var tsk = new TaskDetail
                        {
                            Task_ID = item.Task_ID,
                            Task_Name = item.Task_Name,
                            Parent_ID = item.Parent_ID,
                            Parent_Task = item.Parent_Task,
                            Priority = item.Priority,
                            Start_Date = item.Start_Date,
                            End_Date = item.End_Date
                        };
                        tasks.Add(tsk);
                    }
                }
            }
            return tasks;
        }

        public List<TaskDetail> ViewAllTasks()
        {
            List<TaskDetail> tasklist = null;
            using (var taskManagerContext = new TASKMANAGEREntities())
            {
                var data = taskManagerContext.Tasks.ToList();
                var list = (from task in taskManagerContext.Tasks
                               join parent in taskManagerContext.Tasks on task.Parent_ID equals parent.Task_ID into gj
                               from parenttask in gj.DefaultIfEmpty()
                               select new
                               {
                                   task.Task_ID,
                                   task.Task_Name,
                                   task.Priority,
                                   task.Parent_ID,
                                   task.Start_Date,
                                   task.End_Date,
                                   Parent_Task = (parenttask != null ? parenttask.Task_Name : string.Empty)
                               }).ToList();

                if (list != null)
                {
                    tasklist = new List<TaskDetail>();
                    foreach (var item in list)
                    {
                        var tsk = new TaskDetail
                        {
                            Task_ID = item.Task_ID,
                            Task_Name = item.Task_Name,
                            Parent_ID = item.Parent_ID,
                            Parent_Task = item.Parent_Task,
                            Priority = item.Priority,
                            Start_Date = item.Start_Date,
                            End_Date = item.End_Date
                        };
                        tasklist.Add(tsk);
                    }
                }
            }
            return tasklist;
        }
    }
}
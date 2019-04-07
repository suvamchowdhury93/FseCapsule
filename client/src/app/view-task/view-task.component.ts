import { Component, OnInit } from '@angular/core';
import { TaskDetail } from 'src/app/task-detail';
import {Task } from 'src/app/task';
import { SearchRequest } from 'src/app/search-request';
import { TaskManagerService } from '../task-manager.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-view-task',
  templateUrl: './view-task.component.html',
  styleUrls: ['./view-task.component.css']
})
export class ViewTaskComponent implements OnInit {

  tasks : TaskDetail[];
  search : SearchRequest;

  constructor(private taskservice: TaskManagerService, private _router: Router) {
    this.search = new SearchRequest();
   }

  ngOnInit() {
      this.getTasks();  
  }

  getTasks() : void
  {
    this.taskservice.getTasksDetail().subscribe(res => this.tasks = res);
  }

  getFilterTasks() : void{
    this.taskservice.getTasks(this.search).subscribe(res => this.tasks = res);
  }

  onEditTask(taskid: number)
  {
     this._router.navigateByUrl("/edittask/" + taskid);
  }

  onEndTask(taskid: number)
  {
    
  }

  onSubmit()
  {
    this.tasks = this.tasks.filter(x => x.Parent_Task == this.search.ParentTask 
      || x.Task_Name == this.search.TaskName 
      || (x.Priority >=  this.search.PriorityFrom && x.Priority <= this.search.PriorityTo)
      || x.Start_Date == new Date(this.search.StartDate)
      || x.End_Date == new Date(this.search.EndDate));
  }

}

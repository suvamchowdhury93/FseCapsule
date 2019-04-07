import { Component, OnInit } from '@angular/core';
import { Task } from 'src/app/task';
import { TaskManagerService } from '../task-manager.service';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-edit-task',
  templateUrl: './edit-task.component.html',
  styleUrls: ['./edit-task.component.css']
})
export class EditTaskComponent implements OnInit {
  taskid: number;
  tasks: Task[];
  task: Task;

  constructor(private taskservice: TaskManagerService, private _active: ActivatedRoute) { 
        this._active.params.subscribe(k => this.taskid = k["taskid"]);
  }

  ngOnInit() {
    this.getTasks();
    this.task = this.tasks.find(x => x.Task_Id == this.taskid);
  }

  getTasks() : void
  {
    this.taskservice.getTasksDetail().subscribe(res => this.tasks = res);
  }
}

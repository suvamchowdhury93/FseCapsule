import { Component, OnInit } from '@angular/core';
import { Task } from 'src/app/task';
import { TaskManagerService } from '../task-manager.service';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent implements OnInit {

  task: Task;
  tasks: Task[];
  
  constructor(private taskservice: TaskManagerService) { 
    this.task = new Task(); 
    this.task.Parent_Id = 0;

    this.getTasks();     
  }

  ngOnInit() {    
    
  }

  getTasks() : void
  {
    this.taskservice.getTasksDetail().subscribe(res => this.tasks = res);
  }
}

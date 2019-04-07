import { Injectable } from '@angular/core';
import { Task } from './task';
import { TaskDetail } from './task-detail';
import { TASKS } from './mock-tasks';
import { TASKSDETAIL } from './mock-tasksdetail';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { SearchRequest } from './search-request';

@Injectable({
  providedIn: 'root'
})

export class TaskManagerService {
  
  tasks : Task[];

  constructor(private http : HttpClient) { }

  getTasks(search : SearchRequest): Observable<any> {    
    return this.http.post('http://localhost:8020/tasks/viewtasks/', JSON.stringify(search));
  }

  getTasksDetail(): Observable<any> {
    return this.http.get('http://localhost:8020/tasks/viewalltasks/');
  }

  updateTask(task: Task) : boolean{
    return true;
  }

  addTask(task : Task) : boolean{
    return true;
  }

  deleteTask(taskid: number) : boolean
  {
      return true;
  }

}

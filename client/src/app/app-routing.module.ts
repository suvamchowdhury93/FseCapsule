import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { AddTaskComponent } from 'src/app/add-task/add-task.component';
import { ViewTaskComponent } from 'src/app/view-task/view-task.component';
import { EditTaskComponent } from 'src/app/edit-task/edit-task.component';

const routes: Routes = [
  { path: '', redirectTo: '/addtask', pathMatch: 'full' },
  { path: 'addtask', component: AddTaskComponent },
  { path: 'viewtask', component: ViewTaskComponent },
  { path: 'edittask/:taskid', component: EditTaskComponent }  
];

@NgModule({
  imports:[RouterModule.forRoot(routes)],
  exports:[RouterModule]
})
export class AppRoutingModule { }

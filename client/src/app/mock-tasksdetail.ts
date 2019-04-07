import { TaskDetail } from './task-detail';

export const TASKSDETAIL: TaskDetail[] = [
    {Task_Id: 1, Task_Name: 'test', Parent_Id: null, Parent_Task: null, Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null},
    {Task_Id: 2, Task_Name: 'test', Parent_Id: 1, Parent_Task: "test", Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null},
    {Task_Id: 3, Task_Name: 'test', Parent_Id: 2, Parent_Task: "test", Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null},
    {Task_Id: 4, Task_Name: 'test', Parent_Id: 3, Parent_Task: "test", Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null},
    {Task_Id: 5, Task_Name: 'test', Parent_Id: 4, Parent_Task: "test", Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null}
];

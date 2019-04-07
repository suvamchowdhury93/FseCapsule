import { Task } from './task';

export const TASKS: Task[] = [
    {Task_Id: 1, Task_Name: 'test', Parent_Id: null, Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null},
    {Task_Id: 2, Task_Name: 'test', Parent_Id: 1, Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null},
    {Task_Id: 3, Task_Name: 'test', Parent_Id: 2, Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null},
    {Task_Id: 4, Task_Name: 'test', Parent_Id: 3, Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null},
    {Task_Id: 5, Task_Name: 'test', Parent_Id: 4, Priority: 10, 
    Start_Date: new Date('2019-01-27'), End_Date: null}
];

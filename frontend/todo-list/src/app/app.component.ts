import { Component } from '@angular/core';
import { discardPeriodicTasks } from '@angular/core/testing';
import { NgForm } from '@angular/forms';
import {Task} from './item/ITask'
// import { count } from 'console';
// import { takeLast } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  showCompletedTasks: boolean = true;
  show(): void{
    if (this.showCompletedTasks){
      this.showCompletedTasks = false;
    } else {
      this.showCompletedTasks = true;
    }
  }
  
  tasks:Array<Task> = [
    {id: 1, name: "Проснуться в 6:00"}, 
    {id: 2, name: "Позавтракать"},
    {id: 3, name: "Умыться"}
  ]

  completedTasks: Array<Task> =[];

  taskId = this.tasks.length + 1;
  addTask(myForm:NgForm):void {
    this.tasks.push({id: this.taskId, name: myForm.value.task});
    this.taskId++;
  }

  onDelete(id:number): void {
    this.tasks = this.tasks.filter(task => task.id != id)
  }
 
  onComplete(id:number):void {
    let completedIndex = this.tasks.findIndex(task => task.id == id);
    this.completedTasks.push(this.tasks[completedIndex]);
    this.tasks = this.tasks.filter(task => task.id != id);
  }
}
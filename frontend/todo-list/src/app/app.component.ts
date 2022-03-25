import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  name: string = "Fedya";
  showName: boolean = true;
 
  applesNumber:number =10;
  addApple(): void {
    this.applesNumber++;
  }
  
  tasks:Array<string> = [
   "go to cinema", "go to shop"
  ]
  addTask(myForm:NgForm):void {
     this.tasks.push(myForm.value.task);
  }
  onDelete(text:string): void {
    this.tasks = this.tasks.filter(task => task != text)
  }  
}

export interface task{
  id: number;
  name: string;
}
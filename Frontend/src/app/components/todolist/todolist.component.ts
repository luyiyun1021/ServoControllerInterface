import { Component, OnInit } from '@angular/core';

//引入服务
import { StorageService } from '../../services/storage.service';

@Component({
  selector: 'app-todolist',
  templateUrl: './todolist.component.html',
  styleUrls: ['./todolist.component.scss']
})
export class TodolistComponent implements OnInit {

  public keyword:string;

  public todolist:any[]=[];

  constructor(public storage:StorageService) { }

  ngOnInit(): void {

    var todolist:any=this.storage.get('todolist');
    if(todolist)
    {
      this.todolist=todolist;
    }

  }

  doAdd(e){

    if(e.keyCode==13){
       
        
        if(!this.todolistHasKeyword(this.todolist,this.keyword)){
            this.todolist.push({
              title:this.keyword,
              status:0                   //0表示代办事项  1表示已完成事项
            });

            this.keyword='';
            this.storage.set('todolist',this.todolist);

        }else{

          alert('数据已经存在');
          this.keyword='';
        }
     }
    
  }

  deleteData(key){

    this.todolist.splice(key,1);

    this.storage.set('todolist',this.todolist);
  }

  //如果数组里面有keyword返回true  否则返回false
  todolistHasKeyword(todolist:any,keyword:any){


    //异步  会存在问题
    // todolist.forEach(value => {

    //   if(value.title==keyword){

    //       return true;
    //   } 
    // });

    if(!keyword) return false;

    for(var i=0;i<todolist.length;i++){
      if(todolist[i].title==keyword){

          return true;
      } 
    }
    return false;

  }

  checkboxChage(){


    console.log('事件触发了');

    this.storage.set('todolist',this.todolist); 
  }



}

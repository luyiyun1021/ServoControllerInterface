import { Component, OnInit } from '@angular/core';
import * as internal from 'stream';
import { HeaderComponent } from '../header/header.component';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.scss']
})
export class NewsComponent implements OnInit {

  public msg:string='我是新闻组件绑定数据';

  public userinfo:object={
      username:"张三",
      age:20

  }


   items:any[]=[1,2,3,4,5];   //定义数组

  constructor() { }

  ngOnInit(): void {
  }

}

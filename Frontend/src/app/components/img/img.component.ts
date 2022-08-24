import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-img',
  templateUrl: './img.component.html',
  styleUrls: ['./img.component.scss']
})
export class ImgComponent implements OnInit {

  public list:any[]=[
    {"title":'我是新闻1'},
    {"title":'我是新闻2'},
    {"title":'我是新闻3'}
  ]
  
  constructor() { }

  ngOnInit(): void {
  }

}

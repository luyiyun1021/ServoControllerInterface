import { Component, OnInit } from '@angular/core';
import { ElectronService } from '../../core/services';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  msg: string

  constructor(private electronService: ElectronService) { }

  ngOnInit(): void {
  }

  sendMsg() {
    console.log("sendMsg")
    this.electronService.ipcRenderer.send("toMain", "this is ng Client")
  }
  readFile() {
    var msg = this.electronService.fs.readFileSync("D:/electron-angular/angular-electron-demo01/package.json")
    this.msg = msg.toString()
  }


}

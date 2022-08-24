import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';
import { MsgList } from '../module/message/components/msgtable/MsgList';
import { MsgtableComponent } from '../module/message/components/msgtable/msgtable.component';

@Injectable({
  providedIn: 'root'
})

export class SignalrService {
  public data: Array<MsgList> = new Array<MsgList>();
  invisibleMsgs: Set<string> = new Set<string>(); // newly added
  // public data: MsgList[];
  public dtOptions: DataTables.Settings = {};

  private hubConnection: signalR.HubConnection
    public startConnection = () => {
      this.hubConnection = new signalR.HubConnectionBuilder()
                              .withUrl('https://localhost:7194/myHub')
                              .build();
      this.hubConnection
        .start()
        .then(() => console.log('Connection started!'))
        .catch(err => console.log('Error while starting connection: ' + err));
    }

    public addTransferTableDataListener = () => {
      this.hubConnection.on('transfertabledata',
      // (data) => {
      //   this.data = new Array<MsgList>();
      //   data.forEach(element => {
      //     const msg = new MsgList(cnt, element.name, element.sensorNo, element.time, element.objectType, element.address);
      //     cnt++;
      //     this.data.push(msg);
      //   });
      //   this.data = data;});
      //   console.log(this.data);
      (response) => {
        let cnt = 0;
        this.data = new Array<MsgList>();
        response.forEach(element => {
          const msg: MsgList = new MsgList(cnt, element.name, element.sensorNo, element.time, element.objectType, element.address);
          const key = `${element.sensorNo}_${element.address}`;
          console.log(this.invisibleMsgs);
          if (this.invisibleMsgs.has(key)) {
            msg.visibility = false;
          }
          cnt++;
          this.data.push(msg);
        });
        console.log(this.data);
      });
    };
}

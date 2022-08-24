import { Component, OnDestroy, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { elementAt, Subject } from 'rxjs';
import { ErrorMessage, MsgList, Status } from './MsgList';
import { SignalrService } from '../../../../services/signalr.service';
import { format } from 'path';

@Component({
  selector: 'app-msgtable',
  templateUrl: './msgtable.component.html',
  styleUrls: ['./msgtable.component.scss']
})

export class MsgtableComponent implements OnInit, OnDestroy {

  dtOptions: DataTables.Settings = {};
  // msglists: Array<MsgList> = new Array<MsgList>();
  status: Status = Status.defined;
  selectedItem: number = null;

  dtTrigger: Subject<any> = new Subject<any>();

  // constructor(private httpClient: HttpClient) { }
  constructor(private httpClient: HttpClient, public signalRService: SignalrService) { }

  getErrorMessages(){
    this.signalRService.startConnection();
    this.signalRService.addTransferTableDataListener();
    this.startHttpRequest();
  }


  seeDefinedMsgs() {
    this.status = Status.defined;
    console.log('Set status to defined');
  }

  seeCurrentMsgs() {
    this.status = Status.current;
    console.log('Set status to current');
  }

  seeBlockedMsgs() {
    this.status = Status.blocked;
    console.log('Set status to blocked');
  }

  setHighlight(id: number) {
    this.selectedItem = id;
  }

  reverseVisibility() {
    if (this.selectedItem == null) { return; }
    console.log(`Change visibility of ${this.selectedItem}`);
    const msg = this.signalRService.data[this.selectedItem];
    const key = `${msg.sensorNo}_${msg.address}`;
    if (msg.visibility) {
      this.signalRService.invisibleMsgs.add(key);
    } else {
      this.signalRService.invisibleMsgs.delete(key);
    }
    this.signalRService.data[this.selectedItem].reverseVisibility();
    this.selectedItem = null;
  }

  ngOnDestroy(): void {
    // Do not forget to unsubscribe the event
    this.dtTrigger.unsubscribe();
  }


  ngOnInit(): void {
    // this.msglists = [];

    this.dtOptions = {
        pagingType: 'full_numbers',
        pageLength: 2,
      };

    this.getErrorMessages();
  }

  private startHttpRequest = () => {
    this.httpClient.get<any>('https://localhost:7194/api/Panel')
      .subscribe(
        (response: Array<ErrorMessage>) => {
          // TODO : uncomment this when end to end connection is done.
          // this.msglists = new Array<MsgList>();
          // response.forEach(element => {
          //   const msg: MsgList = new MsgList(cnt, element.name, element.sensorNo, element.time, element.objectType, element.address);
          //   const key = `${element.sensorNo}_${element.address}`;
          //   if (this.invisibleMsgs.has(key)) {
          //     msg.visibility = false;
          //   }
          //   cnt++;
          //   this.msglists.push(msg);
          // });
          // console.log(this.msglists);
          // Calling the DT trigger to manually render the table
          this.dtTrigger.next(null);
          console.log(response);
        }
      );
  };

}


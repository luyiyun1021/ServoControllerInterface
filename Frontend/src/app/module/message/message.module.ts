import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MessageRoutingModule } from './message-routing.module';
import { MessageComponent } from './message.component';
import { MsgtableComponent } from './components/msgtable/msgtable.component';
import { DataTablesModule } from 'angular-datatables';


@NgModule({
  declarations: [
    MessageComponent,
    MsgtableComponent
  ],
  imports: [
    CommonModule,
    MessageRoutingModule,
    DataTablesModule
  ]
})
export class MessageModule { }

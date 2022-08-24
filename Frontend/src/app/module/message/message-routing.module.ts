import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { MessageComponent } from './message.component';
import { MsgtableComponent } from './components/msgtable/msgtable.component';

const routes: Routes = [
  {
    path: '', component:MessageComponent,
  children:[
    { path: 'Message_Msgtable', component: MsgtableComponent },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MessageRoutingModule { }

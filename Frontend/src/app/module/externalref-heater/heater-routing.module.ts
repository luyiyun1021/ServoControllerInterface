import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FineturningheaterComponent } from './components/fineturningheater/fineturningheater.component';
import { HeaterComponent } from './heater.component';


const routes: Routes = [

  { 
    path: '', component:HeaterComponent,

    children:[
    { path: 'heater_Fineturningheater', component:FineturningheaterComponent},

  ]
},

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HeaterRoutingModule { }

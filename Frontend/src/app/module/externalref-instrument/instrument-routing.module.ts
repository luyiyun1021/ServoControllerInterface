import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { InstrumentComponent } from './instrument.component';
import { StatetableComponent } from './components/statetable/statetable.component';
import { ShapingtableComponent } from './components/shapingtable/shapingtable.component';
import { ServoComponent } from './components/servo/servo.component';

const routes: Routes = [

  { path: '', component:InstrumentComponent,
  children:[
    
    { path: 'Instrument_Statetable', component:StatetableComponent},
    { path: 'Instrument_Shapingtable', component:ShapingtableComponent},
    { path: 'Instrument_Servo', component:ServoComponent},
  
  ]
},


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InstrumentRoutingModule { }

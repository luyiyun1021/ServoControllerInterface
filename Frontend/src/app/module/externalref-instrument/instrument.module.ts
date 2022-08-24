import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InstrumentRoutingModule } from './instrument-routing.module';
import { InstrumentComponent } from './instrument.component';
import { StatetableComponent } from './components/statetable/statetable.component';
import { ShapingtableComponent } from './components/shapingtable/shapingtable.component';
import { ServoComponent } from './components/servo/servo.component';


@NgModule({
  declarations: [
    InstrumentComponent,
    StatetableComponent,
    ShapingtableComponent,
    ServoComponent
  ],
  imports: [
    CommonModule,
    InstrumentRoutingModule
  ]
})
export class InstrumentModule { }

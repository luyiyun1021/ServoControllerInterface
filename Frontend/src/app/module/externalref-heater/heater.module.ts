import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HeaterRoutingModule } from './heater-routing.module';
import { HeaterComponent } from './heater.component';
import { FineturningheaterComponent } from './components/fineturningheater/fineturningheater.component';


@NgModule({
  declarations: [
    HeaterComponent,
    FineturningheaterComponent
  ],
  imports: [
    CommonModule,
    HeaterRoutingModule
  ]
})
export class HeaterModule { }

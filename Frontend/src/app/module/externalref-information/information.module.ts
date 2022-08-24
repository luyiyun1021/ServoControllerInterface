import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InformationRoutingModule } from './information-routing.module';
import { InformationComponent } from './information.component';
import { AlarmmessgeComponent } from './components/alarmmessge/alarmmessge.component';
import { InformationlistComponent } from './components/informationlist/informationlist.component';


@NgModule({
  declarations: [
    InformationComponent,
    AlarmmessgeComponent,
    InformationlistComponent
  ],
  imports: [
    CommonModule,
    InformationRoutingModule
  ]
})
export class InformationModule { }

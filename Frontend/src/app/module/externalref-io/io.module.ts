import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { IORoutingModule } from './io-routing.module';
import { IoComponent } from './io.component';

import { PageioComponent } from './components/pageio/pageio.component';
import { EthercattopologyhostComponent } from './components/ethercattopologyhost/ethercattopologyhost.component';
import { IomoniorComponent } from './components/iomonior/iomonior.component';


@NgModule({
  declarations: [
    IoComponent,
  
    PageioComponent,
    EthercattopologyhostComponent,
    IomoniorComponent
  ],
  imports: [
    CommonModule,
    IORoutingModule
  ]
})
export class IOModule { } /* 向外界暴露组件 */

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { IoComponent } from './io.component';
import { PageioComponent } from './components/pageio/pageio.component';
import { EthercattopologyhostComponent } from './components/ethercattopologyhost/ethercattopologyhost.component';
import { IomoniorComponent } from './components/iomonior/iomonior.component';

const routes: Routes = [
  { 
    path: '', component:IoComponent,
    children:[
    
    { path: 'io_pageio', component:PageioComponent},
    { path: 'io_ethercattopologyhost', component:EthercattopologyhostComponent},
    { path: 'io_iomonitor', component:IomoniorComponent},
  ]
},

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class IORoutingModule { }

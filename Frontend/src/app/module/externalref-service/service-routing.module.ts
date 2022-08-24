import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ServiceComponent } from './service.component';
import { SelectorComponent } from './components/selector/selector.component';

const routes: Routes = [

  { path: '', component:ServiceComponent,
  children:[
    
    { path: 'service_Selector', component:SelectorComponent},
  
  ]
},


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ServiceRoutingModule { }

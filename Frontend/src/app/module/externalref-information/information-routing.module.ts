import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { InformationComponent } from './information.component';
import { AlarmmessgeComponent } from './components/alarmmessge/alarmmessge.component';
import { InformationlistComponent } from './components/informationlist/informationlist.component';

const routes: Routes = [

  { path: '', component:InformationComponent,
    children:[
      
      { path: 'information_Alarmmessge', component:AlarmmessgeComponent},
      { path: 'information_Informationlist', component:InformationlistComponent},

     
    ]
  },


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InformationRoutingModule { }

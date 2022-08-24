import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { MenuComponent } from './menu.component';
import { LoginoperationComponent } from './components/loginoperation/loginoperation.component';
import { ParameterlistComponent } from './components/parameterlist/parameterlist.component';
import { SchedulesettingComponent } from './components/schedulesetting/schedulesetting.component';
import { BranddatabaseComponent } from './components/branddatabase/branddatabase.component';

const routes: Routes = [

  { path: '', component:MenuComponent,
    children:[
      
      { path: 'menu_loginoperation', component:LoginoperationComponent},
      { path: 'menu_parameterlist', component:ParameterlistComponent},
      { path: 'menu_schedulesetting', component:SchedulesettingComponent},
      { path: 'menu_branddatabase', component:BranddatabaseComponent},
     
    ]
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MenuRoutingModule { }

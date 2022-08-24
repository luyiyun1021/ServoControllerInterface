import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserComponent } from './user.component';
import { ProfileComponent } from './components/profile/profile.component';
import { OrderComponent } from './components/order/order.component';

const routes: Routes = [

  { path: '', component:UserComponent,
    children:[
      { path: 'profile', component:ProfileComponent},
      { path: 'order', component:OrderComponent},

      { path: '', redirectTo:'profile'},
    ]
  },
  
  { path: 'user',redirectTo: 'user'},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }

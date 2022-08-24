import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {StorageService} from '../../services/storage.service'; /*引入公共服务*/
import { MenuRoutingModule } from './menu-routing.module';
import { MenuComponent } from './menu.component';
import { LoginoperationComponent } from './components/loginoperation/loginoperation.component';
import { ParameterlistComponent } from './components/parameterlist/parameterlist.component';
import { SchedulesettingComponent } from './components/schedulesetting/schedulesetting.component';
import { BranddatabaseComponent } from './components/branddatabase/branddatabase.component';


@NgModule({
  declarations: [
    MenuComponent,
    LoginoperationComponent,
    ParameterlistComponent,
    SchedulesettingComponent,
    BranddatabaseComponent
  ],
  imports: [
    CommonModule,
    MenuRoutingModule
  ]
})
export class MenuModule { } /* 向外界暴露组件 */

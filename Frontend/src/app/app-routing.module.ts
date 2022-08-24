import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { NewsComponent } from './components/news/news.component';
import { HeaderComponent } from './components/header/header.component';
import { FormComponent } from './components/form/form.component';
import { SearchComponent } from './components/search/search.component';
import { TodolistComponent } from './components/todolist/todolist.component';
import { MachineComponent } from './components/machine/machine.component';


const routes: Routes = [

  /* 程序总路由结构 */
  { path: '',redirectTo: 'home',pathMatch: 'full'},
  { path: 'home', component:HomeComponent},
  { path: 'news', component:NewsComponent},
  { path: 'header', component:HeaderComponent},
  { path: 'form', component:FormComponent},

  { path: 'search', component:SearchComponent},
  
  // ruiyiw 
  { path: 'message', 
    loadChildren:()=>import('./module/message/message.module').then(m=>m.MessageModule)
  },

  { 
    path: 'user', 
    loadChildren:()=>import('./module/user/user.module').then(m=>m.UserModule)
  },

  { 
    /* Meu子模块 懒加载 HMI*/
    path: 'menu', 
    loadChildren:()=>import('./module/externalref-menu/menu.module').then(m=>m.MenuModule)
  },

  { 
    /* io子模块 懒加载 HMI*/
    path: 'io', 
    loadChildren:()=>import('./module/externalref-io/io.module').then(m=>m.IOModule)
  },

  { 
    /* heater子模块 懒加载 HMI*/
    path: 'heater', 
    loadChildren:()=>import('./module/externalref-heater/heater.module').then(m=>m.HeaterModule)
  },

  { 
    /* heater子模块 懒加载 HMI*/
    path: 'information', 
    loadChildren:()=>import('./module/externalref-information/information.module').then(m=>m.InformationModule)
  },

  { 
    /* heater子模块 懒加载 HMI*/
    path: 'statistics', 
    loadChildren:()=>import('./module/externalref-statistics/statistics.module').then(m=>m.StatisticsModule)
  },

  { 
    /* heater子模块 懒加载 HMI*/
    path: 'instrument', 
    loadChildren:()=>import('./module/externalref-instrument/instrument.module').then(m=>m.InstrumentModule)
  },

  { 
    /* heater子模块 懒加载 HMI*/
    path: 'service', 
    loadChildren:()=>import('./module/externalref-service/service.module').then(m=>m.ServiceModule)
  },

  /* https://segmentfault.com/q/1010000017439226 辅助路由 */

  /* { path: 'regionmac', component:MachineComponent}, */

   /* 运行有问题 */
   { path: 'regionmac',component:MachineComponent,outlet:'region_machines'},
   { path: 'todolist',component:TodolistComponent,outlet:'region_machines'},
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' }),   
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }

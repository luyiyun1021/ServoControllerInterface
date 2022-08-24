import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


import { StatisticsComponent } from './statistics.component';
import { CounterComponent } from './components/counter/counter.component';
import { CountermonitoringComponent } from './components/countermonitoring/countermonitoring.component';
import { DowntimeanalysisComponent } from './components/downtimeanalysis/downtimeanalysis.component';
import { DowntimehistorystatisticComponent } from './components/downtimehistorystatistic/downtimehistorystatistic.component';
import { MachineperformancestatisticsComponent } from './components/machineperformancestatistics/machineperformancestatistics.component';


const routes: Routes = [

  { path: '', component:StatisticsComponent,
  children:[
    
    { path: 'statistic_Counter', component:CounterComponent},
    { path: 'statistic_Countermonitoring', component:CountermonitoringComponent},
    { path: 'statistic_Downtimeanalysis', component:DowntimeanalysisComponent},
    { path: 'statistic_Downtimehistorystatistic', component:DowntimehistorystatisticComponent},
    { path: 'statistic_Machineperformancestatistics', component:MachineperformancestatisticsComponent},
  
  ]
},



];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StatisticsRoutingModule { }

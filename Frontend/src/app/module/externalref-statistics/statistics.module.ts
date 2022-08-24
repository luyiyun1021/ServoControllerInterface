import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StatisticsRoutingModule } from './statistics-routing.module';

import { StatisticsComponent } from './statistics.component';
import { CounterComponent } from './components/counter/counter.component';
import { CountermonitoringComponent } from './components/countermonitoring/countermonitoring.component';
import { DowntimeanalysisComponent } from './components/downtimeanalysis/downtimeanalysis.component';
import { DowntimehistorystatisticComponent } from './components/downtimehistorystatistic/downtimehistorystatistic.component';
import { MachineperformancestatisticsComponent } from './components/machineperformancestatistics/machineperformancestatistics.component';


@NgModule({
  declarations: [
    StatisticsComponent,
    CounterComponent,
    CountermonitoringComponent,
    DowntimeanalysisComponent,
    DowntimehistorystatisticComponent,
    MachineperformancestatisticsComponent
  ],
  imports: [
    CommonModule,
    StatisticsRoutingModule
  ]
})
export class StatisticsModule { }

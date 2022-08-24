import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MachineperformancestatisticsComponent } from './machineperformancestatistics.component';

describe('MachineperformancestatisticsComponent', () => {
  let component: MachineperformancestatisticsComponent;
  let fixture: ComponentFixture<MachineperformancestatisticsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MachineperformancestatisticsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MachineperformancestatisticsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

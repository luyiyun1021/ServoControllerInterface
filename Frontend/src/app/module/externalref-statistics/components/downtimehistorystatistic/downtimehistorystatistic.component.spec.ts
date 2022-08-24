import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DowntimehistorystatisticComponent } from './downtimehistorystatistic.component';

describe('DowntimehistorystatisticComponent', () => {
  let component: DowntimehistorystatisticComponent;
  let fixture: ComponentFixture<DowntimehistorystatisticComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DowntimehistorystatisticComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DowntimehistorystatisticComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SchedulesettingComponent } from './schedulesetting.component';

describe('SchedulesettingComponent', () => {
  let component: SchedulesettingComponent;
  let fixture: ComponentFixture<SchedulesettingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SchedulesettingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SchedulesettingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

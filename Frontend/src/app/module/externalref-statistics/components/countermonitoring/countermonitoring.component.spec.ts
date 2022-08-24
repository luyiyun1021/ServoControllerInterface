import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CountermonitoringComponent } from './countermonitoring.component';

describe('CountermonitoringComponent', () => {
  let component: CountermonitoringComponent;
  let fixture: ComponentFixture<CountermonitoringComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CountermonitoringComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CountermonitoringComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

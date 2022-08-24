import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaterComponent } from './heater.component';

describe('HeaterComponent', () => {
  let component: HeaterComponent;
  let fixture: ComponentFixture<HeaterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HeaterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HeaterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServoComponent } from './servo.component';

describe('ServoComponent', () => {
  let component: ServoComponent;
  let fixture: ComponentFixture<ServoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ServoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ServoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

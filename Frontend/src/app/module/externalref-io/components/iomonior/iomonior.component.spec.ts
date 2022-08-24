import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IomoniorComponent } from './iomonior.component';

describe('IomoniorComponent', () => {
  let component: IomoniorComponent;
  let fixture: ComponentFixture<IomoniorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IomoniorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(IomoniorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

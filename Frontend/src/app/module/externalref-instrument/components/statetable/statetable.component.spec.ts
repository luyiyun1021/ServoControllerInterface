import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StatetableComponent } from './statetable.component';

describe('StatetableComponent', () => {
  let component: StatetableComponent;
  let fixture: ComponentFixture<StatetableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StatetableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StatetableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FineturningheaterComponent } from './fineturningheater.component';

describe('FineturningheaterComponent', () => {
  let component: FineturningheaterComponent;
  let fixture: ComponentFixture<FineturningheaterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FineturningheaterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FineturningheaterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

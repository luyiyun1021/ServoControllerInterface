import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BranddatabaseComponent } from './branddatabase.component';

describe('BranddatabaseComponent', () => {
  let component: BranddatabaseComponent;
  let fixture: ComponentFixture<BranddatabaseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BranddatabaseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BranddatabaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

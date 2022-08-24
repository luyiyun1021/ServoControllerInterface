import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShapingtableComponent } from './shapingtable.component';

describe('ShapingtableComponent', () => {
  let component: ShapingtableComponent;
  let fixture: ComponentFixture<ShapingtableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShapingtableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShapingtableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

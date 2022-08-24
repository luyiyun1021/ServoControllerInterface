import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MsgtableComponent } from './msgtable.component';

describe('MsgtableComponent', () => {
  let component: MsgtableComponent;
  let fixture: ComponentFixture<MsgtableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MsgtableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MsgtableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PinfoComponent } from './pinfo.component';

describe('PinfoComponent', () => {
  let component: PinfoComponent;
  let fixture: ComponentFixture<PinfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PinfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PinfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

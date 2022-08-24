import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EthercattopologyhostComponent } from './ethercattopologyhost.component';

describe('EthercattopologyhostComponent', () => {
  let component: EthercattopologyhostComponent;
  let fixture: ComponentFixture<EthercattopologyhostComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EthercattopologyhostComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EthercattopologyhostComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

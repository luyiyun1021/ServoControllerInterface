import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InformationlistComponent } from './informationlist.component';

describe('InformationlistComponent', () => {
  let component: InformationlistComponent;
  let fixture: ComponentFixture<InformationlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InformationlistComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InformationlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

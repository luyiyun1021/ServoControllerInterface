import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DowntimeanalysisComponent } from './downtimeanalysis.component';

describe('DowntimeanalysisComponent', () => {
  let component: DowntimeanalysisComponent;
  let fixture: ComponentFixture<DowntimeanalysisComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DowntimeanalysisComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DowntimeanalysisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

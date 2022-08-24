import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PageioComponent } from './pageio.component';

describe('PageioComponent', () => {
  let component: PageioComponent;
  let fixture: ComponentFixture<PageioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PageioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PageioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

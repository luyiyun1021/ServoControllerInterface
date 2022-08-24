import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AlarmmessgeComponent } from './alarmmessge.component';

describe('AlarmmessgeComponent', () => {
  let component: AlarmmessgeComponent;
  let fixture: ComponentFixture<AlarmmessgeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AlarmmessgeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AlarmmessgeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

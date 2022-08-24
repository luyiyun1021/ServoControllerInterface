import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginoperationComponent } from './loginoperation.component';

describe('LoginoperationComponent', () => {
  let component: LoginoperationComponent;
  let fixture: ComponentFixture<LoginoperationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoginoperationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginoperationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearClinicaComponent } from './crear-clinica.component';

describe('CrearClinicaComponent', () => {
  let component: CrearClinicaComponent;
  let fixture: ComponentFixture<CrearClinicaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrearClinicaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrearClinicaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

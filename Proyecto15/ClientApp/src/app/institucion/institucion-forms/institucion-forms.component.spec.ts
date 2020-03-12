import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InstitucionFormsComponent } from './institucion-forms.component';

describe('InstitucionFormsComponent', () => {
  let component: InstitucionFormsComponent;
  let fixture: ComponentFixture<InstitucionFormsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InstitucionFormsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InstitucionFormsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

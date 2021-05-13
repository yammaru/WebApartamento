import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ApartamentoModificacionComponent } from './apartamento-modificacion.component';

describe('ApartamentoModificacionComponent', () => {
  let component: ApartamentoModificacionComponent;
  let fixture: ComponentFixture<ApartamentoModificacionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ApartamentoModificacionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ApartamentoModificacionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

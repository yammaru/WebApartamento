import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MovimientoConsultaComponent } from './movimiento-consulta.component';

describe('MovimientoConsultaComponent', () => {
  let component: MovimientoConsultaComponent;
  let fixture: ComponentFixture<MovimientoConsultaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MovimientoConsultaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MovimientoConsultaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

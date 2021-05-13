import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MovimientoModificacionComponent } from './movimiento-modificacion.component';

describe('MovimientoModificacionComponent', () => {
  let component: MovimientoModificacionComponent;
  let fixture: ComponentFixture<MovimientoModificacionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MovimientoModificacionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MovimientoModificacionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

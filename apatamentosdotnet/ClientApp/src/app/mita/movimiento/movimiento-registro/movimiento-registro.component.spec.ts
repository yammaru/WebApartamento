import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MovimientoRegistroComponent } from './movimiento-registro.component';

describe('MovimientoRegistroComponent', () => {
  let component: MovimientoRegistroComponent;
  let fixture: ComponentFixture<MovimientoRegistroComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MovimientoRegistroComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MovimientoRegistroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

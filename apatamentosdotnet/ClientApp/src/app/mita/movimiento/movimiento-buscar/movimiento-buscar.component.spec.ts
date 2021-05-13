import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MovimientoBuscarComponent } from './movimiento-buscar.component';

describe('MovimientoBuscarComponent', () => {
  let component: MovimientoBuscarComponent;
  let fixture: ComponentFixture<MovimientoBuscarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MovimientoBuscarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MovimientoBuscarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

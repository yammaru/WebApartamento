import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApartamentoConsultaComponent } from './apartamento-consulta.component';

describe('ApartamentoConsultaComponent', () => {
  let component: ApartamentoConsultaComponent;
  let fixture: ComponentFixture<ApartamentoConsultaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApartamentoConsultaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApartamentoConsultaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

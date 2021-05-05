import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApartamentoRegistroComponent } from './apartamento-registro.component';

describe('ApartamentoRegistroComponent', () => {
  let component: ApartamentoRegistroComponent;
  let fixture: ComponentFixture<ApartamentoRegistroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApartamentoRegistroComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApartamentoRegistroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

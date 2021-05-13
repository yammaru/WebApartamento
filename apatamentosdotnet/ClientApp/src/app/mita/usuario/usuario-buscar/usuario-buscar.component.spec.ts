import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsuarioBuscarComponent } from './usuario-buscar.component';

describe('UsuarioBuscarComponent', () => {
  let component: UsuarioBuscarComponent;
  let fixture: ComponentFixture<UsuarioBuscarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsuarioBuscarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsuarioBuscarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

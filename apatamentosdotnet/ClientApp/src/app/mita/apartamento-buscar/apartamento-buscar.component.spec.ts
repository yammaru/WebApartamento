import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ApartamentoBuscarComponent } from './apartamento-buscar.component';

describe('ApartamentoBuscarComponent', () => {
  let component: ApartamentoBuscarComponent;
  let fixture: ComponentFixture<ApartamentoBuscarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ApartamentoBuscarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ApartamentoBuscarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

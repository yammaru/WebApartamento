import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ArriendoBuscarComponent } from './arriendo-buscar.component';

describe('ArriendoBuscarComponent', () => {
  let component: ArriendoBuscarComponent;
  let fixture: ComponentFixture<ArriendoBuscarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ArriendoBuscarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ArriendoBuscarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

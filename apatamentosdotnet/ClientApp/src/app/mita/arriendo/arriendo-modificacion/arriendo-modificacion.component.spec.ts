import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ArriendoModificacionComponent } from './arriendo-modificacion.component';

describe('ArriendoModificacionComponent', () => {
  let component: ArriendoModificacionComponent;
  let fixture: ComponentFixture<ArriendoModificacionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ArriendoModificacionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ArriendoModificacionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

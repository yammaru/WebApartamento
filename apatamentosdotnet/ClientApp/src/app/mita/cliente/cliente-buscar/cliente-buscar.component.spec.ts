import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ClienteBuscarComponent } from './cliente-buscar.component';

describe('ClienteBuscarComponent', () => {
  let component: ClienteBuscarComponent;
  let fixture: ComponentFixture<ClienteBuscarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ClienteBuscarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ClienteBuscarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

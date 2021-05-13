import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AppRoutingModule } from './app-routing.module';
import { FiltroPersonaPipe } from './pipe/filtro-persona.pipe';
import { LoginComponent } from './login/login.component';
import { JwtInterceptor } from './services/jwt-interceptor';
import { AlertModalComponent } from './@base/alert-modal/alert-modal.component';
import { NgbModal, NgbModule, } from '@ng-bootstrap/ng-bootstrap';
import { ApartamentoConsultaComponent } from './mita/apartamento-consulta/apartamento-consulta.component';
import { ApartamentoRegistroComponent } from './mita/apartamento-registro/apartamento-registro.component';
import { ApartamentoModificacionComponent } from './mita/apartamento-modificacion/apartamento-modificacion.component';
import { ApartamentoBuscarComponent } from './mita/apartamento-buscar/apartamento-buscar.component';
import { ArriendoBuscarComponent } from './mita/arriendo/arriendo-buscar/arriendo-buscar.component';
import { ArriendoConsultaComponent } from './mita/arriendo/arriendo-consulta/arriendo-consulta.component';
import { ArriendoRegistroComponent } from './mita/arriendo/arriendo-registro/arriendo-registro.component';
import { ArriendoModificacionComponent } from './mita/arriendo/arriendo-modificacion/arriendo-modificacion.component';
import { MovimientoModificacionComponent } from './mita/movimiento/movimiento-modificacion/movimiento-modificacion.component';
import { MovimientoRegistroComponent } from './mita/movimiento/movimiento-registro/movimiento-registro.component';
import { MovimientoBuscarComponent } from './mita/movimiento/movimiento-buscar/movimiento-buscar.component';
import { MovimientoConsultaComponent } from './mita/movimiento/movimiento-consulta/movimiento-consulta.component';
import { UsuarioConsultaComponent } from './mita/usuario/usuario-consulta/usuario-consulta.component';
import { UsuarioModificarComponent } from './mita/usuario/usuario-modificar/usuario-modificar.component';
import { UsuarioRegistroComponent } from './mita/usuario/usuario-registro/usuario-registro.component';
import { UsuarioBuscarComponent } from './mita/usuario/usuario-buscar/usuario-buscar.component';
import { ClienteBuscarComponent } from './mita/cliente/cliente-buscar/cliente-buscar.component';
import { ClienteConsultarComponent } from './mita/cliente/cliente-consultar/cliente-consultar.component';
import { ClienteModificarComponent } from './mita/cliente/cliente-modificar/cliente-modificar.component';
import { ClienteRegistroComponent } from './mita/cliente/cliente-registro/cliente-registro.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ApartamentoConsultaComponent,
  ApartamentoRegistroComponent,
    FiltroPersonaPipe, LoginComponent, AlertModalComponent, ApartamentoModificacionComponent, ApartamentoBuscarComponent, ArriendoBuscarComponent, ArriendoConsultaComponent, ArriendoRegistroComponent, ArriendoModificacionComponent, MovimientoModificacionComponent, MovimientoRegistroComponent, MovimientoBuscarComponent, MovimientoConsultaComponent, UsuarioConsultaComponent, UsuarioModificarComponent, UsuarioRegistroComponent, UsuarioBuscarComponent, ClienteBuscarComponent, ClienteConsultarComponent, ClienteModificarComponent, ClienteRegistroComponent
  ],
  imports: [
    ReactiveFormsModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'counter', component: CounterComponent },
    { path: 'fetch-data', component: FetchDataComponent },
], { relativeLinkResolution: 'legacy' }),
    AppRoutingModule,NgbModule
  ],
  entryComponents:[AlertModalComponent],
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }],
  bootstrap: [AppComponent]
})
export class AppModule { }

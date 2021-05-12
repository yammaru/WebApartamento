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


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ApartamentoConsultaComponent,
  ApartamentoRegistroComponent,
    FiltroPersonaPipe, LoginComponent, AlertModalComponent
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

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ApartamentoConsultaComponent } from './mita/apartamento-consulta/apartamento-consulta.component';
import { ApartamentoRegistroComponent } from './mita/apartamento-registro/apartamento-registro.component';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './services/auth.guard';

const routes: Routes = [
  { path: 'apartamentoregistro', component: ApartamentoRegistroComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent },
  { path: 'consulta', component: ApartamentoConsultaComponent }
];
@NgModule({
  declarations: [],
  imports: [
    CommonModule, RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }

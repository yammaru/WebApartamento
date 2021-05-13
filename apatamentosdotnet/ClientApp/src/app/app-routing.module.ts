import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ApartamentoConsultaComponent } from './mita/apartamento-consulta/apartamento-consulta.component';
import { ApartamentoRegistroComponent } from './mita/apartamento-registro/apartamento-registro.component';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './services/auth.guard';
import { MovimientoRegistroComponent } from './mita/movimiento/movimiento-registro/movimiento-registro.component';
import { ArriendoRegistroComponent } from './mita/arriendo/arriendo-registro/arriendo-registro.component';
import { ClienteRegistroComponent } from './mita/cliente/cliente-registro/cliente-registro.component';
import { UsuarioRegistroComponent } from './mita/usuario/usuario-registro/usuario-registro.component';
import { MovimientoConsultaComponent } from './mita/movimiento/movimiento-consulta/movimiento-consulta.component';
import { ArriendoConsultaComponent } from './mita/arriendo/arriendo-consulta/arriendo-consulta.component';
import { UsuarioConsultaComponent } from './mita/usuario/usuario-consulta/usuario-consulta.component';
import { ClienteConsultarComponent } from './mita/cliente/cliente-consultar/cliente-consultar.component';
import { ApartamentoBuscarComponent } from './mita/apartamento-buscar/apartamento-buscar.component';
import { ArriendoBuscarComponent } from './mita/arriendo/arriendo-buscar/arriendo-buscar.component';
import { ClienteBuscarComponent } from './mita/cliente/cliente-buscar/cliente-buscar.component';
import { UsuarioBuscarComponent } from './mita/usuario/usuario-buscar/usuario-buscar.component';
import { MovimientoBuscarComponent } from './mita/movimiento/movimiento-buscar/movimiento-buscar.component';
import { ArriendoModificacionComponent } from './mita/arriendo/arriendo-modificacion/arriendo-modificacion.component';
import { ApartamentoModificacionComponent } from './mita/apartamento-modificacion/apartamento-modificacion.component';
import { ClienteModificarComponent } from './mita/cliente/cliente-modificar/cliente-modificar.component';
import { UsuarioModificarComponent } from './mita/usuario/usuario-modificar/usuario-modificar.component';
import { MovimientoModificacionComponent } from './mita/movimiento/movimiento-modificacion/movimiento-modificacion.component';

const routes: Routes = [
  { path: 'apartamentoregistro', component: ApartamentoRegistroComponent, canActivate: [AuthGuard] },
  { path: 'registroApartamento', component: ApartamentoRegistroComponent },
  { path: 'buscarApartamento', component: ApartamentoBuscarComponent},
  { path: 'consultaApartamento', component: ApartamentoConsultaComponent },
  { path: 'buscarApartamento', component: ApartamentoModificacionComponent},
  { path: 'registroMovimiento', component: MovimientoRegistroComponent},
  { path: 'consultaMovimiento', component: MovimientoConsultaComponent},
  { path: 'modificarMovimiento', component: MovimientoModificacionComponent},
  { path: 'buscarMovimiento', component: MovimientoBuscarComponent},
  { path: 'registro', component:ArriendoRegistroComponent},
  { path: 'consulta', component: ArriendoConsultaComponent},
  { path: 'buscar', component: ArriendoBuscarComponent},
  { path: 'modificar', component: ArriendoModificacionComponent},
  { path: 'registroUsuario', component: UsuarioRegistroComponent},
  { path: 'consultaUsuario', component: UsuarioConsultaComponent},
  { path: 'buscarUsuario', component: UsuarioBuscarComponent},
  { path: 'buscarUsuario', component: UsuarioModificarComponent},
  { path: 'consultaCliente', component: ClienteConsultarComponent},
  { path: 'registroCliente', component: ClienteRegistroComponent},
  { path: 'buscarCliente', component: ClienteBuscarComponent},
  { path: 'modificarCliente', component: ClienteModificarComponent},
  { path: 'login', component: LoginComponent }
];
@NgModule({
  declarations: [],
  imports: [
    CommonModule, RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }

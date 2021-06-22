import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { catchError, tap } from 'rxjs/operators';
import { Observable, of } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Usuario } from '../mita/models/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {

    this.baseUrl = baseUrl;
  }
  post(usuario: Usuario): Observable<Usuario> {
    return this.http.post<Usuario>(this.baseUrl + 'api/Usuario', usuario)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Usuario>('Registrar Usuario', null))
      );
  }
  buscar(id: string): Observable<Usuario> {
    return this.http.get<Usuario>(this.baseUrl + 'api/Usuario/'+id)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Usuario>('Encontrar Usuario', null))
      );
  }
  get(): Observable<Usuario[]> {
    return this.http.get<Usuario[]>(this.baseUrl + 'api/Usuario')
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Usuario[]>('Consulta Usuario', null))
      );
  }
  Eliminar(id:string): Observable<Usuario[]> {
    return this.http.delete<Usuario[]>(this.baseUrl + 'api/Usuario/'+id)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Usuario[]>('Consulta Usuario', null))
      );
  }
}

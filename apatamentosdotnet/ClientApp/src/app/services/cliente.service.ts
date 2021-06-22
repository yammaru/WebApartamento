import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { catchError,tap } from 'rxjs/operators';
import { Observable,of } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Cliente } from '../mita/models/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  baseUrl: string;
  constructor(
  private http: HttpClient,
  @Inject('BASE_URL') baseUrl: string,
  private handleErrorService: HandleHttpErrorService)
  { 
  this.baseUrl = baseUrl;
  }
  
  post(cliente: Cliente): Observable<Cliente> {
    return this.http.post<Cliente>(this.baseUrl + 'api/Cliente',cliente)
    .pipe(
    tap(_ => this.handleErrorService.log('datos enviados')),
    catchError(this.handleErrorService.handleError<Cliente>('Registrar Cliente', null))
    );
    }
    buscar(id:string):Observable<Cliente> {
      return this.http.post<Cliente>(this.baseUrl + 'api/Cliente/5', id)
      .pipe(
      tap(_ => this.handleErrorService.log('datos enviados')),
      catchError(this.handleErrorService.handleError<Cliente>('Encontrar Cliente', null))
      );
    }
    get(): Observable<Cliente[]> {
      return this.http.get<Cliente[]>(this.baseUrl + 'api/Cliente')
      .pipe(
      tap(_ => this.handleErrorService.log('datos enviados')),
      catchError(this.handleErrorService.handleError<Cliente[]>('Consulta Cliente', null))
      );
      }
     
}

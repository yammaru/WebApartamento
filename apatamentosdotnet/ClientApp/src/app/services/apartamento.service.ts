import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { catchError,tap } from 'rxjs/operators';
import { Observable,of } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Apartamento } from '../mita/models/apartamento';

@Injectable({
  providedIn: 'root'
})
export class ApartamentoService {


  baseUrl: string;
  constructor(
  private http: HttpClient,
  @Inject('BASE_URL') baseUrl: string,
  private handleErrorService: HandleHttpErrorService)
  {
  this.baseUrl = baseUrl;
  }
  
  post(persona: Apartamento): Observable<Apartamento> {
    return this.http.post<Apartamento>(this.baseUrl + 'api/Apartamento', persona)
    .pipe(
    tap(_ => this.handleErrorService.log('datos enviados')),
    catchError(this.handleErrorService.handleError<Apartamento>('Registrar Apartamento', null))
    );
    }
    buscar(id:string):Observable<Apartamento> {
      return this.http.get<Apartamento>(this.baseUrl + 'api/Apartamento/5'+ id)
      .pipe(
      tap(_ => this.handleErrorService.log('datos enviados')),
      catchError(this.handleErrorService.handleError<Apartamento>('Encontrar Apartamento', null))
      );
    }
    get(): Observable<Apartamento[]> {
      return this.http.get<Apartamento[]>(this.baseUrl + 'api/Apartamento')
      .pipe(
      tap(_ => this.handleErrorService.log('datos enviados')),
      catchError(this.handleErrorService.handleError<Apartamento[]>('Consulta Apartamento', null))
      );
      }
}



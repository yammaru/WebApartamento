  import { HttpClient } from '@angular/common/http';
  import { Inject, Injectable } from '@angular/core';
  import { catchError,tap } from 'rxjs/operators';
  import { Observable,of } from 'rxjs';
  import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Movimiento, MovimientoReponse } from '../mita/models/movimiento';

  
  @Injectable({
    providedIn: 'root'
  })

  export class MovimientoService {
  
    baseUrl: string;
    constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService)
    { 
      
    this.baseUrl = baseUrl;
    }
    ganancia(): Observable<Movimiento[]> {
      return this.http.get<Movimiento[]>(this.baseUrl + 'api/totalizar')
      .pipe(
      tap(_ => this.handleErrorService.log('datos enviados')),
      catchError(this.handleErrorService.handleError<Movimiento[]>('Consulta Movimiento', null))
      );
      }
    post(movimiento: Movimiento): Observable<Movimiento> {
      return this.http.post<Movimiento>(this.baseUrl + 'api/Movimiento',movimiento)
      .pipe(
      tap(_ => this.handleErrorService.log('datos enviados')),
      catchError(this.handleErrorService.handleError<Movimiento>('Registrar Movimiento', null))
      );
      }
      buscar(id:string):Observable<Movimiento> {
        return this.http.post<Movimiento>(this.baseUrl + 'api/Movimiento/5', id)
        .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Movimiento>('Encontrar Movimiento', null))
        );
      }
    get(): Observable<MovimientoReponse> {
        return this.http.get<MovimientoReponse>(this.baseUrl + 'api/Movimiento')
        .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<MovimientoReponse>('Consulta Movimiento', null))
        );
        }
  }
  
  

import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { catchError, tap } from 'rxjs/operators';
import { Observable, of } from 'rxjs';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Apartamento } from '../mita/models/apartamento';
import { Arriendo } from '../mita/models/arriendo';

@Injectable({
  providedIn: 'root'
})
export class ArriendoService {


  baseUrl: string;
  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }

  post(arriendo: Arriendo): Observable<Arriendo> {
    return this.http.post<Arriendo>(this.baseUrl + 'api/Arriendo', arriendo)
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Arriendo>('Registrar Arriendo', null))
      );
  }
  get(): Observable<Arriendo[]> {
    return this.http.get<Arriendo[]>(this.baseUrl + 'api/Arriendo')
      .pipe(
        tap(_ => this.handleErrorService.log('datos enviados')),
        catchError(this.handleErrorService.handleError<Arriendo[]>('Consulta Arriendo', null))
      );
  }
}


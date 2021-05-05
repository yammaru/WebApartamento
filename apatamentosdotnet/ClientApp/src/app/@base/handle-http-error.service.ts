import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { of } from 'rxjs/internal/observable/of';

@Injectable({
  providedIn: 'root'
})
export class HandleHttpErrorService {
  [x: string]: any;

  constructor() { }
  public handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      if (error.status == "500") {
        this.mostrarError500(error);
        }
        else if (error.status == "400") {
        this.mostrarError400(error);
        }
        else if (error.status == "401") {
        this.mostrarError(error);
        }
    console.error(error);
    return of(result as T);
    };
    }
    public log(message: string) {}
}
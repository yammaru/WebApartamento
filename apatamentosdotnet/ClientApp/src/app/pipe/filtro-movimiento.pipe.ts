import { Pipe, PipeTransform } from '@angular/core';
import { Movimiento } from '../mita/models/movimiento';

@Pipe({
  name: 'filtroMovimiento'
})
export class FiltroMovimientoPipe implements PipeTransform {

  transform(movimiento: Movimiento[], searchText: string): any {
    if (searchText == null) return movimiento;
    return movimiento.filter(p => p.IdMovimiento.toLowerCase().indexOf(searchText.toLowerCase()) !== -1
    );
  }

}

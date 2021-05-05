import { Pipe, PipeTransform } from '@angular/core';
import { Arriendo } from '../mita/models/arriendo';

@Pipe({
  name: 'filtroPersona'
})
export class FiltroPersonaPipe implements PipeTransform {


  transform(arriendo: Arriendo[], searchText: string): any {
    if (searchText == null) return arriendo;
    return arriendo.filter(p => p.idArriendo.toLowerCase().indexOf(searchText.toLowerCase()) !== -1
    );
  }

}

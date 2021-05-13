import { Pipe, PipeTransform } from '@angular/core';
import { Apartamento } from '../mita/models/apartamento';

@Pipe({
  name: 'filtroApartamento'
})
export class FiltroApartamentoPipe implements PipeTransform {

  transform(apartamento: Apartamento[], searchText: string): any {
    if (searchText == null) return apartamento;
    return apartamento.filter(p => p.idApartamento.toLowerCase().indexOf(searchText.toLowerCase()) !== -1
    );
  }
}

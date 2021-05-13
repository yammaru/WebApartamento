import { Pipe, PipeTransform } from '@angular/core';
import { Cliente } from '../mita/models/cliente';

@Pipe({
  name: 'filtroCliente'
})
export class FiltroClientePipe implements PipeTransform {

  transform(cliente: Cliente[], searchText: string): any {
    if (searchText == null) return cliente;
    return cliente.filter(p => p.idCliente.toLowerCase().indexOf(searchText.toLowerCase()) !== -1
    );
  }

}

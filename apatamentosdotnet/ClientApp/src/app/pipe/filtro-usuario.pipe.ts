import { Pipe, PipeTransform } from '@angular/core';
import { Usuario } from '../mita/models/usuario';

@Pipe({
  name: 'filtroUsuario'
})
export class FiltroUsuarioPipe implements PipeTransform {


  transform(usuario: Usuario[], searchText: string): any {
    if (searchText == null) return usuario;
    return usuario.filter(p => p.IdUsuario.toLowerCase().indexOf(searchText.toLowerCase()) !== -1
    );
  }

}

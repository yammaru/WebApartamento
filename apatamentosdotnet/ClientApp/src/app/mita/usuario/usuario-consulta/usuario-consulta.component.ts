import { Component, OnInit } from '@angular/core';
import { UsuarioService } from 'src/app/services/usuario.service';
import { Usuario } from '../../models/usuario';

@Component({
  selector: 'app-usuario-consulta',
  templateUrl: './usuario-consulta.component.html',
  styleUrls: ['./usuario-consulta.component.css']
})
export class UsuarioConsultaComponent implements OnInit {
  usuarios: Usuario[];

  constructor(private usuarioService: UsuarioService) { }

  ngOnInit():void {
    this.usuarioService.get().subscribe(result => {
      this.usuarios = result;

    });
  }

}


import { Component, OnInit } from '@angular/core';
import { ArriendoService } from 'src/app/services/arriendo.service';
import { Arriendo } from '../../models/arriendo';

@Component({
  selector: 'app-arriendo-consulta',
  templateUrl: './arriendo-consulta.component.html',
  styleUrls: ['./arriendo-consulta.component.css']
})
export class ArriendoConsultaComponent implements OnInit {
  arriendos: Arriendo[];
  searchText: string;
  arriendo:Arriendo;
  constructor(private arriendoService: ArriendoService) { }

  ngOnInit() {
    this.arriendoService.get().subscribe(result => {
      this.arriendos = result;  });
  }

}

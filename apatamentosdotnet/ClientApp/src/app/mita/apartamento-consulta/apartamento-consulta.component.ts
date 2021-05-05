import { Component, OnInit } from '@angular/core';
import { ApartamentoService } from 'src/app/services/apartamento.service';
import { Apartamento } from '../models/apartamento';

@Component({
  selector: 'app-apartamento-consulta',
  templateUrl: './apartamento-consulta.component.html',
  styleUrls: ['./apartamento-consulta.component.css']
})
export class ApartamentoConsultaComponent implements OnInit {
  personas: Apartamento[];
  

  constructor(private personaService: ApartamentoService) { }

  ngOnInit(): void {
    this.personaService.get().subscribe(result => {
      this.personas = result;
      });
  }

}

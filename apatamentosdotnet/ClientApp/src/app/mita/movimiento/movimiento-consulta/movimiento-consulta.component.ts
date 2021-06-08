import { Component, OnInit } from '@angular/core';
import { MovimientoService } from 'src/app/services/movimiento.service';
import { Movimiento } from '../../models/movimiento';

@Component({
  selector: 'app-movimiento-consulta',
  templateUrl: './movimiento-consulta.component.html',
  styleUrls: ['./movimiento-consulta.component.css']
})
export class MovimientoConsultaComponent implements OnInit {
  movimientos: Movimiento[];

  constructor(private moviminetoService: MovimientoService) { }

  ngOnInit() { this.moviminetoService.get().subscribe(result => {
    this.movimientos = result.movimientos;
    
    });
  }

}

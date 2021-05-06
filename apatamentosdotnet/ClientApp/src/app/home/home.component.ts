import { Component, OnInit } from '@angular/core';
import { Movimiento } from '../mita/models/movimiento';
import { MovimientoService } from '../services/movimiento.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  movimientos: Movimiento[];
  constructor(private moviminetoService: MovimientoService) { }
  ngOnInit(): void {
    this.moviminetoService.get().subscribe(result => {
      this.movimientos = result;
      });
  }
}

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MovimientoService } from 'src/app/services/movimiento.service';
import { Movimiento } from '../../models/movimiento';

@Component({
  selector: 'app-movimiento-registro',
  templateUrl: './movimiento-registro.component.html',
  styleUrls: ['./movimiento-registro.component.css']
})
export class MovimientoRegistroComponent implements OnInit {
 movimiento: Movimiento;
  formGroup: FormGroup;

  constructor(private movimientoService: MovimientoService,private formBuilder: FormBuilder) { }
   ngOnInit() {
    this.movimiento=new Movimiento();
        this.buildForm();
      }
   
    private buildForm() {
      this.movimiento=new Movimiento();
      this.movimiento.IdMovimiento='';
      this.movimiento.Detalle='';
      this.movimiento.IdUsuario='';
      this.movimiento.Fecha;
      this.movimiento.valor=0;
       

          this.formGroup = this.formBuilder.group({
        idMovimiento: [this.movimiento.IdMovimiento, Validators.required],
        detalle: [ this.movimiento.Detalle, Validators.required],
        idUsuario: [this.movimiento.IdUsuario,Validators.required],
        fecha:[this.movimiento.Fecha,Validators.required],
        valor:[this.movimiento.valor,Validators.required]
            });
        }
      get control() { 
        return this.formGroup.controls;
         }
        
        onSubmit() {
              if (this.formGroup.invalid) {
                return;
              }
              this.add();
            }
          
  add() {
    this.movimiento = this.formGroup.value;

    this.movimientoService.post(this.movimiento).subscribe(p => {
      if (p != null) {
        alert('Registro Completado!');
        this.movimiento = p;
      }
    });

  }


}

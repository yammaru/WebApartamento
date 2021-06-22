import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MovimientoService } from 'src/app/services/movimiento.service';
import { Movimiento } from '../../models/movimiento';
import {NgbDateStruct} from '@ng-bootstrap/ng-bootstrap';

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
      this.movimiento.idMovimiento='';
      this.movimiento.detalle='';
      this.movimiento.idUsuario='';
      this.movimiento.fecha;
      this.movimiento.valor=0;
       

          this.formGroup = this.formBuilder.group({
        idMovimiento: [this.movimiento.idMovimiento, Validators.required],
        detalle: [ this.movimiento.detalle, Validators.required],
        idUsuario: [this.movimiento.idUsuario,Validators.required],
        fecha:[this.movimiento.fecha,Validators.required],
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
      }else{alert("nooooooooo")}
    });

  }


}

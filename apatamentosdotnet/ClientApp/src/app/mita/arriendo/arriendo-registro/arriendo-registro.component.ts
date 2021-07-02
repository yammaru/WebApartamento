import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ArriendoService } from 'src/app/services/arriendo.service';
import { Apartamento } from '../../models/apartamento';
import { Arriendo } from '../../models/arriendo';
import { ApartamentoService } from 'src/app/services/apartamento.service';
import { Movimiento } from '../../models/movimiento';
import { Cliente } from '../../models/cliente';
@Component({
  selector: 'app-arriendo-registro',
  templateUrl: './arriendo-registro.component.html',
  styleUrls: ['./arriendo-registro.component.css']
})
export class ArriendoRegistroComponent implements OnInit {
  mita: Arriendo;
  formGroup: FormGroup;
  apartamento: Apartamento;
  mapartamento: Apartamento;
  apartamentos: Apartamento[];

  movimiento: Movimiento;
  cliente: Cliente;
  k:Number;
  constructor(private arriendoService: ArriendoService, private apartamentoService: ApartamentoService, private formBuilder: FormBuilder) { }
  ngOnInit() {
    this.mita = new Arriendo();
    this.buildForm(); this.busca();
  }
  busca() {
    this.apartamentoService.get().subscribe(result => {
      this.apartamentos = result;
    });
  }
  onChangeCustomer(){
   this.onChange();
  }
  onChange() {
    let idCustomer =this.control.idCliente.value;
    if (idCustomer==null){
    idCustomer=0;
    }
    let apartamento = this.control.idApartamento.value;
    this.apartamentoService.buscar(apartamento).subscribe(result => { 
      this.mapartamento = result; 
      this.mita.total=this.mapartamento.deposito+this.mapartamento.valorApartamento;
      this.mita.idArriendo="100"+apartamento+Math.round(Math.random()*100)+idCustomer;  console.log(this.mita.idArriendo);
    });
  

  }
 
  private buildForm() {
    this.mita = new Arriendo();
   this.mita.idApartamento='';
    this.mita.idArriendo = '';
    
    this.mita.fechaDesalojo;
    this.mita.idCliente = '';
    this.mita.fechaIngreso;
 this.mita.total=0;
    this.cliente = new Cliente();
 
    this.cliente.idCliente=this.mita.idCliente;
    this.cliente.nombre='';
    this.cliente.telefono='';
    
    this.formGroup = this.formBuilder.group({
      idApartamento:[this.mita.idApartamento,Validators.required],
          idArriendo: [this.mita.idArriendo, Validators.required],
          idCliente: [this.mita.idCliente, Validators.required],
          idarriendo: [this.mita.idArriendo, Validators.required],
          nombre: this.cliente.nombre,
          telefono: [this.cliente.telefono],
          fechaIngreso: [this.mita.fechaIngreso,Validators.required],
          fechaDesalojo:this.mita.fechaIngreso
    });
  }
  get control() {
    return this.formGroup.controls;
  }

  onSubmit() {
    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }

  add() {
      this.mita = this.formGroup.value;
     /* this.movimiento=new Movimiento();
      this.movimiento.idMovimiento="4"+this.mita.idArriendo;
      this.movimiento.idUsuario="x";
      this.movimiento.fecha=this.mita.fechaIngreso;
      this.movimiento.detalle="ingreso";
      this.movimiento.valor=this.mita.total;
      console.log(this.movimiento);*/
    this.arriendoService.post(this.mita).subscribe(p => {
      if (p != null) {
        alert('Registro Completado!');
        this.mita = p;
      }
    });

  }
}
